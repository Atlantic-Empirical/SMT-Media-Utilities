Public Class Form1
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtV As System.Windows.Forms.TextBox
    Friend WithEvents txtU As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtY As System.Windows.Forms.TextBox
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents txtG As System.Windows.Forms.TextBox
    Friend WithEvents txtR As System.Windows.Forms.TextBox
    Friend WithEvents btnRGB2YUV As System.Windows.Forms.Button
    Friend WithEvents btnYUV2RGB As System.Windows.Forms.Button
    Friend WithEvents pnlRGB As System.Windows.Forms.Panel
    Friend WithEvents pnlYUV As System.Windows.Forms.Panel
    Friend WithEvents btnClear As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtB = New System.Windows.Forms.TextBox
        Me.txtG = New System.Windows.Forms.TextBox
        Me.txtR = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtV = New System.Windows.Forms.TextBox
        Me.txtU = New System.Windows.Forms.TextBox
        Me.txtY = New System.Windows.Forms.TextBox
        Me.pnlRGB = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnlYUV = New System.Windows.Forms.Panel
        Me.btnRGB2YUV = New System.Windows.Forms.Button
        Me.btnYUV2RGB = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(72, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 16)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "B"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(40, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 16)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "G"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 16)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "R"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(72, 24)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(29, 20)
        Me.txtB.TabIndex = 36
        Me.txtB.Text = ""
        '
        'txtG
        '
        Me.txtG.Location = New System.Drawing.Point(40, 24)
        Me.txtG.Name = "txtG"
        Me.txtG.Size = New System.Drawing.Size(29, 20)
        Me.txtG.TabIndex = 35
        Me.txtG.Text = ""
        '
        'txtR
        '
        Me.txtR.Location = New System.Drawing.Point(8, 24)
        Me.txtR.Name = "txtR"
        Me.txtR.Size = New System.Drawing.Size(29, 20)
        Me.txtR.TabIndex = 34
        Me.txtR.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(232, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 16)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "V"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(200, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 16)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "U"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtV
        '
        Me.txtV.Location = New System.Drawing.Point(232, 24)
        Me.txtV.Name = "txtV"
        Me.txtV.Size = New System.Drawing.Size(29, 20)
        Me.txtV.TabIndex = 29
        Me.txtV.Text = ""
        '
        'txtU
        '
        Me.txtU.Location = New System.Drawing.Point(200, 24)
        Me.txtU.Name = "txtU"
        Me.txtU.Size = New System.Drawing.Size(29, 20)
        Me.txtU.TabIndex = 26
        Me.txtU.Text = ""
        '
        'txtY
        '
        Me.txtY.Location = New System.Drawing.Point(168, 24)
        Me.txtY.Name = "txtY"
        Me.txtY.Size = New System.Drawing.Size(29, 20)
        Me.txtY.TabIndex = 25
        Me.txtY.Text = ""
        '
        'pnlRGB
        '
        Me.pnlRGB.BackColor = System.Drawing.Color.Red
        Me.pnlRGB.Location = New System.Drawing.Point(8, 48)
        Me.pnlRGB.Name = "pnlRGB"
        Me.pnlRGB.Size = New System.Drawing.Size(104, 80)
        Me.pnlRGB.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(168, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 16)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Y"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlYUV
        '
        Me.pnlYUV.BackColor = System.Drawing.Color.Red
        Me.pnlYUV.Location = New System.Drawing.Point(168, 48)
        Me.pnlYUV.Name = "pnlYUV"
        Me.pnlYUV.Size = New System.Drawing.Size(104, 80)
        Me.pnlYUV.TabIndex = 40
        '
        'btnRGB2YUV
        '
        Me.btnRGB2YUV.Location = New System.Drawing.Point(120, 48)
        Me.btnRGB2YUV.Name = "btnRGB2YUV"
        Me.btnRGB2YUV.Size = New System.Drawing.Size(40, 23)
        Me.btnRGB2YUV.TabIndex = 41
        Me.btnRGB2YUV.Text = "-->"
        '
        'btnYUV2RGB
        '
        Me.btnYUV2RGB.Location = New System.Drawing.Point(120, 76)
        Me.btnYUV2RGB.Name = "btnYUV2RGB"
        Me.btnYUV2RGB.Size = New System.Drawing.Size(40, 23)
        Me.btnYUV2RGB.TabIndex = 42
        Me.btnYUV2RGB.Text = "<--"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(120, 104)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(40, 23)
        Me.btnClear.TabIndex = 43
        Me.btnClear.Text = "X"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(280, 134)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnYUV2RGB)
        Me.Controls.Add(Me.btnRGB2YUV)
        Me.Controls.Add(Me.pnlYUV)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtG)
        Me.Controls.Add(Me.txtR)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtV)
        Me.Controls.Add(Me.txtU)
        Me.Controls.Add(Me.txtY)
        Me.Controls.Add(Me.pnlRGB)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "YUV-RGB"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "YUV->RGB"

    Private Sub btnYUV2RGB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYUV2RGB.Click
        YUV2RGB()
    End Sub

    Public Sub YUV2RGB()
        Dim R, G, B As Integer
        If Me.txtY.Text = "" Then Me.txtY.Text = "0"
        If Me.txtU.Text = "" Then Me.txtU.Text = "0"
        If Me.txtV.Text = "" Then Me.txtV.Text = "0"

        If CInt(Me.txtY.Text) > 255 Then Me.txtY.Text = "255"
        If CInt(Me.txtU.Text) > 128 Then Me.txtU.Text = "128"
        If CInt(Me.txtV.Text) > 128 Then Me.txtV.Text = "128"

        If CInt(Me.txtY.Text) < 0 Then Me.txtY.Text = "0"
        If CInt(Me.txtU.Text) < -128 Then Me.txtU.Text = "-128"
        If CInt(Me.txtV.Text) < -128 Then Me.txtV.Text = "-128"

        YUV2RGB(CInt(Me.txtY.Text), CInt(Me.txtU.Text), CInt(Me.txtV.Text), R, G, B)
        Me.txtR.Text = R
        Me.txtG.Text = G
        Me.txtB.Text = B
        Me.pnlYUV.BackColor = Color.FromArgb(255, R, G, B)
        Me.pnlRGB.BackColor = Color.FromArgb(255, CInt(Me.txtR.Text), CInt(Me.txtG.Text), CInt(Me.txtB.Text))
    End Sub

    Public Sub YUV2RGB(ByRef Y As Integer, ByRef U As Integer, ByRef V As Integer, ByRef R As Integer, ByRef G As Integer, ByRef B As Integer)
        Try
            R = Y - ((U * 0.394) - (V * 0.581))
            G = Y + (V * 1.436)
            B = Y + (U * 2.032)
            If R < 0 Then R = 0
            If R > 255 Then R = 255
            If B < 0 Then B = 0
            If B > 255 Then B = 255
            If G < 0 Then G = 0
            If G > 255 Then G = 255
        Catch ex As Exception
            MsgBox("Problem with YUV2RGB. Error: " & ex.Message)
        End Try
    End Sub

