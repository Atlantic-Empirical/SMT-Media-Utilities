Imports System.IO
Imports SMT.Common.Media.DataParsing.MPEG2
Imports System.Text
Imports SMT.Common.Utilities.ConversionsAndSuch

Public Class Form1

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Try
            Dim dlg As New OpenFileDialog
            dlg.DefaultExt = ".vob"
            dlg.Filter = "VOB Files (*.vob)|*.vob|MPEG-2 Files (*.m2v, *.mpg, *.mpv, *.mpeg)|*.m2v;*.mpg;*.mpv;*.mpeg"
            dlg.FilterIndex = 0
            dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            dlg.Multiselect = False
            If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtPath.Text = dlg.FileName
            End If
        Catch ex As Exception
            MsgBox("hi")
        End Try
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Me.RunParse(Me.txtPath.Text)
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        Me.StopParse()
    End Sub

    Private Sub rtbDump_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.rtbDump.Clear()
    End Sub

    Private WithEvents MPEGParser As New cParseMPEG2

    Private Sub RunParse(ByVal FilePath As String)
        Try
            Me.rtbDump.AppendText(vbNewLine & FilePath & vbNewLine)
            MPEGParser = New cParseMPEG2
            If MPEGParser.ParseForGOPUserData(FilePath) Then
                MsgBox("Done")
            End If
        Catch ex As Exception
            Debug.WriteLine("Problem with RunParse(). Error: " & ex.Message)
        End Try
    End Sub

    Private Sub StopParse()
        If MPEGParser Is Nothing Then Exit Sub
        MPEGParser.StopProcessing = False
    End Sub

    Private Sub HandleNewGOPUserData(ByVal bytes() As Byte) Handles MPEGParser.evGOPUserData
        Try
            Dim out As New StringBuilder()
            For Each b As Byte In bytes
                out.Append(PadString(Hex(b), 2, "0", True) & " ")
            Next
            out.Append(vbNewLine)
            Me.rtbDump.AppendText(out.ToString)
            Me.rtbDump.ScrollToCaret()
        Catch ex As Exception
            Debug.WriteLine("Problem with HandleNewGOPUserData(). Error: " & ex.Message)
        End Try
    End Sub

    Private Sub txtBytesToCount_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBytesToCount.DoubleClick
        Me.txtBytesToCount.Text = ""
    End Sub

    Private Sub txtBytesToCount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBytesToCount.TextChanged
        Try
            Dim s() As String = Split(Me.txtBytesToCount.Text, " ")
            Me.lblByteCount.Text = s.Length
            s = Nothing
        Catch ex As Exception

        End Try
    End Sub

End Class
