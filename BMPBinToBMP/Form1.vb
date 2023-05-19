Imports System.IO

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim out As String
        For Each F As String In Directory.GetFiles("C:\Temp\testing\")
            out = Path.GetDirectoryName(F) & "\" & Path.GetFileNameWithoutExtension(F) & ".bmp"
            Me.ProcessMultiGrabImage(F, out, System.Drawing.Imaging.ImageFormat.Bmp)
        Next
    End Sub

    Private Function ProcessMultiGrabImage(ByVal InPath As String, ByVal OutPath As String, ByVal OutFormat As Drawing.Imaging.ImageFormat) As Boolean
        Try
            Dim FS As New FileStream(InPath, FileMode.Open)
            Dim Buffer(FS.Length - 1) As Byte
            FS.Read(Buffer, 0, FS.Length)
            FS.Close()
            'File.Delete(InPath)

            Dim OutputFileSize As Integer = Buffer.Length + 54

            Dim W As Short = 720
            Dim H As Short = Buffer.Length / W / 3

            'Flip Image
            Buffer = FlipImageBuffer_Vertically(Buffer)
            Buffer = FlipRGB24ImageBuffer_Horizontally(Buffer, W, h)

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
            TmpBuff = ConvertDecimalIntoByteArray(W, 4)
            BMI(18) = TmpBuff(0)
            BMI(19) = TmpBuff(1)
            BMI(20) = TmpBuff(2)
            BMI(21) = TmpBuff(3)

            'Height
            TmpBuff = ConvertDecimalIntoByteArray(H, 4)
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

            'Make the bitmap object
            Dim MS As New MemoryStream(SampleBitmapBuffer.Length)
            MS.Write(SampleBitmapBuffer, 0, SampleBitmapBuffer.Length)
            Buffer = Nothing
            SampleBitmapBuffer = Nothing

            'Save BMP
            Dim BM As New Bitmap(MS)
            BM.Save(OutPath, OutFormat)

            'Clean up
            BM = Nothing
            MS.Close()
            MS = Nothing
            Return True
        Catch ex As Exception
            MsgBox("Problem with ProcessMultiGrabImage. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function FlipImageBuffer_Vertically(ByRef Buff() As Byte) As Byte()
        Try
            Array.Reverse(Buff)
            Return Buff
        Catch ex As Exception
            Throw New Exception("Problem with FlipRGBImageBuffer_Vertically. Error: " & ex.Message, ex)
        End Try
    End Function

    Public Function FlipRGB24ImageBuffer_Horizontally(ByRef Buff() As Byte, ByVal Width As Short, ByVal Height As Short) As Byte()
        Try
            Dim Stride As Short = Width * 3
            Dim out(UBound(Buff)) As Byte
            Dim Line(Stride - 1) As Byte
            Dim LineFirstByte As Integer = 0
            For v As Short = 0 To Height - 1
                Array.Reverse(Buff, LineFirstByte, Stride)
                LineFirstByte += Stride
            Next
            Return Buff
        Catch ex As Exception
            Throw New Exception("Problem with FlipRGBImageBuffer_Horizontally. Error: " & ex.Message, ex)
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
