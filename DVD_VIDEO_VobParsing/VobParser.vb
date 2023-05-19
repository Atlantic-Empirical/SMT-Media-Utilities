Imports SMT.Multimedia.Formats.DVD.VOB
Imports System.IO

Public Class VobParser

    Private V As cVOBS

    Private Sub btnParse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnParse.Click
        Parse()
    End Sub

    Private Sub Parse()
        Try
            Dim s As String = "D:\MEDIA\SDDVD\TWO_TOWERS_NTSC_R1_D2\VIDEO_TS\vts_01_1.vob"
            'Dim s As String = "D:\MEDIA\SDDVD\TWO_TOWERS_NTSC_R1_D2\VIDEO_TS\Video_TS.vob"

            V = New cVOBS(s)
            Debug.WriteLine(v.ToString)
        Catch ex As Exception
            MsgBox("Problem with Parse(). Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnGetFS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetFS.Click
        GetFS(Me.txtOffset.Text)
    End Sub

    Private Sub GetFS(ByVal Offset As UInt64)
        Try
            Dim np As cVOBPack.cNavPacket = V.GetNextNavPack(Offset)
            Debug.WriteLine("hi")

            'Dim fs As FileStream = V.GetFilestream(Offset)
        Catch ex As Exception
            MsgBox("Problem with GetFS(). Error: " & ex.Message)
        End Try
    End Sub

End Class
