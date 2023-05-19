Public Class frmViewer
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Private DB As Form1
    Public Sub New(ByRef D As Form1)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.KeyPreview = True
        Me.Name = "frmViewer"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = " Phoenix - Viewer"

    End Sub

#End Region

    '#Region "Form"

    Public IsManualClose As Boolean
    Private Sub MainForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        ''db.ToggleViewer()
        If Not IsManualClose Then
            e.Cancel = True
        End If
    End Sub

    '    Private Sub MainForm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
    '        Dim rc As Rectangle = Me.ClientRectangle
    '        If DB Is Nothing Then Exit Sub
    '        If DB.VideoWin Is Nothing Then Exit Sub
    '        DB.VideoWin.SetWindowPosition(0, 0, rc.Right, rc.Bottom)
    '        DB.ViewerSize = New System.Drawing.Size(Me.Width, Me.Height)
    '    End Sub

    '    Private Sub MainForm_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
    '        If DB.DVDCtrl Is Nothing Or DB.menuMode <> DB.eMenuMode.Buttons Then Exit Sub
    '        Dim pt As DirectShow.DsPOINT
    '        pt.X = e.X
    '        pt.Y = e.Y
    '        DB.DVDCtrl.SelectAtPosition(pt)
    '    End Sub

    '    Private Sub MainForm_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
    '        If DB.DVDCtrl Is Nothing Or DB.menuMode <> DB.eMenuMode.Buttons Then Exit Sub
    '        Dim pt As DirectShow.DsPOINT
    '        pt.X = e.X
    '        pt.Y = e.Y
    '        DB.DVDCtrl.ActivateAtPosition(pt)
    '    End Sub

    '    Private Sub MainForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
    '        DB.frmController_KeyDown(sender, e)
    '        ''If db.pendingCmd Then Exit Sub
    '        ''If db.playState = db.ePlayState.Init Then Exit Sub
    '        'Select Case e.KeyValue
    '        '    Case 190 'Period key
    '        '        StepForward()
    '        '        e.Handled = True
    '        'End Select
    '        'Select Case e.KeyCode
    '        '    Case Keys.Space, Keys.P
    '        '        db.StartPlayback()
    '        '        e.Handled = True

    '        '    Case Keys.S
    '        '        db.StopPlayback()
    '        '        e.Handled = True

    '        '    Case Keys.D1
    '        '        db.StepForward()
    '        '        e.Handled = True

    '        '    Case Keys.N
    '        '        db.NextChapter()
    '        '        e.Handled = True

    '        '    Case Keys.B
    '        '        db.PreviousChapter()
    '        '        e.Handled = True

    '        '    Case Keys.F
    '        '        db.ToggleFullScreen()
    '        '        e.Handled = True

    '        '    Case Keys.Escape
    '        '        If db.fullScreen Then
    '        '            db.ToggleFullScreen()
    '        '        End If
    '        '        e.Handled = True

    '        '    Case Keys.Home
    '        '        db.GoToMenu(DvdMenuID.Root)
    '        '        e.Handled = True

    '        '    Case Keys.T
    '        '        db.GoToMenu(DvdMenuID.Title)
    '        '        e.Handled = True

    '        '    Case Keys.Left
    '        '        db.LeftBtn()
    '        '        e.Handled = True

    '        '    Case Keys.Right
    '        '        db.RightBtn()
    '        '        e.Handled = True

    '        '    Case Keys.Up
    '        '        db.UpBtn()
    '        '        e.Handled = True

    '        '    Case Keys.Down
    '        '        db.DownBtn()
    '        '        e.Handled = True

    '        '    Case Keys.Enter
    '        '        db.EnterBtn()
    '        '        e.Handled = True

    '        '    Case Keys.D
    '        '        db.ToggleViewer()

    '        'End Select
    '    End Sub

    '    'Private Sub frmViewer_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
    '    '    db.Focus()
    '    'End Sub

    '    Private Sub frmViewer_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
    '        Me.Focus()
    '    End Sub

    '#End Region 'Form

    Protected Overrides Sub WndProc(ByRef m As Message)
        'Debug.WriteLine("Message: " & m.Msg)
        Select Case m.Msg
            Case DB.WM_USER
                Debug.WriteLine("WM_USER: " & m.Msg)

            Case DB.WM_GRAPHNOTIFY
                Debug.WriteLine("WM_GRAPHNOTIFY: " & m.Msg)

            Case DB.WM_DVD_EVENT
                'Debug.WriteLine("WM_DVD_EVENT: " & m.Msg)
                If Not DB.MediaEvt Is Nothing Then
                    'DB.OnDvdEvent()
                End If
                Exit Sub
        End Select
        MyBase.WndProc(m)
    End Sub

End Class
