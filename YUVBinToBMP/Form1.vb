Imports System.IO

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim FB As New FolderBrowserDialog
            FB.RootFolder = Environment.SpecialFolder.Desktop
            If FB.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.TextBox1.Text = FB.SelectedPath
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        BatchProcessRecordedImages()
    End Sub

    Public Function BatchProcessRecordedImages() As Boolean
        Try
            Dim DI As New DirectoryInfo(Me.TextBox1.Text)
            Dim Files() As FileInfo = DI.GetFiles
            Dim bMinute As Byte = DateTime.Now.Minute
            For Each File As FileInfo In Files
                If Me.ProcessOneRecordedImage(File.FullName, bMinute) Then
                    File.Delete()
                Else
                    Return False
                End If
            Next
            Return True
        Catch ex As Exception
            MsgBox("Prob with BatchProcessRecordedImages. Error: " & ex.Message)
        End Try
    End Function

    Public Function ProcessOneRecordedImage(ByVal fPath As String, ByVal bMinute As Byte) As Boolean
        Try
            Dim FS As New FileStream(fPath, FileMode.Open)
            Dim Buffer(FS.Length - 1) As Byte
            FS.Read(Buffer, 0, FS.Length)
            FS.Close()
            File.Delete(fPath)
            If File.Exists(fPath) Then
                File.Delete(fPath)
            End If

            Dim OutputFileSize As Integer = Buffer.Length + 54

            'Flip Image
            Buffer = FlipImageBuffer_Vertically(Buffer)
            Buffer = FlipRGB24ImageBuffer_Horizontally(Buffer, 720, 480)

            'Make BMI header
            Dim BMI(53) As Byte
            BMI(0) = 66 'B
            BMI(1) = 77 'M

            Dim TmpBuff() As Byte

            'FileSize
            TmpBuff = ConvertDecimalIntoByteArray(OutputFileSize, 4)
            BMI(2) = TmpBuff(0)
            BMI(3) = TmpBuff(1)
            BMI(4) = TmpBuff(2)
            BMI(5) = TmpBuff(3)

            BMI(10) = 54 'Header size
            BMI(14) = 40 'InfoHeader size

            'Width
            TmpBuff = ConvertDecimalIntoByteArray(720, 4)
            BMI(18) = TmpBuff(0)
            BMI(19) = TmpBuff(1)
            BMI(20) = TmpBuff(2)
            BMI(21) = TmpBuff(3)

            'Height
            TmpBuff = ConvertDecimalIntoByteArray(480, 4)
            BMI(22) = TmpBuff(0)
            BMI(23) = TmpBuff(1)
            BMI(24) = TmpBuff(2)
            BMI(25) = TmpBuff(3)

            BMI(26) = 1 'Planes
            BMI(28) = 24 'Bit depth

            BMI(38) = 196
            BMI(39) = 14
            BMI(42) = 196
            BMI(43) = 14

            Dim SampleBitmapBuffer(OutputFileSize) As Byte
            Array.Copy(BMI, 0, SampleBitmapBuffer, 0, 54)
            Array.Copy(Buffer, 0, SampleBitmapBuffer, 54, Buffer.Length)

            'DEBUGGING
            '    FS = New FileStream("C:\Temp\test_1.bmp", FileMode.OpenOrCreate)
            '    FS.Write(SampleBitmapBuffer, 0, SampleBitmapBuffer.Length)
            '    FS.Close()
            '    FS = Nothing
            'END DEBUGGING

            'Make the bitmap object
            Dim MS As New MemoryStream(SampleBitmapBuffer.Length)
            MS.Write(SampleBitmapBuffer, 0, SampleBitmapBuffer.Length)
            Buffer = Nothing
            SampleBitmapBuffer = Nothing

            ''DEBUGGING
            'FS = New FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "test.bmp", FileMode.OpenOrCreate)
            'MS.WriteTo(FS)
            'FS.Close()
            'FS = Nothing
            ''END DEBUGGING

            Dim BM As New Bitmap(MS)
            'BM.Save("C:\temp\test.bmp")

            'Get save location
            Dim OutPath As String = Path.GetDirectoryName(fPath)
            OutPath &= "\Output_" & bMinute & "\" & Path.GetFileNameWithoutExtension(fPath) & ".bmp"
            If Not Directory.Exists(Path.GetDirectoryName(OutPath)) Then Directory.CreateDirectory(Path.GetDirectoryName(OutPath))

            BM.Save(OutPath, System.Drawing.Imaging.ImageFormat.Bmp)

            'DEBUGGING
            'BM.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\test.bmp")

            ''Save the bitmap
            'Dim FS As New FileStream(tOutpath, FileMode.OpenOrCreate)
            'FS.Write(Buffer, 0, Buffer.Length)
            'FS.Close()
            'FS = Nothing
            'END DEBUGGING

            'Clean up
            'BM = Nothing
            MS.Close()
            MS = Nothing
            Return True
        Catch ex As Exception
            MsgBox("Problem with ProcessMultiGrabImage. Error: " & ex.Message, Nothing, Nothing)
            Return False
        End Try

        'Try
        '    Dim fs As New FileStream(fPath, IO.FileMode.Open)
        '    Dim Buffer(fs.Length - 1) As Byte
        '    fs.Read(Buffer, 0, fs.Length)
        '    fs.Close()
        '    fs = Nothing

        '    Dim OutputFileSize As Integer = (720 * 480 * 3) + 54
        '    'Dim OutputFileSize As Integer = (1920 * 1080 * 3) + 54

        '    ''DEBUGGING - Save the buffer
        '    'FS = New FileStream("C:\Test\Buffer.bin", FileMode.OpenOrCreate)
        '    'FS.Write(Buffer, 0, Buffer.Length)
        '    'FS.Close()
        '    'FS = Nothing
        '    ''END DEBUGGING

        '    'Flip Image
        '    Buffer = FlipImageBuffer_Vertically(Buffer)
        '    Buffer = FlipRGB24ImageBuffer_Horizontally(Buffer, 720, 480)
        '    'Buffer = FlipRGB24ImageBuffer_Horizontally(Buffer, 1920, 1080)

        '    'Make BMI header
        '    Dim BMI(53) As Byte
        '    BMI(0) = &H42 'B
        '    BMI(1) = &H4D 'M

        '    'FileSize
        '    '36 ec 5e 00 = 6220854
        '    BMI(2) = &H36
        '    BMI(3) = &HEC
        '    BMI(4) = &H5E
        '    BMI(5) = 0

        '    BMI(10) = &H36 'Header size
        '    BMI(14) = &H28 'InfoHeader size

        '    'Width
        '    BMI(18) = &H80
        '    BMI(19) = &H7
        '    BMI(20) = 0
        '    BMI(21) = 0

        '    'Height
        '    BMI(22) = &H38
        '    BMI(23) = &H4
        '    BMI(24) = 0
        '    BMI(25) = 0

        '    BMI(26) = 1     'Planes
        '    BMI(28) = &H18  'Bit depth

        '    'Raster data size
        '    BMI(34) = 0
        '    BMI(35) = &HEC
        '    BMI(36) = &H5E
        '    BMI(37) = 0

        '    '42 4d = BM
        '    '36 ec 5e 00 = filesize
        '    '00 00 00 00 
        '    '36 00 00 00 = header size 
        '    '28 00 00 00 = infoheader size
        '    '80 07 00 00 = width
        '    '38 04 00 00 = height
        '    '01 00 = planes
        '    '18 00 = bitdepth
        '    '00 00 00 00 
        '    '00 ec 5e 00 = raster data size 
        '    '00 00 00 00 
        '    '00 00 00 00 
        '    '00 00 00 00 
        '    '00 00 00 00 

        '    Dim SampleBitmapBuffer(OutputFileSize) As Byte
        '    Array.Copy(BMI, 0, SampleBitmapBuffer, 0, 54)
        '    Array.Copy(Buffer, 0, SampleBitmapBuffer, 54, Buffer.Length)

        '    ''OUTPUT
        '    'Dim OutPath As String = Path.GetDirectoryName(fPath)
        '    'OutPath &= "\BMPs\" & Path.GetFileNameWithoutExtension(fPath) & ".bmp"
        '    'If Not Directory.Exists(Path.GetDirectoryName(OutPath)) Then Directory.CreateDirectory(Path.GetDirectoryName(OutPath))
        '    'fs = New FileStream(OutPath, IO.FileMode.OpenOrCreate)
        '    'fs.Write(SampleBitmapBuffer, 0, SampleBitmapBuffer.Length)
        '    'fs.Close()
        '    'fs = Nothing

        '    'Buffer = Nothing
        '    'SampleBitmapBuffer = Nothing
        '    'Return True

        '    'Buffer = Nothing

        '    'Make the bitmap object
        '    Dim MS As New MemoryStream(SampleBitmapBuffer.Length)
        '    MS.Write(SampleBitmapBuffer, 0, SampleBitmapBuffer.Length)
        '    Dim BM As New Bitmap(MS)

        '    ''debugging
        '    'fs = New FileStream("c:\temp.bmp", IO.FileMode.OpenOrCreate)
        '    'fs.Write(SampleBitmapBuffer, 0, SampleBitmapBuffer.Length)
        '    'fs.Close()
        '    'fs = Nothing
        '    'Dim BM As New Bitmap("C:\temp.bmp")
        '    'Me.pbFrameGrab.Image = BM
        '    'Return False
        '    ''debugging

        '    'SampleBitmapBuffer = Nothing

        '    'BM = Me.ScaleImage(BM, 1080, 1920)

        '    'DEBUGGING
        '    'BM.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\test.bmp")

        '    ''Save the bitmap
        '    'Dim FS As New FileStream(tOutpath, FileMode.OpenOrCreate)
        '    'FS.Write(Buffer, 0, Buffer.Length)
        '    'FS.Close()
        '    'FS = Nothing
        '    'END DEBUGGING

        '    'Get save location
        '    Dim OutPath As String = Path.GetDirectoryName(fPath)
        '    OutPath &= "\Output_" & bMinute & "\" & Path.GetFileNameWithoutExtension(fPath) & ".bmp"
        '    If Not Directory.Exists(Path.GetDirectoryName(OutPath)) Then Directory.CreateDirectory(Path.GetDirectoryName(OutPath))

        '    'Save the image
        '    BM.Save(OutPath, System.Drawing.Imaging.ImageFormat.Bmp)
        '    BM.Dispose()

        '    'Clean up
        '    BM = Nothing
        '    'MS.Close()
        '    'MS = Nothing
        '    Return True
        'Catch ex As Exception
        '    MsgBox("Prob with ProcessOneRecordImage. Error: " & ex.Message)
        'End Try
    End Function

    Public Function FlipImageBuffer_Vertically(ByVal Buff() As Byte) As Byte()
        Try
            Dim out(UBound(Buff)) As Byte
            Dim ix As Integer = 0
            For i As Integer = UBound(Buff) To 0 Step -1
                out(ix) = Buff(i)
                ix += 1
            Next
            Return out
        Catch ex As Exception
            MsgBox("Problem with FlipRGBImageBuffer_Vertically. Error: " & ex.Message)
        End Try
    End Function

    Public Function FlipRGB24ImageBuffer_Horizontally(ByVal Buff() As Byte, ByVal Width As Short, ByVal Height As Short) As Byte()
        Try
            Dim Stride As Short = Width * 3
            Dim out(UBound(Buff)) As Byte
            Dim Line(Stride) As Byte
            Dim LineFirstByte As Integer = 0
            Dim ix As Short
            For v As Short = 0 To Height - 1
                Debug.WriteLine(v)
                'Put the line into the line array
                Array.Copy(Buff, LineFirstByte, Line, 0, Stride)

                'Copy the line to the out array, starting from right to left to flip image.
                ix = Stride - 1
                For i As Short = 0 To Stride - 1
                    out(LineFirstByte + i) = Line(ix)
                    ix -= 1
                Next
                LineFirstByte += Stride
            Next
            Return out
        Catch ex As Exception
            MsgBox("Problem with FlipRGBImageBuffer_Horizontally. Error: " & ex.Message)
        End Try
    End Function

    Public Function ConvertDecimalIntoByteArray(ByVal Num As Integer, ByVal MinimumSize As Short) As Byte()
        Try
            Dim HexSize As String = Hex(Num)

            If Not IsEven(Len(HexSize)) Then
                HexSize = "0" & HexSize
            End If

            Dim TargetArraySize As Short = HexSize.Length / 2
            Dim Out(TargetArraySize) As Byte

            Dim ix As Short = 0
            For i As Short = Len(HexSize) To 1 Step -2
                Out(ix) = CInt("&H" & Mid(HexSize, i - 1, 2))
                ix += 1
            Next

            If Out.Length < MinimumSize Then
                ReDim Preserve Out(MinimumSize)
            End If

            Return Out
        Catch ex As Exception
            MsgBox("Problem with ConvertDecimalIntoByteArray. Error: " & ex.Message)
        End Try
    End Function

    Public Function IsEven(ByVal Num As Integer) As Boolean
        Try
            Dim Remainder As Integer
            Math.DivRem(Num, 2, Remainder)
            If Remainder > 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox("Problem with IsEven. Error: " & ex.Message)
        End Try
    End Function

End Class
