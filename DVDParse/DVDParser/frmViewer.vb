Imports Sequoyan.Media.DirectShow.Microsoft

Public Class frmViewer
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Private DB As frmMain
    Public Sub New(ByRef D As frmMain)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        DB = D
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        '
        'frmViewer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(392, 289)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmViewer"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = " Jacket Picture"

    End Sub

#End Region

#Region "Form"

    Public IsManualClose As Boolean
    Private Sub MainForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If Not IsManualClose Then
            e.Cancel = True
        End If
    End Sub

    Private Sub MainForm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Dim rc As Rectangle = Me.ClientRectangle
        If DB Is Nothing Then Exit Sub
        If DB.VideoWin Is Nothing Then Exit Sub
        DB.VideoWin.SetWindowPosition(0, 0, rc.Right, rc.Bottom)
    End Sub

#End Region 'Form

End Class