#End Region

#Region "RGB->YUV"

    Private Sub btnRGB2YUV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRGB2YUV.Click
        RGB2YUV()
    End Sub

    Public Sub RGB2YUV()
        Dim Y, U, V As Integer

        If Me.txtR.Text = "" Then Me.txtR.Text = "0"
        If Me.txtG.Text = "" Then Me.txtG.Text = "0"
        If Me.txtB.Text = "" Then Me.txtB.Text = "0"

        RGB2YUV(Y, U, V, CInt(Me.txtR.Text), CInt(Me.txtG.Text), CInt(Me.txtB.Text))
        Me.txtY.Text = Y
        Me.txtU.Text = U
        Me.txtV.Text = V
        Me.pnlRGB.BackColor = Color.FromArgb(255, CInt(Me.txtR.Text), CInt(Me.txtG.Text), CInt(Me.txtB.Text))

        Dim R, G, B As Integer
        If Me.txtY.Text = "" Then Me.txtY.Text = "0"
        If Me.txtU.Text = "" Then Me.txtU.Text = "0"
        If Me.txtV.Text = "" Then Me.txtV.Text = "0"

        'If CInt(Me.txtY.Text) > 255 Then Me.txtY.Text = "255"
        'If CInt(Me.txtU.Text) > 128 Then Me.txtU.Text = "128"
        'If CInt(Me.txtV.Text) > 128 Then Me.txtV.Text = "128"

        'If CInt(Me.txtY.Text) < 0 Then Me.txtY.Text = "0"
        'If CInt(Me.txtU.Text) < -128 Then Me.txtU.Text = "-128"
        'If CInt(Me.txtV.Text) < -128 Then Me.txtV.Text = "-128"

        YUV2RGB(CInt(Me.txtY.Text), CInt(Me.txtU.Text), CInt(Me.txtV.Text), R, G, B)
        Me.pnlYUV.BackColor = Color.FromArgb(255, R, G, B)
    End Sub

    Public Sub RGB2YUV(ByRef Y As Integer, ByRef U As Integer, ByRef V As Integer, ByRef R As Integer, ByRef G As Integer, ByRef B As Integer)
        Try
            Y = (0.299 * R) + (0.587 * G) + (0.114 * B)
            U = (0.713 * (R - Y)) = 0.5R - (0.419 * G) - (0.081 * B)
            V = (0.564 * (B - R)) = (-0.169 * R) - (0.331 * G) + (0.5 * B)
            'If R < 0 Then R = 0
            'If R > 255 Then R = 255
            'If B < 0 Then B = 0
            'If B > 255 Then B = 255
            'If G < 0 Then G = 0
            'If G > 255 Then G = 255
        Catch ex As Exception
            MsgBox("Problem with YUV2RGB. Error: " & ex.Message)
        End Try
    End Sub

#End Region

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Me.pnlRGB.BackColor = Color.FromArgb(255, 0, 0, 0)
        Me.pnlYUV.BackColor = Color.FromArgb(255, 0, 0, 0)
        Me.txtR.Text = 0
        Me.txtG.Text = 0
        Me.txtB.Text = 0
        Me.txtY.Text = 0
        Me.txtU.Text = 0
        Me.txtV.Text = 0
    End Sub
End Class
