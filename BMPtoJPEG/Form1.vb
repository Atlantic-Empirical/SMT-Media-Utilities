Imports System.IO

Public Class frmMain
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents lblProcessing As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblProcessing = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblProcessing
        '
        Me.lblProcessing.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessing.Location = New System.Drawing.Point(16, 56)
        Me.lblProcessing.Name = "lblProcessing"
        Me.lblProcessing.Size = New System.Drawing.Size(168, 23)
        Me.lblProcessing.TabIndex = 0
        Me.lblProcessing.Text = "PROCESSING"
        Me.lblProcessing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblProcessing.Visible = False
        '
        'frmMain
        '
        Me.AllowDrop = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(200, 166)
        Me.Controls.Add(Me.lblProcessing)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMain"
        Me.Text = "SMT -  BMP to JPEG"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMain_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragEnter
        e.Effect = DragDropEffects.All
    End Sub

    Private Sub frmMain_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim myFiles() As String = e.Data.GetData(DataFormats.FileDrop)
            Me.BackColor = System.Drawing.Color.Red
            Me.lblProcessing.Show()
            Me.Refresh()
            For Each file As String In myFiles
                If Not Path.HasExtension(file) Then
                    ConvertFolderBMPsToJPEG(file)
                Else
                    If Path.GetExtension(file).ToLower = ".bmp" Then
                        ConvertBMPtoJPEG(file)
                    End If
                End If
            Next
            Me.BackColor = SystemColors.Control
            Me.lblProcessing.Hide()
        End If
    End Sub

    Public Function ConvertFolderBMPsToJPEG(ByVal Dir As String) As Boolean
        Try
            Dim FIa() As String = Directory.GetFileSystemEntries(Dir)
            For Each f As String In FIa
                If Path.GetExtension(f).ToLower = ".bmp" Then
                    If Not ConvertBMPtoJPEG(Path.GetFullPath(f)) Then
                        Return False
                    End If
                Else
                    If Not Path.HasExtension(f) Then
                        Me.ConvertFolderBMPsToJPEG(f)
                    End If
                End If
            Next
            Return True
        Catch ex As Exception
            MsgBox("Problem with CFBTJ. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function ConvertBMPtoJPEG(ByVal FilePath As String) As Boolean
        Try
            Dim b As New Bitmap(FilePath)
            Dim targpath As String = Path.GetDirectoryName(FilePath) & "\" & Path.GetFileNameWithoutExtension(FilePath) & ".jpg"
            b.Save(targpath, System.Drawing.Imaging.ImageFormat.Jpeg)
            b.Dispose()
            b = Nothing
            targpath = Nothing
            Return True
        Catch ex As Exception
            MsgBox("Problem with convert. Error: " & ex.Message)
            Return False
        End Try
    End Function

End Class
