Imports Javelin.Libraries.Common.FileSystems.ISO9660

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim R As New cISO9660_Reader("C:\MEDIA\Disc Image Files\2054 bytes per sector\DiscImage2.dvd", 2054, "")

            MsgBox("hi")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
