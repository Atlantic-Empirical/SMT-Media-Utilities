Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Threading
Imports System.IO.Pipes

Public Class VOBReader_Main

    Private WithEvents VOBExtractor As cVOBExtractor
    Private WithEvents VOBExtractor2 As cVOBExtractor
    Private ExtractThread As Thread
    Private Shared ProcessStartTicks As Long

    ''' <summary>
    ''' Read a single sector from the VOB.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnExtractOneSector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtractOneSector.Click
        Try
            VOBExtractor = New cVOBExtractor(Me.txtFileName.Text)

            Dim p As IntPtr
            Dim HR As Integer = VOBExtractor.IVR.ReadSector(txtSector.Text, p)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            'Debug.WriteLine(vbNewLine & "managed pointer = 0x" & Hex(p.ToInt32).PadLeft(8, "0"))
            Dim b(2047) As Byte
            Marshal.Copy(p, b, 0, 2048)
            Marshal.FreeCoTaskMem(p) 'RELEASE THE BUFFER!

            '' DUMP SECTOR TO FILE
            'Dim dumppath As String = OUTPUT_FOLDER & "managed_dump.bin"
            'If File.Exists(dumppath) Then File.Delete(dumppath)
            'Dim FS As New FileStream(dumppath, IO.FileMode.CreateNew)
            'FS.Write(b, 0, 2048)
            'FS.Close()
            '' DUMP SECTOR TO FILE

            ' PUT SECTOR IN TXTBOX
            Dim st As String
            Dim sb As New System.Text.StringBuilder
            For i As Integer = 0 To 2047
                st = Hex(b(i))
                If st.Length < 2 Then st = st.PadLeft(2, "0")
                sb.Append(st)
            Next
            txtDump.Clear()
            txtDump.Text = sb.ToString
            ' PUT SECTOR IN TXTBOX

            txtSector.Text += 1

        Catch ex As Exception
            txtDump.Clear()
            MsgBox("Problem with TestA. Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUnlockDrive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnlockDrive.Click
        MsgBox(If(cVOBExtractor.UnlockDrive("G"c), "Success", "Failure"))
    End Sub

    Private Sub btnTestA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestA.Click
        Try

            'VOBExtractor2 = New cVOBExtractor(Me.txtFileName.Text)

            'Dim p As IntPtr
            'Dim HR As Integer = VOBExtractor2.IVR.Test_A(p, 1)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            ''Debug.WriteLine(vbNewLine & "managed pointer = 0x" & Hex(p.ToInt32).PadLeft(8, "0"))
            'Dim b(2047) As Byte
            'Marshal.Copy(p, b, 0, 2048)
            'Marshal.FreeCoTaskMem(p) 'RELEASE THE BUFFER!

            ' '' DUMP SECTOR TO FILE
            ''Dim dumppath As String = OUTPUT_FOLDER & "managed_dump.bin"
            ''If File.Exists(dumppath) Then File.Delete(dumppath)
            ''Dim FS As New FileStream(dumppath, IO.FileMode.CreateNew)
            ''FS.Write(b, 0, 2048)
            ''FS.Close()
            ' '' DUMP SECTOR TO FILE

            '' PUT SECTOR IN TXTBOX
            'Dim st As String
            'Dim sb As New System.Text.StringBuilder
            'For i As Integer = 0 To 2047
            '    st = Hex(b(i))
            '    If st.Length < 2 Then st = st.PadLeft(2, "0")
            '    sb.Append(st)
            'Next
            'txtDump.Clear()
            'txtDump.Text = sb.ToString
            '' PUT SECTOR IN TXTBOX

            'txtSector.Text += 1

        Catch ex As Exception
            txtDump.Clear()
            MsgBox("Problem with TestA. Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnTestB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestB.Click

    End Sub

    ' NOTE: running the extract on a bg thread is MUCH faster (2x+) on larger extractions (200MB+)

    ''' <summary>
    ''' Multi-threaded extract of the VOB.
    ''' Extracts @~ 0.75s / 10MB
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnExtract_Mthread_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtract_Mthread.Click
        Try
            VOBExtractor = New cVOBExtractor(Me.txtFileName.Text)
            Me.pbMain.Minimum = 0
            Me.pbMain.Maximum = VOBExtractor.SectorCount - 1
            Me.pbMain.Value = 0
            ExtractThread = New Thread(AddressOf VOBExtractor.Start)
            ExtractThread.Priority = ThreadPriority.AboveNormal
            ExtractThread.Start()
        Catch ex As Exception
            MsgBox("Problem with ReadEntireFile(). Error: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Run on main thread.
    ''' Extracts @~ 0.12sec / 10MB 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnExtract_1thread_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtract_1thread.Click
        Try
            Dim src As String = txtFileName.Text
            Dim fp As String = "C:\Temp\VOBReader\" & Path.GetFileName(src)
            If File.Exists(fp) Then File.Delete(fp)
            Dim FS As New FileStream(fp, FileMode.Create, FileAccess.Write)
            VOBExtractor = New cVOBExtractor(Me.txtFileName.Text.ToUpper)

            Dim VOBSize As Long = New FileInfo(src).Length
            Dim SectorCount As Integer = VOBSize / 2048 'TODO: does this need to be 2056 if the disc is css encrypted? is this why we're getting hits?

            Me.pbMain.Minimum = 0
            Me.pbMain.Maximum = SectorCount - 1
            Me.pbMain.Value = 0

            ' DEBUGGING
            Dim fi As New FileInfo(src)
            Dim BytesToExtract As Long = Math.Min(104857600, fi.Length) '104857600 '10485760 20971520
            SectorCount = BytesToExtract / 2048
            ' DEBUGGING

            Dim stm As Long = DateTime.Now.Ticks
            For i As Integer = 0 To SectorCount - 1
                VOBExtractor.WriteSectorToStream(FS, i)
            Next
            Dim edm As Long = DateTime.Now.Ticks

            Debug.WriteLine("Ticks Start = " & stm)
            Debug.WriteLine("Ticks End = " & edm)
            Dim inter As Long = edm - stm
            Debug.WriteLine("Ticks Interval = " & inter)
            Dim d As Double = inter / TimeSpan.TicksPerSecond

            FS.Close()
            VOBExtractor.Dispose()

            MsgBox("success. duration = " & Math.Round(d, 2) & " ticks = " & inter)

        Catch ex As Exception
            MsgBox("Problem with ReadEntireFile(). Error: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Not used for anything significant here.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Handle_FileStart() Handles VOBExtractor.evStart
        ProcessStartTicks = DateTime.Now.Ticks
    End Sub

    Private Sub Handle_FileComplete(ByVal DurationTicks As Long) Handles VOBExtractor.evComplete
        Try
            'Debug.WriteLine("Ticks Interval = " & DurationTicks)
            Dim d As Double = DurationTicks / TimeSpan.TicksPerSecond
            MsgBox("File extract success. Duration = " & Math.Round(d, 2) & " seconds | " & DurationTicks & " ticks")
            VOBExtractor.Dispose()
        Catch ex As Exception
            MsgBox("Problem with Handle_FileComplete(). Error: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' This method needs a delegate implementation to handle the Invoke issue.
    ''' Uncomment the line and you'll see the exception.
    ''' </summary>
    ''' <param name="SectorNumber"></param>
    ''' <remarks></remarks>
    Private Sub Handle_ReadSector(ByVal SectorNumber As UInt64) Handles VOBExtractor.evSectorRead
        Try
            'Me.pbMain.Value = SectorNumber
        Catch ex As Exception
            MsgBox("Problem with Handle_ReadSector(). Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If VOBExtractor IsNot Nothing Then VOBExtractor.Dispose()
        If VOBExtractor2 IsNot Nothing Then VOBExtractor2.Dispose()
    End Sub

    '#Region "OUTPUT"

    '    Private StdError As Stream
    '    Private StdError_SR As StreamReader
    '    Private StdOutput As Stream
    '    Private StdOutput_SR As StreamReader

    '    Private Sub ReadOutput()
    '        Try
    '            'While Not StdError_SR.EndOfStream
    '            '    Debug.WriteLine("libdvdcss - " & StdError_SR.ReadLine())
    '            'End While
    '            'While Not StdOutput_SR.EndOfStream
    '            '    Debug.WriteLine("libdvdcss - " & StdOutput_SR.ReadLine())
    '            'End While


    '        Catch ex As Exception
    '            MsgBox("Problem with ReadOutput(). Error: " & ex.Message)
    '        End Try
    '    End Sub

    '    Private Sub SetupStdErrorStream()
    '        Try
    '            Dim id As Integer = Process.GetCurrentProcess().Id

    '            Dim serverPipe As New NamedPipeServerStream("consoleRedirect" + id, PipeDirection.[In], 1)
    '            serverPipe.WaitForConnection()
    '            Using stm As New StreamReader(serverPipe)
    '                While serverPipe.IsConnected
    '                    Try
    '                        Dim txt As String = stm.ReadLine()
    '                        If Not String.IsNullOrEmpty(txt) Then
    '                            MessageBox.Show("Got stdout with: " + txt)
    '                        End If
    '                    Catch generatedExceptionName As IOException
    '                        ' normal disconnect 
    '                        Exit Try
    '                    End Try
    '                End While
    '            End Using

    '            ''Console.SetOut(

    '            'StdError = Console.OpenStandardError(2048)
    '            'StdError_SR = New StreamReader(StdError)

    '            'StdOutput = Console.OpenStandardOutput(2048)
    '            'StdOutput_SR = New StreamReader(StdOutput)

    '            ''Const STD_INPUT_HANDLE As Integer = -10
    '            ''Const STD_OUTPUT_HANDLE As Integer = -11
    '            ''Const STD_ERROR_HANDLE As Integer = -12

    '            ''Dim iStdOut As IntPtr = GetStdHandle(STD_ERROR_HANDLE)
    '            ''Dim Current As Process = System.Diagnostics.Process.GetCurrentProcess()
    '            ''StdError = Current.StandardError
    '        Catch ex As Exception
    '            MsgBox("Problem with SetupStdErrStream(). Error: " & ex.Message)
    '        End Try
    '    End Sub

    '#End Region 'OUTPUT

End Class
