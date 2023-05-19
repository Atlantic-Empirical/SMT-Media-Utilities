Imports SMT.Multimedia.Formats.DVD.IFO

Public Class Form1

    Private Sub btnParse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnParse.Click
        Dim s() As String = Split(Me.txtCmd.Text, " ")
        Dim b As New List(Of Byte)
        For Each sx As String In s
            b.Add(Byte.Parse(sx, Globalization.NumberStyles.HexNumber))
        Next
        Me.Parse(b.ToArray)
    End Sub

    Private Sub Parse(ByVal cmd_bytes() As Byte)
        Try
            Dim cmd As New cCMD(cmd_bytes, 0)
            Me.txtOutput.Text = cmd.ToString
        Catch ex As Exception
            MsgBox("Problem with Parse(). Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDebug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDebug.Click
        ToUInt64ProviderDemo.Main()
    End Sub

End Class
