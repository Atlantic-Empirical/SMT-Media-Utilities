Imports SMT.Common.Media.DirectShow.Microsoft_DShow
Imports SMT.Common.Media.DirectShow.MainConcept
Imports System.Runtime.InteropServices
Imports SMT.Common.Media.DirectShow.nVidia.DecoderControl
Imports SMT.Common.Media.DirectShow.SMT_DShow.Filters.Keystone
Imports SMT.Common.Media.DVD.Globalization
Imports SMT.Common.Media.Players
Imports SMT.Common.Media.Players.DTSAC3Player
Imports System.IO
Imports SMT.Common.Media.DVD.Line21
Imports SMT.Common.Media.DirectShow.SMT_DShow.Filters.L21G
Imports System.Text
Imports SMT.Common.Utilities.ConversionsAndSuch
Imports SMT.Common.Media.DirectShow.SMT_DShow.GraphBuilding
Imports SMT.Common.Media.Players.DVD
Imports SMT.Common.Media.Players.DVD.Structures
Imports SMT.Common.Media.DirectShow.SMT_DShow.Filters.AMTC
Imports Elecard.ModuleConfigInterface

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
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbUYVYAP As System.Windows.Forms.RadioButton
    Friend WithEvents btnScrap As System.Windows.Forms.Button
    Friend WithEvents txtMain As System.Windows.Forms.TextBox
    Friend WithEvents txtFilterName As System.Windows.Forms.TextBox
    Friend WithEvents btnEnumPins As System.Windows.Forms.Button
    Friend WithEvents txtConsole As System.Windows.Forms.TextBox
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnTitleMenu_main As System.Windows.Forms.Button
    Friend WithEvents btnRootMenu_main As System.Windows.Forms.Button
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents btnRight As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnLeft As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPP_VMR9 As System.Windows.Forms.Button
    Friend WithEvents btnPP_DVDNav As System.Windows.Forms.Button
    Friend WithEvents btnPP_AudDec As System.Windows.Forms.Button
    Friend WithEvents btnPP_VidDec As System.Windows.Forms.Button
    Friend WithEvents btnPP_CSF As System.Windows.Forms.Button
    Friend WithEvents btnPP_CSFVMR As System.Windows.Forms.Button
    Friend WithEvents btnPP_AudRen As System.Windows.Forms.Button
    Friend WithEvents btnPP_VidRen As System.Windows.Forms.Button
    Friend WithEvents btnGraphEdit As System.Windows.Forms.Button
    Friend WithEvents btnGrabSamp As System.Windows.Forms.Button
    Friend WithEvents btnSelectDir As System.Windows.Forms.Button
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents txtFR As System.Windows.Forms.TextBox
    Friend WithEvents txtJitter As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents btnStartTimer As System.Windows.Forms.Button
    Friend WithEvents btnScrap2 As System.Windows.Forms.Button
    Friend WithEvents btnFF As System.Windows.Forms.Button
    Friend WithEvents btnRW As System.Windows.Forms.Button
    Friend WithEvents btnMC_ImgScl_PP As System.Windows.Forms.Button
    Friend WithEvents btnPP_MCMpgDmx As System.Windows.Forms.Button
    Friend WithEvents btnKeystonePP As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.btnRun = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.rbUYVYAP = New System.Windows.Forms.RadioButton
        Me.btnScrap = New System.Windows.Forms.Button
        Me.btnGrabSamp = New System.Windows.Forms.Button
        Me.txtMain = New System.Windows.Forms.TextBox
        Me.txtFilterName = New System.Windows.Forms.TextBox
        Me.btnEnumPins = New System.Windows.Forms.Button
        Me.txtConsole = New System.Windows.Forms.TextBox
        Me.btnPlay = New System.Windows.Forms.Button
        Me.btnTitleMenu_main = New System.Windows.Forms.Button
        Me.btnRootMenu_main = New System.Windows.Forms.Button
        Me.btnEnter = New System.Windows.Forms.Button
        Me.btnRight = New System.Windows.Forms.Button
        Me.btnDown = New System.Windows.Forms.Button
        Me.btnLeft = New System.Windows.Forms.Button
        Me.btnUp = New System.Windows.Forms.Button
        Me.btnStop = New System.Windows.Forms.Button
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.btnPP_VMR9 = New System.Windows.Forms.Button
        Me.btnPP_DVDNav = New System.Windows.Forms.Button
        Me.btnPP_AudDec = New System.Windows.Forms.Button
        Me.btnPP_VidDec = New System.Windows.Forms.Button
        Me.btnPP_CSF = New System.Windows.Forms.Button
        Me.btnPP_CSFVMR = New System.Windows.Forms.Button
        Me.btnPP_AudRen = New System.Windows.Forms.Button
        Me.btnPP_VidRen = New System.Windows.Forms.Button
        Me.btnGraphEdit = New System.Windows.Forms.Button
        Me.btnSelectDir = New System.Windows.Forms.Button
        Me.btnStartTimer = New System.Windows.Forms.Button
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.txtFR = New System.Windows.Forms.TextBox
        Me.txtJitter = New System.Windows.Forms.TextBox
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnScrap2 = New System.Windows.Forms.Button
        Me.btnKeystonePP = New System.Windows.Forms.Button
        Me.btnFF = New System.Windows.Forms.Button
        Me.btnRW = New System.Windows.Forms.Button
        Me.btnMC_ImgScl_PP = New System.Windows.Forms.Button
        Me.btnPP_MCMpgDmx = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(8, 8)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(75, 23)
        Me.btnRun.TabIndex = 0
        Me.btnRun.Text = "Make Graph"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.rbUYVYAP)
        Me.GroupBox1.Location = New System.Drawing.Point(448, 328)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(104, 48)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Profiles"
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(8, 32)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(104, 16)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "RadioButton2"
        '
        'rbUYVYAP
        '
        Me.rbUYVYAP.Checked = True
        Me.rbUYVYAP.Location = New System.Drawing.Point(8, 16)
        Me.rbUYVYAP.Name = "rbUYVYAP"
        Me.rbUYVYAP.Size = New System.Drawing.Size(136, 16)
        Me.rbUYVYAP.TabIndex = 0
        Me.rbUYVYAP.TabStop = True
        Me.rbUYVYAP.Text = "UYVY AP"
        '
        'btnScrap
        '
        Me.btnScrap.Location = New System.Drawing.Point(8, 40)
        Me.btnScrap.Name = "btnScrap"
        Me.btnScrap.Size = New System.Drawing.Size(75, 23)
        Me.btnScrap.TabIndex = 2
        Me.btnScrap.Text = "Scrap"
        '
        'btnGrabSamp
        '
        Me.btnGrabSamp.Location = New System.Drawing.Point(88, 8)
        Me.btnGrabSamp.Name = "btnGrabSamp"
        Me.btnGrabSamp.Size = New System.Drawing.Size(75, 23)
        Me.btnGrabSamp.TabIndex = 3
        Me.btnGrabSamp.Text = "Grab Samp"
        '
        'txtMain
        '
        Me.txtMain.Location = New System.Drawing.Point(88, 40)
        Me.txtMain.Name = "txtMain"
        Me.txtMain.Size = New System.Drawing.Size(98, 20)
        Me.txtMain.TabIndex = 4
        '
        'txtFilterName
        '
        Me.txtFilterName.Location = New System.Drawing.Point(88, 64)
        Me.txtFilterName.Name = "txtFilterName"
        Me.txtFilterName.Size = New System.Drawing.Size(72, 20)
        Me.txtFilterName.TabIndex = 5
        '
        'btnEnumPins
        '
        Me.btnEnumPins.Location = New System.Drawing.Point(8, 64)
        Me.btnEnumPins.Name = "btnEnumPins"
        Me.btnEnumPins.Size = New System.Drawing.Size(75, 23)
        Me.btnEnumPins.TabIndex = 6
        Me.btnEnumPins.Text = "Enum Pins"
        '
        'txtConsole
        '
        Me.txtConsole.Location = New System.Drawing.Point(16, 320)
        Me.txtConsole.Multiline = True
        Me.txtConsole.Name = "txtConsole"
        Me.txtConsole.Size = New System.Drawing.Size(424, 168)
        Me.txtConsole.TabIndex = 7
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(336, 8)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(96, 23)
        Me.btnPlay.TabIndex = 8
        Me.btnPlay.Text = "Play"
        '
        'btnTitleMenu_main
        '
        Me.btnTitleMenu_main.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnTitleMenu_main.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTitleMenu_main.ForeColor = System.Drawing.Color.Black
        Me.btnTitleMenu_main.Location = New System.Drawing.Point(288, 72)
        Me.btnTitleMenu_main.Name = "btnTitleMenu_main"
        Me.btnTitleMenu_main.Size = New System.Drawing.Size(40, 24)
        Me.btnTitleMenu_main.TabIndex = 83
        Me.btnTitleMenu_main.TabStop = False
        Me.btnTitleMenu_main.Text = "TITLE"
        Me.btnTitleMenu_main.UseVisualStyleBackColor = False
        '
        'btnRootMenu_main
        '
        Me.btnRootMenu_main.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnRootMenu_main.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRootMenu_main.ForeColor = System.Drawing.Color.Black
        Me.btnRootMenu_main.Location = New System.Drawing.Point(192, 72)
        Me.btnRootMenu_main.Name = "btnRootMenu_main"
        Me.btnRootMenu_main.Size = New System.Drawing.Size(40, 24)
        Me.btnRootMenu_main.TabIndex = 82
        Me.btnRootMenu_main.TabStop = False
        Me.btnRootMenu_main.Text = "ROOT"
        Me.btnRootMenu_main.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRootMenu_main.UseVisualStyleBackColor = False
        '
        'btnEnter
        '
        Me.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(232, 32)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(56, 40)
        Me.btnEnter.TabIndex = 77
        Me.btnEnter.Text = "Enter"
        '
        'btnRight
        '
        Me.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRight.Location = New System.Drawing.Point(288, 40)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(40, 24)
        Me.btnRight.TabIndex = 81
        Me.btnRight.TabStop = False
        Me.btnRight.Text = "Right"
        '
        'btnDown
        '
        Me.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDown.Location = New System.Drawing.Point(240, 72)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(40, 24)
        Me.btnDown.TabIndex = 80
        Me.btnDown.TabStop = False
        Me.btnDown.Text = "Down"
        '
        'btnLeft
        '
        Me.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeft.Location = New System.Drawing.Point(192, 40)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(40, 24)
        Me.btnLeft.TabIndex = 79
        Me.btnLeft.TabStop = False
        Me.btnLeft.Text = "Left"
        '
        'btnUp
        '
        Me.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUp.Location = New System.Drawing.Point(240, 8)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(40, 24)
        Me.btnUp.TabIndex = 78
        Me.btnUp.TabStop = False
        Me.btnUp.Text = "Up"
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(336, 40)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(96, 23)
        Me.btnStop.TabIndex = 84
        Me.btnStop.Text = "Stop"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(336, 72)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(48, 23)
        Me.btnBack.TabIndex = 85
        Me.btnBack.Text = "|<"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(384, 72)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(48, 23)
        Me.btnNext.TabIndex = 86
        Me.btnNext.Text = ">|"
        '
        'btnPP_VMR9
        '
        Me.btnPP_VMR9.Location = New System.Drawing.Point(448, 8)
        Me.btnPP_VMR9.Name = "btnPP_VMR9"
        Me.btnPP_VMR9.Size = New System.Drawing.Size(72, 23)
        Me.btnPP_VMR9.TabIndex = 87
        Me.btnPP_VMR9.Text = "VMR9"
        '
        'btnPP_DVDNav
        '
        Me.btnPP_DVDNav.Location = New System.Drawing.Point(448, 32)
        Me.btnPP_DVDNav.Name = "btnPP_DVDNav"
        Me.btnPP_DVDNav.Size = New System.Drawing.Size(72, 23)
        Me.btnPP_DVDNav.TabIndex = 88
        Me.btnPP_DVDNav.Text = "DVD Nav"
        '
        'btnPP_AudDec
        '
        Me.btnPP_AudDec.Location = New System.Drawing.Point(520, 8)
        Me.btnPP_AudDec.Name = "btnPP_AudDec"
        Me.btnPP_AudDec.Size = New System.Drawing.Size(72, 23)
        Me.btnPP_AudDec.TabIndex = 89
        Me.btnPP_AudDec.Text = "Aud Dec"
        '
        'btnPP_VidDec
        '
        Me.btnPP_VidDec.Location = New System.Drawing.Point(520, 32)
        Me.btnPP_VidDec.Name = "btnPP_VidDec"
        Me.btnPP_VidDec.Size = New System.Drawing.Size(72, 23)
        Me.btnPP_VidDec.TabIndex = 90
        Me.btnPP_VidDec.Text = "Vid Dec"
        '
        'btnPP_CSF
        '
        Me.btnPP_CSF.Location = New System.Drawing.Point(448, 56)
        Me.btnPP_CSF.Name = "btnPP_CSF"
        Me.btnPP_CSF.Size = New System.Drawing.Size(72, 23)
        Me.btnPP_CSF.TabIndex = 91
        Me.btnPP_CSF.Text = "CSF"
        '
        'btnPP_CSFVMR
        '
        Me.btnPP_CSFVMR.Location = New System.Drawing.Point(520, 56)
        Me.btnPP_CSFVMR.Name = "btnPP_CSFVMR"
        Me.btnPP_CSFVMR.Size = New System.Drawing.Size(72, 23)
        Me.btnPP_CSFVMR.TabIndex = 92
        Me.btnPP_CSFVMR.Text = "Sink VMR"
        '
        'btnPP_AudRen
        '
        Me.btnPP_AudRen.Location = New System.Drawing.Point(592, 8)
        Me.btnPP_AudRen.Name = "btnPP_AudRen"
        Me.btnPP_AudRen.Size = New System.Drawing.Size(72, 23)
        Me.btnPP_AudRen.TabIndex = 93
        Me.btnPP_AudRen.Text = "Aud Ren"
        '
        'btnPP_VidRen
        '
        Me.btnPP_VidRen.Location = New System.Drawing.Point(592, 32)
        Me.btnPP_VidRen.Name = "btnPP_VidRen"
        Me.btnPP_VidRen.Size = New System.Drawing.Size(72, 23)
        Me.btnPP_VidRen.TabIndex = 94
        Me.btnPP_VidRen.Text = "Vid Ren"
        '
        'btnGraphEdit
        '
        Me.btnGraphEdit.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnGraphEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGraphEdit.ForeColor = System.Drawing.Color.Black
        Me.btnGraphEdit.Location = New System.Drawing.Point(192, 8)
        Me.btnGraphEdit.Name = "btnGraphEdit"
        Me.btnGraphEdit.Size = New System.Drawing.Size(40, 24)
        Me.btnGraphEdit.TabIndex = 95
        Me.btnGraphEdit.TabStop = False
        Me.btnGraphEdit.Text = "GE"
        Me.btnGraphEdit.UseVisualStyleBackColor = False
        '
        'btnSelectDir
        '
        Me.btnSelectDir.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnSelectDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectDir.ForeColor = System.Drawing.Color.Black
        Me.btnSelectDir.Location = New System.Drawing.Point(288, 8)
        Me.btnSelectDir.Name = "btnSelectDir"
        Me.btnSelectDir.Size = New System.Drawing.Size(40, 24)
        Me.btnSelectDir.TabIndex = 96
        Me.btnSelectDir.TabStop = False
        Me.btnSelectDir.Text = "Dir"
        Me.btnSelectDir.UseVisualStyleBackColor = False
        '
        'btnStartTimer
        '
        Me.btnStartTimer.Location = New System.Drawing.Point(8, 88)
        Me.btnStartTimer.Name = "btnStartTimer"
        Me.btnStartTimer.Size = New System.Drawing.Size(75, 23)
        Me.btnStartTimer.TabIndex = 97
        Me.btnStartTimer.Text = "Start Timer"
        '
        'Timer
        '
        Me.Timer.Enabled = True
        '
        'txtFR
        '
        Me.txtFR.Location = New System.Drawing.Point(88, 88)
        Me.txtFR.Name = "txtFR"
        Me.txtFR.Size = New System.Drawing.Size(72, 20)
        Me.txtFR.TabIndex = 98
        Me.ToolTip.SetToolTip(Me.txtFR, "Frame rate achieved")
        '
        'txtJitter
        '
        Me.txtJitter.Location = New System.Drawing.Point(88, 112)
        Me.txtJitter.Name = "txtJitter"
        Me.txtJitter.Size = New System.Drawing.Size(72, 20)
        Me.txtJitter.TabIndex = 99
        Me.ToolTip.SetToolTip(Me.txtJitter, "Jitter")
        '
        'btnScrap2
        '
        Me.btnScrap2.Location = New System.Drawing.Point(8, 112)
        Me.btnScrap2.Name = "btnScrap2"
        Me.btnScrap2.Size = New System.Drawing.Size(75, 23)
        Me.btnScrap2.TabIndex = 100
        Me.btnScrap2.Text = "Scrap 2"
        '
        'btnKeystonePP
        '
        Me.btnKeystonePP.Location = New System.Drawing.Point(592, 56)
        Me.btnKeystonePP.Name = "btnKeystonePP"
        Me.btnKeystonePP.Size = New System.Drawing.Size(72, 23)
        Me.btnKeystonePP.TabIndex = 101
        Me.btnKeystonePP.Text = "Keystone"
        '
        'btnFF
        '
        Me.btnFF.Location = New System.Drawing.Point(384, 101)
        Me.btnFF.Name = "btnFF"
        Me.btnFF.Size = New System.Drawing.Size(48, 23)
        Me.btnFF.TabIndex = 103
        Me.btnFF.Text = ">>"
        '
        'btnRW
        '
        Me.btnRW.Location = New System.Drawing.Point(336, 101)
        Me.btnRW.Name = "btnRW"
        Me.btnRW.Size = New System.Drawing.Size(48, 23)
        Me.btnRW.TabIndex = 102
        Me.btnRW.Text = "<<"
        '
        'btnMC_ImgScl_PP
        '
        Me.btnMC_ImgScl_PP.Location = New System.Drawing.Point(448, 80)
        Me.btnMC_ImgScl_PP.Name = "btnMC_ImgScl_PP"
        Me.btnMC_ImgScl_PP.Size = New System.Drawing.Size(72, 23)
        Me.btnMC_ImgScl_PP.TabIndex = 104
        Me.btnMC_ImgScl_PP.Text = "MC Img Scl"
        '
        'btnPP_MCMpgDmx
        '
        Me.btnPP_MCMpgDmx.Location = New System.Drawing.Point(520, 80)
        Me.btnPP_MCMpgDmx.Name = "btnPP_MCMpgDmx"
        Me.btnPP_MCMpgDmx.Size = New System.Drawing.Size(72, 23)
        Me.btnPP_MCMpgDmx.TabIndex = 105
        Me.btnPP_MCMpgDmx.Text = "MC Mp Dx"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(672, 150)
        Me.Controls.Add(Me.btnPP_MCMpgDmx)
        Me.Controls.Add(Me.btnMC_ImgScl_PP)
        Me.Controls.Add(Me.btnFF)
        Me.Controls.Add(Me.btnRW)
        Me.Controls.Add(Me.btnKeystonePP)
        Me.Controls.Add(Me.btnScrap2)
        Me.Controls.Add(Me.txtJitter)
        Me.Controls.Add(Me.txtFR)
        Me.Controls.Add(Me.btnStartTimer)
        Me.Controls.Add(Me.btnSelectDir)
        Me.Controls.Add(Me.btnGraphEdit)
        Me.Controls.Add(Me.btnPP_VidRen)
        Me.Controls.Add(Me.btnPP_AudRen)
        Me.Controls.Add(Me.btnPP_CSFVMR)
        Me.Controls.Add(Me.btnPP_CSF)
        Me.Controls.Add(Me.btnPP_VidDec)
        Me.Controls.Add(Me.btnPP_AudDec)
        Me.Controls.Add(Me.btnPP_DVDNav)
        Me.Controls.Add(Me.btnPP_VMR9)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnTitleMenu_main)
        Me.Controls.Add(Me.btnRootMenu_main)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.txtConsole)
        Me.Controls.Add(Me.btnEnumPins)
        Me.Controls.Add(Me.txtFilterName)
        Me.Controls.Add(Me.txtMain)
        Me.Controls.Add(Me.btnGrabSamp)
        Me.Controls.Add(Me.btnScrap)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRun)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Form1"
        Me.Text = " Grapher"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public HR As Integer

    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click
        'BuildGraph_VMR_STD()
        'BuildGraph_AVC_KEY_VMR()
        'BuildGraph_AVC_DLV()
        'BuildGraph_KEY_CPG()
        'BuildCSFGraph()
        'BuildGraph()
        'BuildGraph_Simple()
        'BuildGraph_Key_VMR()
        'BuildGraph_m2v_dl()
        'BuildL21Graph()
        'BuildGraph_m2v()
        'BuildMeADVDPlayer()
        'BuildGraph_DVD_bm()
        'BuildGraph_DVD_AJA()
        'BuildGraph_DVD_KEY_AJA()
        'BuildGraph_DVD_AJA_Simple()
        'BuildGraph_M2V_AJA()
        'BuildGraph_AVC_AJA()
        'BuildGraph_DVD_bm_AMTC()
        'BuildGraph_DVD_bm_AMTC2()
        'BuildGraph_DVD_bm_AMTC2_DSound()
        'BuildGraph_BMD_NullAudioRen()
        'BuildGraph_AMTC_DSound_VMR9()
        'BuildGraph_DVD_bm_IanierAdapter()
        'BuildGraph_DVD_L21G()
        'BuildGraph_QuickTime()
        'BuildGraph_M2V_MCDEC_KEYOMNI_VMR()
        'BuildGraph_M2V_NVDEC_KEYOMNI_VMR()
        'PhoenixGraph_Intensity()
        ScalingTester_Intensity()
    End Sub

    Private Sub btnGrabSamp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabSamp.Click
        Try
            Dim bs As Integer
            Dim ptr As IntPtr
            Dim HR As Integer = Me.ISampGrab.GetCurrentBuffer(bs, Nothing)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            Dim b(bs - 1) As Byte
            Dim h As GCHandle = GCHandle.Alloc(b, GCHandleType.Pinned)
            ptr = h.AddrOfPinnedObject
            HR = Me.ISampGrab.GetCurrentBuffer(bs, ptr)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            GetL21BMP(b)
            'GetBitmap(b)

            'Dim D2I As Sequoyan.ImageHandling.DibToImage
            'Dim I As Image = D2I.WithHBitmap(ptr)
            'I.Save("C:\Temp\" & DateTime.Now.Ticks & ".bmp", System.Drawing.Imaging.ImageFormat.Bmp)
        Catch ex As Exception
            MsgBox("Problem grabbing sample. Error: " & ex.Message)
        End Try
    End Sub

    Public Function GetL21BMP(ByVal b() As Byte) As Bitmap
        Try
            Dim bm As New Bitmap(640, 480, Imaging.PixelFormat.Format24bppRgb)
            Dim PixIncre As Integer = 0
            For X As Short = 479 To 0 Step -1
                For Y As Short = 0 To 639
                    bm.SetPixel(Y, X, Me.L218bitCT(CInt("&h" & GetByte(b(PixIncre)))))
                    PixIncre += 1
                Next
            Next
            bm.Save("C:\Temp\" & "L21_" & DateTime.Now.Ticks & ".bmp", System.Drawing.Imaging.ImageFormat.Bmp)
        Catch ex As Exception
            MsgBox("Problem with GetL21BMP. Error: " & ex.Message)
        End Try
    End Function

    Public Function GetBitmap(ByVal BY() As Byte) As Bitmap
        Try
            Dim BM_Wid As Short = 720
            Dim BM_Hei As Short = 486
            Dim b As New Bitmap(BM_Wid, BM_Hei, Imaging.PixelFormat.Format24bppRgb)

            Dim PxOffset As Integer = 0
            Dim C As Color
            Dim NumPixelsSet As Integer = 0 'should equal 349920
            For Y As Short = BM_Hei - 1 To 0 Step -1
                For X As Short = 0 To BM_Wid - 1
                    C = Color.FromArgb(0, CInt(BY(PxOffset + 2)), CInt(BY(PxOffset + 1)), CInt(BY(PxOffset)))
                    b.SetPixel(X, Y, C)
                    PxOffset += 4
                    NumPixelsSet += 1
                Next
            Next
            b.Save("C:\Temp\" & DateTime.Now.Ticks & ".bmp", System.Drawing.Imaging.ImageFormat.Bmp)
        Catch ex As Exception
            MsgBox("Problem with display bitmap. Error: " & ex.Message)
        End Try
    End Function

    'Public Function ScaleImage(ByVal InBM As Bitmap, ByVal NewHeight As Short, ByVal NewWidth As Short) As Bitmap
    '    Try
    '        Dim bm_dest As New Bitmap(NewWidth, NewHeight)
    '        Dim gr_dest As Graphics = Graphics.FromImage(bm_dest)
    '        gr_dest.DrawImage(InBM, 0, 0, bm_dest.Width + 1, bm_dest.Height + 1)
    '        Return bm_dest
    '    Catch ex As Exception
    '        MsgBox("Problem scaling image. Error: " & ex.Message)
    '    End Try
    'End Function

    Public ElecardOutPin As IPin

    Public MTs() As AM_MEDIA_TYPE
    Private Sub btnScrap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScrap.Click
        Try
            'nvAudioAtts.SetLong(nvcommon.EINvidiaAudioDecoderProps.NVAUDDEC_CONFIG, nvcommon.ENvidiaAudioDecoderProps_Config.NVAUDDEC_CONFIG_MUTE, 1)

            'ifAMTC.SendInititalizationSample()
            'Exit Sub

            'Me.BuildGraph_DVD_bm_AMTC2()
            'Exit Sub

            'Debug.WriteLine(Me.ClosedCaptionProcessing.GetAllL21Lines())

            'Dim DM As DvdDomain
            'HR = DVDInfo.GetCurrentDomain(DM)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)


            'Me.EnumerateFilters(GraphBuilder)
            'Exit Sub

            'MediaCtrl.Stop()
            'HR = GraphBuilder.RemoveFilter(VSDecoder)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            'Exit Sub

            'Dim F As IBaseFilter
            'GraphBuilder.FindFilterByName("Line 21 Decoder 2", F)
            'Me.EnumeratePinNames(F)
            'Dim P As IPin
            'F.FindPin("Out", P)

            'Dim p As IPin
            'HR = AudioDecoder.FindPin("Audio Output", p)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            Dim SMT As FullMediaType = GetPinMediaType(Key_Out)
            Exit Sub
            'SMT = Me.GetPinMediaType(AMTC_In)
            'SMT = Me.GetPinMediaType(AMTC_Out)
            ''SMT = Me.GetPinMediaType(P)
            ''SMT = Me.GetPinMediaType(Me.AudDec_OutPin)
            ''SMT = Me.GetPinMediaType(Me.AMTC_In)
            ''SMT = Me.GetPinMediaType(Me.AMTC_Out)
            ''SMT = Me.GetPinMediaType(Me.DLAIn)
            ''SMT = Me.GetPinMediaType(Me.BMA_Out)
            ''SMT = Me.GetPinMediaType(Me.CSFOut2)
            ''SMT = Me.GetPinMediaType(Me.VidDec_Vid_Out)
            ''SMT = Me.GetPinMediaType(Me.SG_Out)
            ''SMT = Me.GetPinMediaType(Me.AudDec_OutPin)
            ''SMT = Me.GetPinMediaType(Me.NNIn)
            ''SMT = Me.GetPinMediaType(Me.NNOut)
            ''SMT = Me.GetPinMediaType(AudMTConf_InPin)
            ''SMT = Me.GetPinMediaType(AudMTConf_OutPin)
            'SMT = Me.GetPinMediaType(Me.VidDec_SP_Out)
            'SMT = Me.GetPinMediaType(Me.L21_In)
            'Exit Sub

            'Dim CSC As IBaseFilter = Me.FindFilterByName("Color Space Converter")
            'Dim CSC_In, CSC_Out As IPin
            'Me.EnumeratePinNames(CSC)
            'HR = CSC.FindPin("In", CSC_In)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            'HR = CSC.FindPin("Out", CSC_Out)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            'Dim SMT As FullMediaType
            'SMT = Me.GetPinMediaType(CSC_In)
            'SMT = Me.GetPinMediaType(CSC_Out)
            'Exit Sub
        Catch ex As Exception
            MsgBox("Problem with scrap. error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnScrap2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScrap2.Click
        Try
            nvAudioAtts.SetLong(nvcommon.EINvidiaAudioDecoderProps.NVAUDDEC_CONFIG, nvcommon.ENvidiaAudioDecoderProps_Config.NVAUDDEC_CONFIG_MUTE, 0)

            'Dim SMT As FullMediaType
            ''SMT = Me.GetPinMediaType(Me.VidDec_Vid_Out)
            ''SMT = Me.GetPinMediaType(Me.SG_Out)
            ''SMT = Me.GetPinMediaType(Me.AudDec_OutPin)
            ''SMT = Me.GetPinMediaType(Me.NNIn)
            ''SMT = Me.GetPinMediaType(Me.NNOut)
            ''SMT = Me.GetPinMediaType(AudMTConf_InPin)
            ''SMT = Me.GetPinMediaType(AudMTConf_OutPin)
            ''SMT = Me.GetPinMediaType(Me.VMTC_Out)
            'SMT = Me.GetPinMediaType(Me.VMTC_In)
            'Exit Sub
        Catch ex As Exception
        End Try
    End Sub

    Public Sub AddConsoleLine(ByVal S As String)
        MsgBox(S)
    End Sub

    Public VW As frmViewer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        VW = New frmViewer(Me)
    End Sub

    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        DestroyGraph("Closing")
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        'Debug.WriteLine("Message: " & m.Msg)
        Select Case m.Msg
            Case WM_USER
                Debug.WriteLine("WM_USER: " & m.Msg)

            Case WM_GRAPHNOTIFY
                Debug.WriteLine("WM_GRAPHNOTIFY: " & m.Msg)

            Case WM_DVD_EVENT
                'Debug.WriteLine("WM_DVD_EVENT: " & m.Msg)
                If Not MediaEvt Is Nothing Then
                    HandleEvent()
                End If
                Exit Sub
        End Select
        MyBase.WndProc(m)
    End Sub

#Region "Filter Graph"

    Private Player As cDTSAC3Player
    Public Graph As cSMTGraph

    Private Function PhoenixGraph_Intensity() As Boolean
        Try
            If Graph Is Nothing Then Graph = New cSMTGraph(Handle)

            Graph.AddGraphToROT()

            If Not Graph.AddNVidiaVideoDecoder(False, False) Then Return False
            If Not Graph.AddKeystoneOmni() Then Return False
            If Not Graph.AddMCE_ImgSiz() Then Return False
            If Not Graph.AddDVDNav() Then Return False
            If Not Graph.AddDeckLinkVideo() Then Return False

            HR = Graph.GraphBuilder.Connect(Graph.DVDNav_VidPin, Graph.VidDec_Vid_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = Graph.GraphBuilder.Connect(Graph.VidDec_Vid_Out, Graph.KeystoneOMNI_IN)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = Graph.GraphBuilder.Connect(Graph.KeystoneOMNI_OUT, Graph.MCE_ImgSiz_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            Dim b As Boolean
            b = Graph.MCE_ImgSiz_IMC.SetParamValue(mMainConcept_Scaler.MC_SCALER_AppendixMode, 1)
            b = Graph.MCE_ImgSiz_IMC.SetParamValue(mMainConcept_Scaler.MC_SCALER_AppendixStripesType, 2)

            'b = Graph.MCE_ImgSiz_IMC.SetParamValue(mMainConcept_Scaler.MC_SCALER_ResizeImage, 1)
            'b = Graph.MCE_ImgSiz_IMC.SetParamValue(mMainConcept_Scaler.MC_SCALER_ResizeType, 2)

            'Dim source_width As Integer = Graph.MCE_ImgSiz_IMC.GetParamValue(mMainConcept_Scaler.MC_SCALER_SourceWidth)
            'Dim source_height As Integer = Graph.MCE_ImgSiz_IMC.GetParamValue(mMainConcept_Scaler.MC_SCALER_SourceHeight)

            b = Graph.MCE_ImgSiz_IMC.SetParamValue(mMainConcept_Scaler.MC_SCALER_StripesSizeValue2, 280)
            b = Graph.MCE_ImgSiz_IMC.SetParamValue(mMainConcept_Scaler.MC_SCALER_StripesSizeValue, 117)

            ' ''Dim dest_width As Object = Graph.MCE_ImgSiz_IMC.GetParamValue(mMainConcept_Scaler.MC_SCALER_DestWidth)
            ' ''Dim dest_height As Object = Graph.MCE_ImgSiz_IMC.GetParamValue(mMainConcept_Scaler.MC_SCALER_DestHeight)
            ''Dim b As Boolean
            ' ''b = Graph.MCE_ImgSiz_IMC.SetParamValue(mMainConcept_Scaler.MC_SCALER_AppendixMode, 1)
            ' ''b = Graph.MCE_ImgSiz_IMC.SetParamValue(mMainConcept_Scaler.MC_SCALER_AppendixStripesType, 2)

            ''b = Graph.MCE_ImgSiz_IMC.SetParamValue(mMainConcept_Scaler.MC_SCALER_ResizeImage, 1)
            ' ''b = Graph.MCE_ImgSiz_IMC.SetParamValue(mMainConcept_Scaler.MC_SCALER_ResizeType, 2)
            ''b = Graph.MCE_ImgSiz_IMC.SetParamValue(mMainConcept_Scaler.MC_SCALER_DestWidth, 853)
            ''b = Graph.MCE_ImgSiz_IMC.SetParamValue(mMainConcept_Scaler.MC_SCALER_DestHeight, source_height)
            ''b = Graph.MCE_ImgSiz_IMC.SetParamValue(mMainConcept_Scaler.MC_SCALER_MaxResizeWidth, 853)
            ''b = Graph.MCE_ImgSiz_IMC.SetParamValue(mMainConcept_Scaler.MC_SCALER_MinResizeWidth, 853)
            ''b = Graph.MCE_ImgSiz_IMC.SetParamValue(mMainConcept_Scaler.MC_SCALER_MaxResizeHeight, source_height)
            ''b = Graph.MCE_ImgSiz_IMC.SetParamValue(mMainConcept_Scaler.MC_SCALER_MinResizeHeight, source_height)
            ''source_width = 853

            ''b = Graph.MCE_ImgSiz_IMC.SetParamValue(mMainConcept_Scaler.MC_SCALER_StripesSizeValue, (720 - source_height) / 2)
            ''b = Graph.MCE_ImgSiz_IMC.SetParamValue(mMainConcept_Scaler.MC_SCALER_StripesSizeValue2, (1280 - source_width) / 2)

            Graph.MCE_ImgSiz_IMC.CommitChanges()

            ''dest_width = Graph.MCE_ImgSiz_IMC.GetParamValue(mMainConcept_Scaler.MC_SCALER_DestWidth)
            ''dest_height = Graph.MCE_ImgSiz_IMC.GetParamValue(mMainConcept_Scaler.MC_SCALER_DestHeight)

            'HR = Graph.GraphBuilder.Connect(Graph.MCE_ImgSiz_Out, Graph.DLV_In)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            Return True
        Catch ex As Exception
            MsgBox("Problem building full graph. Error: " & ex.Message)
        End Try
    End Function

    Private Function ScalingTester_Intensity() As Boolean
        Try
            If Graph Is Nothing Then Graph = New cSMTGraph(Handle)

            Graph.AddGraphToROT()

            If Not Graph.AddNVidiaVideoDecoder(False, False) Then Return False
            If Not Graph.AddKeystoneOmni() Then Return False
            If Not Graph.AddMCE_ImgSiz() Then Return False
            If Not Graph.AddDeckLinkVideo() Then Return False

            Graph.AddFilesourceA("E:\MEDIA\VIDEO\480\LOTR_TT.m2v")
            'Graph.AddFilesourceA("E:\MEDIA\VIDEO\576\PAL_TEST.m2v")

            HR = Graph.GraphBuilder.Connect(Graph.FSFA_Out, Graph.VidDec_Vid_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = Graph.GraphBuilder.Connect(Graph.VidDec_Vid_Out, Graph.KeystoneOMNI_IN)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = Graph.GraphBuilder.Connect(Graph.KeystoneOMNI_OUT, Graph.MCE_ImgSiz_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            Graph.MCE_SetScaling(cSMTGraph.eVideoResolution._1920x1080, cSMTGraph.eScalingMode.Maximize_ScaleToAR, 16, 9)

            HR = Graph.GraphBuilder.Connect(Graph.MCE_ImgSiz_Out, Graph.DLV_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            Return True
        Catch ex As Exception
            MsgBox("Problem building full graph. Error: " & ex.Message)
        End Try
    End Function

    Public Function BuildGraph_AC3() As Boolean
        Try
            Player = New cDTSAC3Player
            If Not Player.BuildGraph("C:\MEDIA\Test.ac3", Me.Handle, True, Me) Then
                Throw New Exception("Failed in BuildGraph().")
            End If
            'Player.Graph.ViewAudioDecoderPropertyPage()
            Return True
        Catch ex As Exception
            MsgBox("Problem with BuildGraph_AC3(). Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function BuildGraph_DVD_bm_IanierAdapter() As Boolean
        Try
            If Not Me.SetupGraphStub Then Return False
            If Not Me.AddDecklinkAudioRenderer Then Return False
            If Not Me.AddDecklinkVideoRenderer Then Return False
            If Not Me.AddNVidiaAudioDecoder Then Return False
            If Not Me.AddNVidiaVideoDecoder Then Return False
            If Not Me.AddDVDNav Then Return False
            'If Not AddVMTCPAL() Then Return False
            If Not Me.AddAdapter() Then Return False

            HR = GraphBuilder.Connect(Me.DVDNav_VidPin, Me.VidDec_VidInPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.VidDec_Vid_Out, Me.BMA_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.BMA_Out, Me.DLVIn)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Render(DVDNav_AudPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Render(Me.DVDNav_SubPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            'DVDDir = "C:\DVDImages\Unfaithful\"

            Return True
        Catch ex As Exception
            MsgBox("Problem with BuildGraph. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function BuildGraph_Key_VMR() As Boolean
        Try
            If Not Me.SetupGraphStub Then Return False
            If Not Me.AddDirectSoundRenderer Then Return False
            If Not Me.AddNVidiaAudioDecoder Then Return False
            If Not Me.AddNVidiaVideoDecoder Then Return False
            If Not Me.AddDVDNav Then Return False
            If Not Me.AddVMR9 Then Return False
            If Not Me.AddKeystone Then Return False

            HR = MediaCtrl.Stop()

            HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\TWO_TOWERS_NTSC_R1_D2\VIDEO_TS")
            'HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\POST_LOGIC\MUSIC_IN_EXILE")

            HR = GraphBuilder.Render(DVDNav_AudPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.DVDNav_VidPin, Me.VidDec_VidInPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.VidDec_Vid_Out, Me.Key_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Render(Me.Key_Out)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Render(Me.DVDNav_SubPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            'HR = GraphBuilder.Render(Me.VidDec_CC_Out)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            'HR = GraphBuilder.Render(Me.)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            Return True
        Catch ex As Exception
            MsgBox("Problem with BuildGraph. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function BuildGraph_M2V_MCDEC_KEYOMNI_VMR() As Boolean
        Try
            If Not Me.SetupGraphStub Then Return False
            If Not Me.AddVMR9 Then Return False
            If Not Me.AddKeystoneOmni Then Return False
            'If Not Me.AddKeyHD Then Return False
            If Not Me.AddMCE_DMXA() Then Return False
            If Not Me.AddMCE_MP2A Then Return False

            Me.AddFilesourceA("E:\MEDIA\THX\Blu-ray\080820 - THX\THX_Streams_Ivan\00000.m2ts")

            HR = GraphBuilder.Connect(FSFA_Out, MCE_MP2A_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            GraphBuilder.Connect(MCE_MP2A_Out, Key_In)

            HR = GraphBuilder.Render(Key_Out)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            'HR = GraphBuilder.Render(MCE_MP2A_Out)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            AddGraphToROT(GraphBuilder)

            Return True
        Catch ex As Exception
            MsgBox("Problem with BuildGraph_M2V_KEYOMNI_VMR. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function BuildGraph_M2V_NVDEC_KEYOMNI_VMR() As Boolean
        Try
            If Not Me.SetupGraphStub Then Return False
            If Not Me.AddVMR9 Then Return False
            If Not Me.AddNVidiaVideoDecoder Then Return False
            If Not Me.AddKeystoneOmni Then Return False
            If Not Me.AddMCE_DMXA() Then Return False

            'Me.AddFilesourceA("D:\MEDIA\VIDEO\480\lotr_tt.m2v")
            Me.AddFilesourceA("E:\MEDIA\THX\Blu-ray\080820 - THX\THX_Streams_Ivan\00000.m2ts")

            HR = GraphBuilder.Connect(FSFA_Out, VidDec_VidInPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            GraphBuilder.Connect(VidDec_Vid_Out, Key_In)

            HR = GraphBuilder.Render(Key_Out)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            AddGraphToROT(GraphBuilder)

            Return True
        Catch ex As Exception
            MsgBox("Problem with BuildGraph_M2V_KEYOMNI_VMR. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function BuildGraph_KEY_CPG() As Boolean
        Try
            If Not Me.SetupGraphStub Then Return False
            If Not Me.AddMCE_CHG Then Return False
            If Not Me.AddDirectSoundRenderer Then Return False
            If Not Me.AddNVidiaAudioDecoder Then Return False
            If Not Me.AddNVidiaVideoDecoder Then Return False
            If Not Me.AddDVDNav Then Return False
            If Not Me.AddKeystone Then Return False

            HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\POST_LOGIC\MUSIC_IN_EXILE")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = Me.DVDCtrl.SelectVideoModePreference(1)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Render(DVDNav_AudPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.DVDNav_VidPin, Me.VidDec_VidInPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.VidDec_Vid_Out, Me.Key_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Render(Me.Key_Out)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Render(Me.DVDNav_SubPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            Return True
        Catch ex As Exception
            MsgBox("Problem with BuildGraph. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function BuildGraph_DVD_bm_DirectSound() As Boolean
        Try
            If Not Me.SetupGraphStub Then Return False

            'If Not Me.AddDecklinkAudioRenderer Then Return False
            If Not Me.AddDirectSoundRenderer Then Return False
            If Not Me.AddDecklinkVideoRenderer Then Return False
            If Not Me.AddNVidiaAudioDecoder Then Return False
            If Not Me.AddNVidiaVideoDecoder Then Return False
            If Not Me.AddKeystone() Then Return False
            If Not Me.AddDVDNav Then Return False

            HR = GraphBuilder.Connect(Me.DVDNav_VidPin, Me.VidDec_VidInPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.DVDNav_SubPin, Me.VidDec_SubInPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.VidDec_Vid_Out, Me.Key_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.Key_Out, Me.DLVIn)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.DVDNav_AudPin, Me.AudDec_InPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Render(Me.AudDec_OutPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            'Dim MT As DirectShow.VMR9.AM_MEDIA_TYPE
            'Dim b() As Byte
            'Dim WFXTN As DVDMedia.WAVEFORMATEX
            'If EnumeratePreferedMediaTypes(Me.AudDec_OutPin) Then
            '    For ix As Short = 0 To UBound(MTs)
            '        ReDim b(Convert.ToInt32(MTs(ix).cbFormat) - 1)
            '        For i As Integer = 0 To UBound(b)
            '            b(i) = Marshal.ReadByte(MTs(ix).pbFormat, i)
            '        Next
            '        WFXTN = Me.GetWaveFormatEx(b)
            '        If WFXTN.wFormatTag = DVDMedia.WAVE_FORMAT.WAVE_FORMAT_DOLBY_AC3_SPDIF Then
            '            MT = MTs(ix)
            '            Exit For
            '        End If
            '    Next
            'End If

            'HR = Me.AudDec_OutPin.Connect(Me.DLAIn, MT)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            'SetAudDecOutPinMediaType()

            'HR = GraphBuilder.Connect(Me.AudDec_OutPin, Me.DLAIn)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            Return True
        Catch ex As Exception
            MsgBox("Problem with BuildGraph. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function BuildGraph_DVD_bm_AMTC2_DSound() As Boolean
        Try
            If Not Me.SetupGraphStub Then Return False
            If Not Me.AddDirectSoundRenderer Then Return False
            If Not Me.AddDecklinkVideoRenderer Then Return False
            If Not Me.AddNVidiaAudioDecoder Then Return False
            If Not Me.AddNVidiaVideoDecoder Then Return False
            If Not Me.AddKeystone() Then Return False
            If Not Me.AddDVDNav Then Return False
            If Not Me.AddAMTC2 Then Return False

            HR = MediaCtrl.Stop()

            HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\POST_LOGIC\SHADOW_PUPPETS\VIDEO_TS")
            'HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\TWO_TOWERS_NTSC_R1_D2\VIDEO_TS")
            'HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\POST_LOGIC\MUSIC_IN_EXILE")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.DVDNav_VidPin, Me.VidDec_VidInPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.DVDNav_SubPin, Me.VidDec_SubInPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.VidDec_Vid_Out, Me.Key_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.Key_Out, Me.DLVIn)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.DVDNav_AudPin, Me.AudDec_InPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.AudDec_OutPin, Me.AMTC_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.AMTC_Out, Me.DSR_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            Return True
        Catch ex As Exception
            MsgBox("Problem with BuildGraph. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function BuildGraph_DVD_bm_AMTC() As Boolean
        Try
            If Not Me.SetupGraphStub Then Return False
            If Not Me.AddDecklinkAudioRenderer Then Return False
            If Not Me.AddAMTC Then Return False
            If Not Me.AddDecklinkVideoRenderer Then Return False
            If Not Me.AddNVidiaAudioDecoder Then Return False
            If Not Me.AddNVidiaVideoDecoder Then Return False
            If Not Me.AddKeystone() Then Return False
            If Not Me.AddDVDNav Then Return False

            HR = MediaCtrl.Stop()

            'HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\TWO_TOWERS_NTSC_R1_D2\VIDEO_TS")
            HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\POST_LOGIC\MUSIC_IN_EXILE")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = Me.DVDCtrl.SelectVideoModePreference(1)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = Me.ikeymix.SetResizeMode(1)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.DVDNav_VidPin, Me.VidDec_VidInPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.DVDNav_SubPin, Me.VidDec_SubInPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.VidDec_Vid_Out, Me.Key_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.Key_Out, Me.DLVIn)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.DVDNav_AudPin, Me.AudDec_InPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.AudDec_OutPin, Me.AMTC_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.AMTC_Out, Me.DLAIn)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            Return True
        Catch ex As Exception
            MsgBox("Problem with BuildGraph. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function BuildGraph_DVD_bm_AMTC2() As Boolean
        Try
            If Not Me.SetupGraphStub Then Return False
            If Not Me.AddDecklinkAudioRenderer Then Return False
            If Not Me.AddAMTC2 Then Return False
            If Not Me.AddDecklinkVideoRenderer Then Return False
            If Not Me.AddNVidiaAudioDecoder Then Return False
            If Not Me.AddNVidiaVideoDecoder Then Return False
            If Not Me.AddKeystone() Then Return False
            If Not Me.AddDVDNav Then Return False

            HR = MediaCtrl.Stop()

            HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\POST_LOGIC\SHADOW_PUPPETS\VIDEO_TS")
            'HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\TWO_TOWERS_NTSC_R1_D2\VIDEO_TS")
            'HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\POST_LOGIC\MUSIC_IN_EXILE")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = Me.DVDCtrl.SelectVideoModePreference(1)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = Me.ikeymix.SetResizeMode(1)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.DVDNav_VidPin, Me.VidDec_VidInPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.DVDNav_SubPin, Me.VidDec_SubInPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.VidDec_Vid_Out, Me.Key_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.Key_Out, Me.DLVIn)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.DVDNav_AudPin, Me.AudDec_InPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.AudDec_OutPin, Me.AMTC_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.AMTC_Out, Me.DLAIn)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            Return True
        Catch ex As Exception
            MsgBox("Problem with BuildGraph. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function BuildGraph_BMD_NullAudioRen() As Boolean
        Try
            If Not Me.SetupGraphStub Then Return False
            If Not Me.AddDecklinkVideoRenderer Then Return False
            If Not Me.AddNVidiaAudioDecoder Then Return False
            If Not Me.AddNVidiaVideoDecoder Then Return False
            If Not Me.AddKeystone() Then Return False
            If Not Me.AddDVDNav Then Return False
            If Not Me.AddNullRenderer Then Return False
            If Not Me.AddAMTC2 Then Return False

            HR = MediaCtrl.Stop()

            HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\POST_LOGIC\SHADOW_PUPPETS\VIDEO_TS")
            'HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\TWO_TOWERS_NTSC_R1_D2\VIDEO_TS")
            'HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\POST_LOGIC\MUSIC_IN_EXILE")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = Me.DVDCtrl.SelectVideoModePreference(1)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = Me.ikeymix.SetResizeMode(1)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.DVDNav_VidPin, Me.VidDec_VidInPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.DVDNav_SubPin, Me.VidDec_SubInPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.VidDec_Vid_Out, Me.Key_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.Key_Out, Me.DLVIn)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.DVDNav_AudPin, Me.AudDec_InPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.AudDec_OutPin, Me.AMTC_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.AMTC_Out, Me.NR_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            Return True
        Catch ex As Exception
            MsgBox("Problem with BuildGraph. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function BuildGraph_DVD_bm() As Boolean
        Try
            If Not Me.SetupGraphStub Then Return False
            If Not Me.AddDecklinkAudioRenderer Then Return False
            If Not Me.AddDecklinkVideoRenderer Then Return False
            If Not Me.AddNVidiaAudioDecoder Then Return False
            If Not Me.AddNVidiaVideoDecoder Then Return False
            If Not Me.AddKeystone() Then Return False
            If Not Me.AddDVDNav Then Return False
            If Not Me.AddAMTC Then Return False

            HR = MediaCtrl.Stop()

            'HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\POETRY_BREAKS\VIDEO_TS")
            'HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\POST_LOGIC\MUSIC_IN_EXILE")
            'HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\TWO_TOWERS_NTSC_R1_D2\VIDEO_TS")
            HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\JAVELIN_TEST_DVDs\DEADWOOD_GAUNTLET\0\VIDEO_TS")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            'HR = Me.DVDCtrl.SelectVideoModePreference(1)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            'HR = Me.ikeymix.SetResizeMode(1)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.DVDNav_VidPin, Me.VidDec_VidInPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.DVDNav_SubPin, Me.VidDec_SubInPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.VidDec_Vid_Out, Me.Key_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.Key_Out, Me.DLVIn)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.DVDNav_AudPin, Me.AudDec_InPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.AudDec_OutPin, Me.AMTC_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.AMTC_Out, Me.DLAIn)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            Return True
        Catch ex As Exception
            MsgBox("Problem with BuildGraph. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function BuildGraph_DVD_AJA() As Boolean
        Try
            If Not Me.SetupGraphStub Then Return False
            If Not Me.AddAJARenderer Then Return False
            If Not Me.AddNVidiaAudioDecoder Then Return False
            If Not Me.AddNVidiaVideoDecoder Then Return False
            If Not Me.AddKeystone() Then Return False
            If Not Me.AddDVDNav Then Return False
            If Not Me.AddAMTC Then Return False

            HR = MediaCtrl.Stop()

            'HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\POETRY_BREAKS\VIDEO_TS")
            'HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\POST_LOGIC\MUSIC_IN_EXILE")
            'HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\TWO_TOWERS_NTSC_R1_D2\VIDEO_TS")
            HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\JAVELIN_TEST_DVDs\DEADWOOD_GAUNTLET\0\VIDEO_TS")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            'HR = Me.DVDCtrl.SelectVideoModePreference(1)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            'HR = Me.ikeymix.SetResizeMode(1)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.DVDNav_VidPin, Me.VidDec_VidInPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.DVDNav_SubPin, Me.VidDec_SubInPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.VidDec_Vid_Out, Me.Key_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.Key_Out, Me.AJA_Video)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.DVDNav_AudPin, Me.AudDec_InPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.AudDec_OutPin, Me.AMTC_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.AMTC_Out, Me.AJA_Audio)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            Return True
        Catch ex As Exception
            MsgBox("Problem with BuildGraph. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function BuildGraph_DVD_KEY_AJA() As Boolean
        Try
            If Not Me.SetupGraphStub Then Return False
            If Not Me.AddAJARenderer Then Return False
            If Not Me.AddNVidiaVideoDecoder Then Return False
            If Not Me.AddDVDNav Then Return False
            If Not Me.AddKeystone Then Return False

            HR = MediaCtrl.Stop()

            'HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\POETRY_BREAKS\VIDEO_TS")
            'HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\POST_LOGIC\MUSIC_IN_EXILE")
            HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\JAVELIN_TEST_DVDs\DEADWOOD_GAUNTLET\0\VIDEO_TS")
            'HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\TWO_TOWERS_NTSC_R1_D2\VIDEO_TS")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.DVDNav_VidPin, Me.VidDec_VidInPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.VidDec_Vid_Out, Me.Key_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.Key_Out, Me.AJA_Video)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = Graph_IMF.SetSyncSource(RefClock)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            Return True
        Catch ex As Exception
            MsgBox("Problem with BuildGraph_DVD_KEY_AJA. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function BuildGraph_DVD_AJA_Simple() As Boolean
        Try
            If Not Me.SetupGraphStub Then Return False
            If Not Me.AddAJARenderer Then Return False
            If Not Me.AddNVidiaVideoDecoder Then Return False
            If Not Me.AddDVDNav Then Return False

            HR = MediaCtrl.Stop()

            'HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\POETRY_BREAKS\VIDEO_TS")
            'HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\POST_LOGIC\MUSIC_IN_EXILE")
            HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\JAVELIN_TEST_DVDs\DEADWOOD_GAUNTLET\0\VIDEO_TS")
            'HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\TWO_TOWERS_NTSC_R1_D2\VIDEO_TS")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.DVDNav_VidPin, Me.VidDec_VidInPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.VidDec_Vid_Out, Me.AJA_Video)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            Return True
        Catch ex As Exception
            MsgBox("Problem with BuildGraph. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function BuildGraph_QuickTime() As Boolean
        Try
            Graph = New cSMTGraph(Handle)
            Graph.AddGraphToROT()
            Graph.AddVMR9(1)
            Graph.AddDefaultDirectSoundDevice()

            'If Not Graph.AddML_QT("C:\MEDIA\CMS\fastheader2.mov") Then Return False
            If Not Graph.AddML_QT("https://5d889c3e-ed42-40f9-a03f-c3f2b6601960.s3.amazonaws.com:443/0ee67946-58f2-4c91-84de-3da1d6e58463?AWSAccessKeyId=0MA68GR9NPHKN0GH5ER2&Expires=1199481216&Signature=wsJoI%2f8KJ5DMYjq9QpsBG7rZP24%3d") Then Return False

            HR = Graph.GraphBuilder.Render(Graph.ML_QT_Vid)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = Graph.GraphBuilder.Render(Graph.ML_QT_Aud)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            Debug.WriteLine("hi")


            'Graph.AddFilesourceA("E:\MEDIA\VIDEO\1080\Ascent\AVC\AppleSeed.avc")
            'Graph.AddKeyHD()
            'Graph.AddMCE_AVC()
            'Graph.AddVMR9(1)

            'HR = Graph.GraphBuilder.Connect(Graph.FSFA_Out, Graph.MCE_AVC_In)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            'HR = Graph.MCE_AVC.FindPin("Out", Graph.MCE_AVC_Out)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

        Catch ex As Exception
            MsgBox("Problem with BuildGraph_QuickTime(). Error: " & ex.Message)
        End Try
    End Function

    Public Function BuildGraph() As Boolean
        Try
            If Not Me.SetupGraphStub Then Return False
            If Not Me.AddDecklinkVideoRenderer Then Return False
            If Not Me.AddDecklinkAudioRenderer Then Return False
            If Not Me.AddNVidiaAudioDecoder Then Return False
            If Not Me.AddNVidiaVideoDecoder Then Return False
            If Not Me.AddKeystone Then Return False
            If Not Me.AddDVDNav Then Return False
            If Not Me.AddLine21Decoder Then Return False
            If Not Me.AddAMTC Then Return False
            If Not Me.AddL21G Then Return True

            HR = GraphBuilder.Render(Me.DVDNav_VidPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Render(Me.DVDNav_SubPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(DVDNav_AudPin, Me.AMTC_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.AMTC_Out, Me.DLAIn)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.VidDec_CC_Out, Me.L21G_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Render(Me.L21G_Out)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.VidDec_SP_Out, Me.Key_SP_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            Return True
        Catch ex As Exception
            MsgBox("Problem with BuildGraph. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function FindFilterByName(ByVal Name As String) As IBaseFilter
        Try
            Dim Out As IBaseFilter
            Dim hr As Integer = GraphBuilder.FindFilterByName(Name, Out)
            If hr < 0 Then Marshal.ThrowExceptionForHR(hr)
            Return Out
        Catch ex As Exception
            MsgBox("Problem with FindFilterByName. Error: " & ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function BuildGraph_m2v_dl() As Boolean
        Try
            If Not Me.SetupGraphStub Then Return False
            If Not Me.AddNVidiaVideoDecoder Then Return False
            If Not Me.AddKeystone Then Return False
            If Not Me.AddMPEG2Splitter Then Return False
            If Not Me.AddDecklinkVideoRenderer Then Return False

            HR = GraphBuilder.Connect(Me.VidDec_Vid_Out, Me.Key_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.Key_Out, Me.DLVIn)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.RenderFile("E:\Media\Video\Ten_VOB_1.m2v", Nothing)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            Return True
        Catch ex As Exception
            MsgBox("Problem with BuildGraph. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function BuildGraph_m2v() As Boolean
        Try
            If Not Me.SetupGraphStub Then Return False
            If Not Me.AddNVidiaVideoDecoder Then Return False
            'If Not Me.AddAdapter Then Return False
            If Not Me.AddVMR9 Then Return False

            HR = GraphBuilder.RenderFile("F:\MEDIA\SD\VTS_04_1_unfaithful_macrovision.m2v", Nothing)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            'HR = Me.VidDec_Vid_Out.Disconnect
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            'HR = GraphBuilder.Connect(Me.VidDec_Vid_Out, Me.BMA_In)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            'HR = GraphBuilder.Render(Me.BMA_Out)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            Return True
        Catch ex As Exception
            MsgBox("Problem with BuildGraph. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function BuildCSFGraph() As Boolean
        Try
            If Not Me.SetupGraphStub Then Return False

            If Not Me.AddCSF Then Return False

            If Not Me.AddDecklinkAudioRenderer Then Return False
            'If Not Me.AddDirectSoundRenderer Then Return False
            If Not Me.AddNVidiaAudioDecoder Then Return False
            If Not Me.AddNVidiaVideoDecoder Then Return False
            If Not Me.AddDVDNav Then Return False

            'If Not Me.AddAudioMTConformer Then Return False
            'If Not Me.AddNullNull Then Return False

            If Not ConnectPins() Then Return False

            If Not Me.AddDecklinkVideoRenderer Then Return False
            If Not Me.AddVMR9 Then Return False

            If Not Me.AddSampleGrabber Then Return False

            'HR = GraphBuilder.Render(CSFOut2)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            'Return True

            HR = GraphBuilder.Connect(CSFOut2, Me.SG_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(SG_Out, DLVIn)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Render(CSFOut1)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            Return True
        Catch ex As Exception
            MsgBox("Problem with BuildGraph. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Private DVDPlayer As cDVDPlayer
    Public Function BuildMeADVDPlayer() As Boolean
        'Try
        '    DVDPlayer = New cDVDPlayer(Me, False)
        '    Dim StU As New sNavigatorSetup
        '    With StU
        '        .ASPECT_RATIO = SMT.Common.Media.Players.DVD.Enums.ePreferredAspectRatio.Anamorphic
        '        .DEFAULT_AUDIO_EXTENSION = SMT.Common.Media.Players.DVD.Enums.eAudioExtensions.Not_Specified
        '        .DEFAULT_AUDIO_LANGUAGE = SMT.Common.Media.Players.DVD.Enums.eLanguages.English
        '        .DEFAULT_MENU_LANGUAGE = SMT.Common.Media.Players.DVD.Enums.eLanguages.English
        '        .DEFAULT_SUBTITLE_EXTENSION = SMT.Common.Media.Players.DVD.Enums.eSubExtensions.Caption_Big
        '        .DEFAULT_SUBTITLE_LANGUAGE = SMT.Common.Media.Players.DVD.Enums.eLanguages.English
        '        .PARENTAL_COUNTRY = SMT.Common.Media.Players.DVD.Enums.eCountries.UNITED_STATES
        '        .PARENTAL_LEVEL = SMT.Common.Media.Players.DVD.Enums.eParentalLevels.PL_Off
        '        .PLAYER_REGION = SMT.Common.Media.Players.DVD.Enums.eRegions.One
        '    End With
        '    DVDPlayer.InitializePlayer("E:\MEDIA\SDDVD\POST_LOGIC\MUSIC_IN_EXILE", StU)
        '    Return True
        'Catch ex As Exception
        '    Return False
        'End Try
    End Function

    Public Function BuildGraph_VMR_STD() As Boolean
        Try
            If Not Me.SetupGraphStub Then Return False
            If Not Me.AddDVDNav Then Exit Function
            If Not Me.AddNVidiaAudioDecoder Then Exit Function
            If Not Me.AddNVidiaVideoDecoder Then Exit Function
            If Not Me.AddVMR9 Then Exit Function

            HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\POETRY_BREAKS\VIDEO_TS")
            'HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\POST_LOGIC\MUSIC_IN_EXILE")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            'HR = Me.DVDCtrl.SelectVideoModePreference(1)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Render(DVDNav_AudPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Render(DVDNav_VidPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Render(DVDNav_SubPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Render(VidDec_CC_Out)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Render(VidDec_SP_Out)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            'hr = GraphBuilder.Render(Me.AudDec_OutPin)
            'If hr < 0 Then Marshal.ThrowExceptionForHR(hr)

            Return True
        Catch ex As Exception
            MsgBox("Problem with BuildGraph. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function BuildGraph_AMTC_DSound_VMR9() As Boolean
        Try
            If Not Me.SetupGraphStub Then Return False
            If Not Me.AddDVDNav Then Exit Function
            If Not Me.AddNVidiaAudioDecoder Then Exit Function
            If Not Me.AddNVidiaVideoDecoder Then Exit Function
            If Not Me.AddAMTC2 Then Exit Function
            If Not Me.AddVMR9 Then Exit Function
            If Not Me.AddDirectSoundRenderer Then Exit Function

            MediaCtrl.Stop()

            'HR = DVDCtrl.SetDVDDirectory("W:\SDDVD\POST_LOGIC\MUSIC_IN_EXILE")
            'HR = DVDCtrl.SetDVDDirectory("F:\MEDIA\SDDVD\ONE_IN_THE_BUSH")
            HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\POST_LOGIC\MUSIC_IN_EXILE")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = Me.DVDCtrl.SelectVideoModePreference(1)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(DVDNav_VidPin, Me.VidDec_VidInPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(DVDNav_SubPin, Me.VidDec_SubInPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.VidDec_Vid_Out, Me.VMR9_In0)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Render(VidDec_SP_Out)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(DVDNav_AudPin, Me.AudDec_InPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.AudDec_OutPin, Me.AMTC_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.AMTC_Out, Me.DSR_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            Return True
        Catch ex As Exception
            MsgBox("Problem with BuildGraph. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function BuildGraph_Simple() As Boolean
        Try
            If Not Me.SetupGraphStub Then Return False
            If Not Me.AddNVidiaVideoDecoder Then Return False
            If Not Me.AddKeystone Then Return False
            If Not Me.AddDVDNav Then Return False
            If Not Me.AddDecklinkVideoRenderer Then Return False

            HR = GraphBuilder.Connect(Me.DVDNav_VidPin, Me.VidDec_VidInPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.DVDNav_SubPin, Me.VidDec_SubInPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.VidDec_Vid_Out, Me.Key_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            'HR = GraphBuilder.Connect(Me.VidDec_SP_Out, Me.Key_SP_In)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.Key_Out, Me.DLVIn)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            Return True
        Catch ex As Exception
            MsgBox("Problem with BuildGraph. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function BuildL21Graph() As Boolean
        Try
            If Not Me.SetupGraphStub Then Return False
            If Not Me.AddDirectSoundRenderer Then Return False
            If Not Me.AddNVidiaAudioDecoder Then Return False
            If Not Me.AddNVidiaVideoDecoder Then Return False
            If Not Me.AddDVDNav Then Return False
            If Not Me.AddLine21Decoder Then Return False
            If Not Me.AddNullRenderer Then Return False
            If Not Me.AddSampleGrabber Then Return False
            If Not Me.AddOverlayMixer Then Return False
            If Not Me.AddVideoRenderer Then Return False

            HR = GraphBuilder.Connect(Me.DVDNav_AudPin, Me.AudDec_InPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.AudDec_OutPin, Me.DSR_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.DVDNav_VidPin, Me.VidDec_VidInPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.VidDec_Vid_Out, Me.VR_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.DVDNav_SubPin, Me.VidDec_SubInPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.VidDec_CC_Out, Me.L21_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            'Me.EnumeratePreferedMediaTypes(Me.L21_Out)

            'Dim MT As New DirectShow.AMMediaType
            'MT.majorType = New Guid("73646976-0000-0010-8000-00aa00389b71") 'MEDIATYPE_Video
            'MT.subType = New Guid("E436EB7D-524F-11CE-9F53-0020AF0BA770") 'MEDIASUBTYPE_RGB24
            'MT.formatType = New Guid("05589f80-c356-11ce-bf01-00aa0055595a")  'FORMAT_VideoInfo
            ''MT.formatType = New Guid("F72A76A0-EB0A-11D0-ACE4-0000C0CC16BA")  'FORMAT_VideoInfo2
            'MT.fixedSizeSamples = True
            'MT.sampleSize = 921600
            'MT.temporalCompression = False
            'MT.unkPtr = Nothing
            'MT.formatSize = 88

            'Dim VIH As New DVDMedia.VIDEOINFOHEADER
            'MT.formatPtr = Marshal.AllocCoTaskMem(MT.formatSize)
            'VIH.AvgTimePerFrame = 333667
            'VIH.BitErrorRate = 0
            'VIH.BitRate = 220962816
            'Dim R As New DsRECT
            'R.Bottom = 480
            'R.Top = 0
            'R.Right = 640
            'R.Left = 0
            'VIH.SrcRect = R
            'VIH.TagRect = R

            'VIH.BmiHeader = New DVDMedia.BITMAPINFOHEADER
            'VIH.BmiHeader.biBitCount = 24
            'VIH.BmiHeader.biClrImportant = 0
            'VIH.BmiHeader.biClrUsed = 0
            'VIH.BmiHeader.biHeight = 480
            'VIH.BmiHeader.biWidth = 640
            'VIH.BmiHeader.biPlanes = 1
            'VIH.BmiHeader.biSize = 40
            'VIH.BmiHeader.biSizeImage = 921600
            'VIH.BmiHeader.biXPelsPerMeter = 0
            'VIH.BmiHeader.biYPelsPerMeter = 0

            'HR = Me.L21_Out.QueryAccept(MT)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            'HR = Me.L21_Out.Connect(Me.SG_In, MT)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.L21_Out, Me.SG_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            Dim MT As AM_MEDIA_TYPE
            HR = Me.SG_In.ConnectionMediaType(MT)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            L218bitCT = GetL218bitCT(MT)

            HR = GraphBuilder.Connect(Me.SG_Out, Me.NR_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            Return True
        Catch ex As Exception
            MsgBox("Problem with BuildGraph. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function BuildGraph_DVD_L21G() As Boolean
        Try
            If Not Me.SetupGraphStub Then Return False
            If Not Me.AddNVidiaVideoDecoder Then Return False
            If Not Me.AddDVDNav Then Return False
            If Not Me.AddL21G Then Return False
            If Not Me.AddVMR9() Then Return False

            'HR = DVDCtrl.SetDVDDirectory("E:\Media\sddvd\TWO_TOWERS_NTSC_R1_D2\VIDEO_TS")
            HR = DVDCtrl.SetDVDDirectory("F:\MEDIA\SD\InconvienentTruth")
            'HR = DVDCtrl.SetDVDDirectory("F:\MEDIA\SD\WhoKilledTheElectricCar")
            'HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\CITY_OF_GOD")
            'HR = DVDCtrl.SetDVDDirectory("E:\MEDIA\SDDVD\UNFAITHFUL_NTSC_R34")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.DVDNav_VidPin, Me.VidDec_VidInPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.VidDec_Vid_Out, Me.VMR9_In0)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Connect(Me.VidDec_CC_Out, Me.L21G_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = GraphBuilder.Render(Me.L21G_Out)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            Return True
        Catch ex As Exception
            MsgBox("Problem with BuildGraph_DVD_L21G. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function BuildGraph_AVC_KEY_VMR() As Boolean
        Try
            Graph = New cSMTGraph(Handle)
            Graph.AddGraphToROT()
            Graph.AddFilesourceA("E:\MEDIA\VIDEO\1080\Ascent\AVC\AppleSeed.avc")
            Graph.AddKeyHD()
            Graph.AddMCE_AVC()
            Graph.AddVMR9(1)

            HR = Graph.GraphBuilder.Connect(Graph.FSFA_Out, Graph.MCE_AVC_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = Graph.MCE_AVC.FindPin("Out", Graph.MCE_AVC_Out)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = Graph.GraphBuilder.Connect(Graph.MCE_AVC_Out, Graph.KeyHD_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = Graph.GraphBuilder.Render(Graph.KeyHD_Out)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            'HR = Graph.GraphBuilder.Render(Graph.MCE_AVC_Out)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            'Dim SMT As FullMediaType
            'SMT = Me.GetPinMediaType(G.VMR9_In_1)

            Return True
        Catch ex As Exception
            MsgBox("Problem with BuildGraph. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function BuildGraph_AVC_DLV() As Boolean
        Try
            Graph = New cSMTGraph(Handle)
            Graph.AddGraphToROT()
            Graph.AddFilesourceA("E:\MEDIA\VIDEO\1080\Ascent\AVC\AppleSeed.avc")
            'G.AddKeyHD()
            Graph.AddMCE_AVC()
            Graph.AddDeckLinkVideo()

            HR = Graph.GraphBuilder.Connect(Graph.FSFA_Out, Graph.MCE_AVC_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = Graph.MCE_AVC.FindPin("Out", Graph.MCE_AVC_Out)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            'HR = G.GraphBuilder.Connect(G.MCE_AVC_Out, G.KeyHD_In)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = Graph.GraphBuilder.Render(Graph.MCE_AVC_Out)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            Return True
        Catch ex As Exception
            MsgBox("Problem with BuildGraph. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function BuildGraph_M2V_AJA() As Boolean
        Try
            Graph = New cSMTGraph(Handle)
            Graph.AddGraphToROT()
            Graph.AddFilesourceA("E:\MEDIA\VIDEO\480\LOTR_TT.m2v")
            Graph.AddAJARenderer()
            Graph.AddNVidiaVideoDecoder(False, False)

            HR = Graph.GraphBuilder.Connect(Graph.FSFA_Out, Graph.VidDec_Vid_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = Graph.GraphBuilder.Render(Graph.VidDec_Vid_Out)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            Return True
        Catch ex As Exception
            MsgBox("Problem with BuildGraph_M2V_AJA(). Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function BuildGraph_AVC_AJA() As Boolean
        Try
            Graph = New cSMTGraph(Handle)
            Graph.AddGraphToROT()
            Graph.AddFilesourceA("E:\MEDIA\VIDEO\1080\Ascent\AVC\AppleSeed.avc")
            'G.AddKeyHD()
            Graph.AddMCE_AVC()
            Graph.AddAJARenderer()

            HR = Graph.GraphBuilder.Connect(Graph.FSFA_Out, Graph.MCE_AVC_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = Graph.MCE_AVC.FindPin("Out", Graph.MCE_AVC_Out)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            'HR = G.GraphBuilder.Connect(G.MCE_AVC_Out, G.KeyHD_In)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = Graph.GraphBuilder.Render(Graph.MCE_AVC_Out)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            Return True
        Catch ex As Exception
            MsgBox("Problem with BuildGraph. Error: " & ex.Message)
            Return False
        End Try
    End Function

#Region "Line21Decoder2"

    Public Function AddLine21Decoder2(ByRef GB As IGraphBuilder) As Boolean
        Try
            Line21Decoder = CType(DsBugWO.CreateDsInstance(New Guid("E4206432-01A1-4BEE-B3E1-3702C8EDC574"), IBaseFilter_GUID), IBaseFilter)
            HR = GraphBuilder.AddFilter(Line21Decoder, "Line 21 Decoder 2")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            Line21 = CType(Line21Decoder, IAMLine21Decoder)
            HR = Line21.SetServiceState(AMLine21_CCState.Off)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            Return True
        Catch ex As Exception
            Me.AddConsoleLine("Problem with AddLine21Decoder2. Error: " & ex.Message)
            Return False
        End Try
    End Function

#End Region 'Line21Decoder2

#Region "AVI Splitter"

    Public AVISplitter As IBaseFilter
    Public Function AddAVISplitter(ByVal GB As IGraphBuilder) As Boolean
        Try
            '1B544C20-FD0B-11CE-8C63-00AA0044B51E
            AVISplitter = CType(DsBugWO.CreateDsInstance(New Guid("1B544C20-FD0B-11CE-8C63-00AA0044B51E"), IBaseFilter_GUID), IBaseFilter)
            HR = GraphBuilder.AddFilter(AVISplitter, "AVI Splitter")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            Return True
        Catch ex As Exception
            Me.AddConsoleLine("Problem with AddAVISplitter. Error: " & ex.Message)
            Return False
        End Try
    End Function

#End Region 'AVI Splitter

    Public FileSource As IBaseFilter
    Public iFSF As IFileSourceFilter
    Public FSF_Out As IPin
    Public Function AddFilesource(ByRef GB As IGraphBuilder) As Boolean
        Try
            FileSource = CType(DsBugWO.CreateDsInstance(New Guid("E436EBB5-524F-11CE-9F53-0020AF0BA770"), IBaseFilter_GUID), IBaseFilter)
            HR = GraphBuilder.AddFilter(FileSource, "FSF")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            iFSF = CType(FileSource, IFileSourceFilter)
            Return True
        Catch ex As Exception
            Me.AddConsoleLine("Problem with AddFilesource. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public L21G As IBaseFilter
    Public iL21G As IL21G
    Public L21G_In, L21G_Out As IPin

    Public Function AddL21G() As Boolean
        Try
            'A2957546-A38D-44b9-834E-096AF622EC3D
            L21G = CType(DsBugWO.CreateDsInstance(New Guid("A2957546-A38D-44b9-834E-096AF622EC3D"), Clsid.IBaseFilter_GUID), IBaseFilter)
            HR = GraphBuilder.AddFilter(L21G, "Seq. L21G")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            iL21G = CType(L21G, IL21G)
            L21G.FindPin("In", L21G_In)
            L21G.FindPin("Out", L21G_Out)
            Return True
        Catch ex As Exception
            Throw New Exception("Problem adding L21G. Error: " & ex.Message)
        End Try
    End Function

    Public L218bitCT() As Color
    Public Function GetL218bitCT(ByVal MT As AM_MEDIA_TYPE) As Color()
        Try
            Dim VIH As New VIDEOINFOHEADER
            Dim b(Convert.ToInt32(MT.cbFormat) - 1) As Byte
            For i As Integer = 0 To UBound(b)
                b(i) = Marshal.ReadByte(MT.pbFormat, i)
            Next

            VIH.AvgTimePerFrame = CInt("&h" & GetByte(b(23)) & GetByte(b(22)) & GetByte(b(21)) & GetByte(b(20)))
            VIH.BitRate = CInt("&h" & GetByte(b(35)) & GetByte(b(34)) & GetByte(b(33)) & GetByte(b(32)))
            VIH.BitErrorRate = CInt("&h" & GetByte(b(39)) & GetByte(b(38)) & GetByte(b(37)) & GetByte(b(36)))
            VIH.AvgTimePerFrame = CInt("&h" & GetByte(b(47)) & GetByte(b(46)) & GetByte(b(45)) & GetByte(b(44)) & GetByte(b(43)) & GetByte(b(42)) & GetByte(b(41)) & GetByte(b(40)))

            Dim R As New DsRECT
            R.Bottom = CInt("&h" & GetByte(b(13)) & GetByte(b(12)))
            R.Right = CInt("&h" & GetByte(b(9)) & GetByte(b(8)))
            R.Top = 0
            R.Left = 0
            VIH.SrcRect = R
            VIH.TagRect = R

            Dim OS As Short = 48
            VIH.BmiHeader.biSize = CInt("&h" & GetByte(b(OS + 3)) & GetByte(b(OS + 2)) & GetByte(b(OS + 1)) & GetByte(b(OS)))
            VIH.BmiHeader.biWidth = CInt("&h" & GetByte(b(OS + 7)) & GetByte(b(OS + 6)) & GetByte(b(OS + 5)) & GetByte(b(OS + 4)))
            VIH.BmiHeader.biHeight = CInt("&h" & GetByte(b(OS + 11)) & GetByte(b(OS + 10)) & GetByte(b(OS + 9)) & GetByte(b(OS + 8)))
            VIH.BmiHeader.biPlanes = CInt("&h" & GetByte(b(OS + 13)) & GetByte(b(OS + 12)))
            VIH.BmiHeader.biBitCount = CInt("&h" & GetByte(b(OS + 15)) & GetByte(b(OS + 14)))
            VIH.BmiHeader.biCompression = CInt("&h" & GetByte(b(OS + 19)) & GetByte(b(OS + 18)) & GetByte(b(OS + 17)) & GetByte(b(OS + 16)))
            VIH.BmiHeader.biSizeImage = CInt("&h" & GetByte(b(OS + 23)) & GetByte(b(OS + 22)) & GetByte(b(OS + 21)) & GetByte(b(OS + 20)))
            VIH.BmiHeader.biXPelsPerMeter = CInt("&h" & GetByte(b(OS + 27)) & GetByte(b(OS + 26)) & GetByte(b(OS + 25)) & GetByte(b(OS + 24)))
            VIH.BmiHeader.biYPelsPerMeter = CInt("&h" & GetByte(b(OS + 31)) & GetByte(b(OS + 30)) & GetByte(b(OS + 29)) & GetByte(b(OS + 28)))
            VIH.BmiHeader.biClrUsed = CInt("&h" & GetByte(b(OS + 35)) & GetByte(b(OS + 34)) & GetByte(b(OS + 33)) & GetByte(b(OS + 32)))
            VIH.BmiHeader.biClrImportant = CInt("&h" & GetByte(b(OS + 39)) & GetByte(b(OS + 38)) & GetByte(b(OS + 37)) & GetByte(b(OS + 36)))
            Dim CT(UBound(b) - (OS + 40)) As Byte
            Dim cnt As Integer = 0
            For i As Short = OS + 40 To UBound(b)
                CT(cnt) = b(i)
                cnt += 1
            Next

            Dim ColorColl((CT.Length / 4) - 1) As Color
            cnt = 0
            For i As Short = 0 To UBound(CT) Step 4
                ColorColl(cnt) = Color.FromArgb(CInt("&h" & GetByte(CT(i))), CInt("&h" & GetByte(CT(i + 1))), CInt("&h" & GetByte(CT(i + 2))))
                cnt += 1
            Next

            Return ColorColl
        Catch ex As Exception
            MsgBox("Problem with GetL218bitCT. Error: " & ex.Message)
        End Try
    End Function

    Public CSF_VMR_PP As ISpecifyPropertyPages
    Public CSFOut1, CSFOut2 As IPin
    Public Function AddCSF() As Boolean
        Try
            CSF = CType(DsBugWO.CreateDsInstance(New Guid("80F065C5-7C94-4EFA-ACDD-924DADF45BC0"), IBaseFilter_GUID), IBaseFilter)
            Dim hr As Integer = GraphBuilder.AddFilter(Me.CSF, "Sequoyan CSF")
            If hr < 0 Then Marshal.ThrowExceptionForHR(hr)

            hr = GraphBuilder.FindFilterByName("Sink VMR", CSF_VMR)
            If hr < 0 Then Marshal.ThrowExceptionForHR(hr)

            hr = CSF.FindPin("~Output 1", CSFOut1)
            If hr < 0 Then Marshal.ThrowExceptionForHR(hr)

            hr = CSF.FindPin("~Output 2", CSFOut2)
            If hr < 0 Then Marshal.ThrowExceptionForHR(hr)

            CSF_VMR_PP = CType(CSF_VMR, ISpecifyPropertyPages)

            Return True
        Catch ex As Exception
            MsgBox("Problem with AddCSF. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function AddElecardDecoder() As Boolean
        Try
            ElecardDecoder = CType(DsBugWO.CreateDsInstance(New Guid("F50B3F13-19C4-11CF-AA9A-02608C9BABA2"), IBaseFilter_GUID), IBaseFilter)
            Dim HR As Integer = GraphBuilder.AddFilter(Me.ElecardDecoder, "ElecardDecoder")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            'Me.EnumeratePinNames(ElecardDecoder)
            'Exit Function

            HR = ElecardDecoder.FindPin("Out", ElecardOutPin)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            'HR = GraphBuilder.Render(TmpPin)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            'Dim FMT As FullMediaType = Me.GetPinMediaType(TmpPin)

            Return True
        Catch ex As Exception
            MsgBox("Problem with AddElecardDecoder. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public MCE_CHG As IBaseFilter
    Public MCE_CHG_In As IPin
    Public MCE_CHG_PP As ISpecifyPropertyPages

    Public Function AddMCE_CHG() As Boolean
        Try
            MCE_CHG = CType(DsBugWO.CreateDsInstance(New Guid("5600EDB4-FE9A-4901-A504-29C855A7067C"), Clsid.IBaseFilter_GUID), IBaseFilter)
            HR = GraphBuilder.AddFilter(MCE_CHG, "MC CHG")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            MCE_CHG_PP = CType(MCE_CHG, ISpecifyPropertyPages)
            HR = MCE_CHG.FindPin("In", MCE_CHG_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            Return True
        Catch ex As Exception
            Throw New Exception("Problem with AddMCE_CHG. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public VR_In As IPin
    Public Function AddVideoRenderer() As Boolean
        Try
            VideoRenderer = CType(DsBugWO.CreateDsInstance(New Guid("70E102B0-5556-11CE-97C0-00AA0055595A"), IBaseFilter_GUID), IBaseFilter)
            Dim HR As Integer = GraphBuilder.AddFilter(VideoRenderer, "Video Renderer")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            VideoRenderer.FindPin("In", VR_In)
            Return True
        Catch ex As Exception
            MsgBox("Problem adding sample grabber. Error: " & ex.Message)
        End Try
    End Function

    Public VMTC As IBaseFilter
    Public VMTC_In, VMTC_Out As IPin
    Public Function AddVMTCPAL() As Boolean
        Try
            VMTC = CType(DsBugWO.CreateDsInstance(New Guid("A6512C9F-A47B-45BA-A054-0DB0D4BB87F8"), IBaseFilter_GUID), IBaseFilter)
            Dim HR As Integer = GraphBuilder.AddFilter(VMTC, "Seq. VMTC PAL")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            VMTC.FindPin("In", VMTC_In)
            VMTC.FindPin("Out", VMTC_Out)
            Return True
        Catch ex As Exception
            MsgBox("Problem adding sample grabber. Error: " & ex.Message)
        End Try
    End Function

    Public AMTC As IBaseFilter
    Public AMTC_In, AMTC_Out As IPin
    Public ifAMTC As IAMTC
    Public Function AddAMTC() As Boolean
        Try
            'New - A6512CF0-A47B-45ba-A054-0DB0D4BB87F7
            'Old - 52B63860-DC93-11CE-A099-00AA00479A58
            AMTC = CType(DsBugWO.CreateDsInstance(New Guid("A6512CF0-A47B-45ba-A054-0DB0D4BB87F7"), IBaseFilter_GUID), IBaseFilter)
            Dim HR As Integer = GraphBuilder.AddFilter(AMTC, "Seq. AMTC")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            AMTC.FindPin("In", AMTC_In)
            AMTC.FindPin("Out", AMTC_Out)
            Return True
        Catch ex As Exception
            MsgBox("Problem adding AMTC. Error: " & ex.Message)
        End Try
    End Function

    Public Function AddAMTC2() As Boolean
        Try
            AMTC = CType(DsBugWO.CreateDsInstance(New Guid("423C0845-670A-4036-B7D3-F45BA701D118"), IBaseFilter_GUID), IBaseFilter)
            Dim HR As Integer = GraphBuilder.AddFilter(AMTC, "SMT AMTC2")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            ifAMTC = CType(AMTC, IAMTC)
            AMTC.FindPin("Input", AMTC_In)
            AMTC.FindPin("Output", AMTC_Out)
            Return True
        Catch ex As Exception
            MsgBox("Problem adding AMTC2. Error: " & ex.Message)
        End Try
    End Function

    Public Function AddVMTCNTSC() As Boolean
        Try
            VMTC = CType(DsBugWO.CreateDsInstance(New Guid("A6512C9F-A47B-45BA-A054-0DB0D4BB87F7"), IBaseFilter_GUID), IBaseFilter)
            Dim HR As Integer = GraphBuilder.AddFilter(VMTC, "Seq. VMTC NTSC")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            VMTC.FindPin("In", VMTC_In)
            VMTC.FindPin("Out", VMTC_Out)
            Return True
        Catch ex As Exception
            MsgBox("Problem adding VMTC_NTSC. Error: " & ex.Message)
        End Try
    End Function

    Public Keystone As IBaseFilter
    Public Key_In, Key_SP_In, Key_CC_In, Key_Out As IPin
    Public Key_PP As ISpecifyPropertyPages
    Public iKeystone As IKeystone_SD
    Public ikeymix As IKeystoneMixer_SD
    Public Function AddKeystone() As Boolean
        Try
            Keystone = CType(DsBugWO.CreateDsInstance(New Guid("fd501043-8ebe-11ce-8183-00aa00577da1"), IBaseFilter_GUID), IBaseFilter)
            GraphBuilder.AddFilter(Keystone, "Keystone (Sequoyan LLC. © 2004-2005)")
            Key_PP = CType(Keystone, ISpecifyPropertyPages)
            Keystone.FindPin("Video", Key_In)
            Keystone.FindPin("Output", Key_Out)
            Keystone.FindPin("Subpicture", Key_SP_In)
            Keystone.FindPin("Line21", Key_CC_In)
            iKeystone = CType(Keystone, IKeystone_SD)
            ikeymix = CType(Keystone, IKeystoneMixer_SD)
            iKeystone.UnlockFilter(New Guid("fd501045-8ebe-11ce-8183-00aa00577da1"))
            Return True
        Catch ex As Exception
            MsgBox("Problem adding Keystone. Error: " & ex.Message)
        End Try
    End Function

    Public Function AddKeystoneOmni() As Boolean
        Try
            Keystone = CType(DsBugWO.CreateDsInstance(New Guid("fd501027-8ebe-11ce-8183-00aa00577da1"), IBaseFilter_GUID), IBaseFilter)
            GraphBuilder.AddFilter(Keystone, "Keystone OMNI")
            Key_PP = CType(Keystone, ISpecifyPropertyPages)
            Keystone.FindPin("Video", Key_In)
            Keystone.FindPin("Output", Key_Out)
            Keystone.FindPin("Subpicture", Key_SP_In)
            Keystone.FindPin("Line21", Key_CC_In)
            'iKeystone = CType(Keystone, IKeystone_SD)
            'ikeymix = CType(Keystone, IKeystoneMixer_SD)
            'iKeystone.UnlockFilter(New Guid("fd501045-8ebe-11ce-8183-00aa00577da1"))
            Return True
        Catch ex As Exception
            MsgBox("Problem adding Keystone. Error: " & ex.Message)
        End Try
    End Function

#Region "SMT KeyHD"

    Public KeyHD As IBaseFilter
    'Public Key_in, KeyHD_Out, KeyHD_CC, KeyHD_SP As IPin
    Public KeyHD_PP As ISpecifyPropertyPages
    'Public Key_CurrentOutHeight As Short
    'Public Key_OutputSizeSet As Boolean = False

    Public Function AddKeyHD_Simple() As Boolean
        Try
            KeyHD = CType(DsBugWO.CreateDsInstance(New Guid("A6512CFF-A47B-45BA-A054-0DB0D4BB87F7"), Clsid.IBaseFilter_GUID), IBaseFilter)
            HR = GraphBuilder.AddFilter(KeyHD, "SMT KeyHD (Simple)")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            KeyHD.FindPin("In", Key_In)
            Return True
        Catch ex As Exception
            Throw New Exception("Problem with AddKeyHD_Simple. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public iKeyHD As IKeystone_HD
    Public iKeyMixerHD As IKeystoneMixer_HD
    Public iKeyQualityHD As IKeystoneQuality_HD
    Public iKeyProcAmpHD As IKeystoneProcAmp_HD

    Public Function AddKeyHD() As Boolean
        Try
            KeyHD = CType(DsBugWO.CreateDsInstance(New Guid("FD5010FF-8EBE-11CE-8183-00AA00577DA1"), Clsid.IBaseFilter_GUID), IBaseFilter)
            HR = GraphBuilder.AddFilter(KeyHD, "SMT KeyHD")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            KeyHD_PP = CType(KeyHD, ISpecifyPropertyPages)
            iKeyHD = CType(KeyHD, IKeystone_HD)
            iKeyMixerHD = CType(KeyHD, IKeystoneMixer_HD)
            iKeyQualityHD = CType(KeyHD, IKeystoneQuality_HD)
            iKeyProcAmpHD = CType(KeyHD, IKeystoneProcAmp_HD)
            iKeyHD.UnlockFilter(New Guid("fd501045-8ebe-11ce-8183-00aa00577da1"))
            HR = KeyHD.FindPin("Video", Key_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            HR = KeyHD.FindPin("Output", Key_Out)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            'HR = KeyHD.FindPin("Line21", Key_CC)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            'HR = KeyHD.FindPin("Subpicture", Key_SP)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            Return True
        Catch ex As Exception
            Throw New Exception("Problem with AddKeyHD. Error: " & ex.Message)
            Return False
        End Try
    End Function

#End Region 'SMT KeyHD

    Public M2S_In, M2S_Out As IPin
    Public M2S As IBaseFilter
    Public Function AddMPEG2Splitter() As Boolean
        Try
            M2S = CType(DsBugWO.CreateDsInstance(New Guid("3AE86B20-7BE8-11D1-ABE6-00A0C905F375"), IBaseFilter_GUID), IBaseFilter)
            Dim HR As Integer = GraphBuilder.AddFilter(M2S, "MPEG-2 Splitter")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            M2S.FindPin("Input", M2S_In)
            'M2S.FindPin("Video", OM_Out)
            Return True
        Catch ex As Exception
            MsgBox("Problem adding mpeg2 splitter. Error: " & ex.Message)
        End Try
    End Function

#Region "MC Demux A"

    Public MCE_DMXA As IBaseFilter
    Public MCE_DMXA_In, MCE_DMXA_Out, MCE_DMXA_Out_Aud As IPin
    Public MCE_IMC_DMXA As ModuleConfig
    Public MCE_DMXA_IMS As IMediaSeeking
    Public MCE_DMX_PP As ISpecifyPropertyPages

    Public Function AddMCE_DMXA() As Boolean
        Try
            MCE_DMXA = CType(DsBugWO.CreateDsInstance(New Guid("136DCBF5-3874-4B70-AE3E-15997D6334F7"), Clsid.IBaseFilter_GUID), IBaseFilter)
            HR = GraphBuilder.AddFilter(MCE_DMXA, "MCE-DMX")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = MCE_DMXA.FindPin("Input", MCE_DMXA_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            MCE_DMX_PP = CType(MCE_DMXA, ISpecifyPropertyPages)

            Dim pIUnk As IntPtr = Marshal.GetIUnknownForObject(MCE_DMXA)
            MCE_IMC_DMXA = Elecard.ModuleConfigInterface.ModuleConfigAdapter.GetConfigInterface(pIUnk)
            Dim b As Boolean
            b = MCE_IMC_DMXA.SetParamValue(SMT.Common.Media.DirectShow.MainConcept.ModuleConfig_Consts.DMX_INIT_MODE, 2)
            b = MCE_IMC_DMXA.SetParamValue(SMT.Common.Media.DirectShow.MainConcept.ModuleConfig_Consts.EMPGDMX_DIRECT_PTS, 1)
            b = MCE_IMC_DMXA.SetParamValue(SMT.Common.Media.DirectShow.MainConcept.ModuleConfig_Consts.EMPGDMX_INDEX_MODE, 3)
            MCE_IMC_DMXA.CommitChanges()


            Return True
        Catch ex As Exception
            Throw New Exception("Problem with AddMCEDemuxA. Error: " & ex.Message)
        End Try
    End Function

#End Region 'MC Demux A

#Region "MC MPEG-2 Decoder A"

    Public MCE_MP2A As IBaseFilter
    Public MCE_MP2A_In, MCE_MP2A_Out As IPin
    Public MCE_MP2A_IMC As ModuleConfig
    'Public MCE_MP2A_PP As ISpecifyPropertyPages

    Public Function AddMCE_MP2A() As Boolean
        Try
            MCE_MP2A = CType(DsBugWO.CreateDsInstance(New Guid("BC4EB321-771F-4E9F-AF67-37C631ECA106"), Clsid.IBaseFilter_GUID), IBaseFilter)
            HR = GraphBuilder.AddFilter(MCE_MP2A, "MCE_MP2A")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            HR = MCE_MP2A.FindPin("In", MCE_MP2A_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            HR = MCE_MP2A.FindPin("Out", MCE_MP2A_Out)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            VideoDecoder_PP = CType(MCE_MP2A, ISpecifyPropertyPages)
            VSDecoder = MCE_MP2A

            Dim pIUnk As IntPtr = Marshal.GetIUnknownForObject(MCE_MP2A)
            MCE_MP2A_IMC = Elecard.ModuleConfigInterface.ModuleConfigAdapter.GetConfigInterface(pIUnk)
            Dim b As Boolean
            b = MCE_MP2A_IMC.SetParamValue(New Guid("85c6cbac-fbed-f244-a07c-6f9abd799e64"), Nothing)
            b = MCE_MP2A_IMC.SetParamValue(ModuleConfig_Consts.EMC_Quality, ModuleConfig_Consts.eEMC_Quality.ObeyQualityMessages)
            b = MCE_MP2A_IMC.SetParamValue(ModuleConfig_Consts.M2VD_Brightness, 128)
            b = MCE_MP2A_IMC.SetParamValue(ModuleConfig_Consts.HardwareAcceleration, 0)
            b = MCE_MP2A_IMC.SetParamValue(ModuleConfig_Consts.M2VD_Resolution, ModuleConfig_Consts.eResolutionMode.Resolution_Full)
            b = MCE_MP2A_IMC.SetParamValue(ModuleConfig_Consts.M2VD_IDCTPrecision, 1)
            b = MCE_MP2A_IMC.SetParamValue(ModuleConfig_Consts.M2VD_PostProcess, 0)
            b = MCE_MP2A_IMC.SetParamValue(ModuleConfig_Consts.Deinterlace, ModuleConfig_Consts.eDeinterlaceMode.Deinterlace_Weave)
            b = MCE_MP2A_IMC.SetParamValue(ModuleConfig_Consts.M2VD_DeinterlaceCondition, ModuleConfig_Consts.eDeinterlaceCondition.DeinterlaceCondition_Always)
            b = MCE_MP2A_IMC.SetParamValue(ModuleConfig_Consts.M2VD_HQUpsample, 1)
            b = MCE_MP2A_IMC.SetParamValue(ModuleConfig_Consts.DoubleRate, 0)
            b = MCE_MP2A_IMC.SetParamValue(ModuleConfig_Consts.FieldsReordering, 0)
            b = MCE_MP2A_IMC.SetParamValue(ModuleConfig_Consts.FieldsReorderingCondition, ModuleConfig_Consts.eFieldReorderingConditionMode.FieldReorderingCondition_Always)
            b = MCE_MP2A_IMC.SetParamValue(ModuleConfig_Consts.FormatVideoInfo, ModuleConfig_Consts.eFormatVideoInfo.FormatVideoInfo_Both)
            b = MCE_MP2A_IMC.SetParamValue(ModuleConfig_Consts.EMC_OSD, 1)
            b = MCE_MP2A_IMC.SetParamValue(ModuleConfig_Consts.M2VD_CCubeDecodeOrder, 0)
            b = MCE_MP2A_IMC.SetParamValue(ModuleConfig_Consts.EMC_ErrorConcealment, 0)
            'WHAT IS "SMP" ?
            b = MCE_MP2A_IMC.SetParamValue(ModuleConfig_Consts.M2VD_MediaTimeSource, 0)
            b = MCE_MP2A_IMC.SetParamValue(ModuleConfig_Consts.M2VD_SetMediaTime, 1)
            b = MCE_MP2A_IMC.SetParamValue(ModuleConfig_Consts.Synchronizing, ModuleConfig_Consts.eEM2VD_Synchronizing.PTS)


            MCE_MP2A_IMC.CommitChanges()
            Return True
        Catch ex As Exception
            Throw New Exception("Problem with AddMCE_MP2. Error: " & ex.Message)
        End Try
    End Function

#End Region 'MC MPEG-2 Decoder A

#Region "MS Filesource A"

    Public FileSourceA As IBaseFilter
    Public iFSFA As IFileSourceFilter
    Public FSFA_Out As IPin

    Public Function AddFilesourceA(ByVal FilePath As String) As Boolean
        Try
            FileSourceA = CType(DsBugWO.CreateDsInstance(New Guid("E436EBB5-524F-11CE-9F53-0020AF0BA770"), Clsid.IBaseFilter_GUID), IBaseFilter)
            HR = GraphBuilder.AddFilter(FileSourceA, "FSF")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            iFSFA = CType(FileSourceA, IFileSourceFilter)
            HR = iFSFA.Load(FilePath, 0)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            HR = FileSourceA.FindPin("Output", FSFA_Out)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            Return True
        Catch ex As Exception
            Throw New Exception("Problem with AddFilesource A. Error: " & ex.Message)
            Return False
        End Try
    End Function

#End Region 'MS Filesource A

    Public OM_In, OM_Out As IPin
    Public Function AddOverlayMixer() As Boolean
        Try
            OverlayMixer = CType(DsBugWO.CreateDsInstance(New Guid("CD8743A1-3736-11D0-9E69-00C04FD7C15B"), IBaseFilter_GUID), IBaseFilter)
            Dim HR As Integer = GraphBuilder.AddFilter(OverlayMixer, "Overlay Mixer")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            OverlayMixer.FindPin("In", OM_In)
            OverlayMixer.FindPin("Out", OM_Out)
            Return True
        Catch ex As Exception
            MsgBox("Problem adding sample grabber. Error: " & ex.Message)
        End Try
    End Function

    Public NullRenderer As IBaseFilter
    Public NR_In As IPin
    Public Function AddNullRenderer() As Boolean
        Try
            NullRenderer = CType(DsBugWO.CreateDsInstance(New Guid("C1F400A4-3F08-11D3-9F0B-006008039E37"), IBaseFilter_GUID), IBaseFilter)
            Dim HR As Integer = GraphBuilder.AddFilter(NullRenderer, "Null Renderer")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            NullRenderer.FindPin("In", NR_In)
            Return True
        Catch ex As Exception
            MsgBox("Problem adding sample grabber. Error: " & ex.Message)
        End Try
    End Function

    Public L21_In, L21_Out As IPin
    Public Function AddLine21Decoder() As Boolean
        Try
            Line21Decoder = CType(DsBugWO.CreateDsInstance(New Guid("6E8D4A20-310C-11D0-B79A-00AA003767A7"), IBaseFilter_GUID), IBaseFilter)
            Dim HR As Integer = GraphBuilder.AddFilter(Me.Line21Decoder, "Line 21 Decoder")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            Line21Decoder.FindPin("In", L21_In)
            Line21Decoder.FindPin("Out", L21_Out)
            Return True
        Catch ex As Exception
            MsgBox("Problem adding sample grabber. Error: " & ex.Message)
        End Try
    End Function

    Public SampleGrabber As IBaseFilter
    Public SG_In, SG_Out As IPin
    Public Function AddSampleGrabber() As Boolean
        Try
            SampleGrabber = CType(DsBugWO.CreateDsInstance(New Guid("C1F400A0-3F08-11D3-9F0B-006008039E37"), IBaseFilter_GUID), IBaseFilter)
            Dim HR As Integer = GraphBuilder.AddFilter(Me.SampleGrabber, "SampleGrabber")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            ISampGrab = CType(SampleGrabber, ISampleGrabber)
            HR = ISampGrab.SetBufferSamples(True)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            SampleGrabber.FindPin("In", SG_In)
            SampleGrabber.FindPin("Out", SG_Out)
            Return True
        Catch ex As Exception
            MsgBox("Problem adding sample grabber. Error: " & ex.Message)
        End Try
    End Function

    Public Function AddUYVYAP() As Boolean
        Try
            UYVYAP = CType(DsBugWO.CreateDsInstance(New Guid("0C5310B9-01F9-47C5-A02C-2E7D0D2C51D7"), IBaseFilter_GUID), IBaseFilter)
            GraphBuilder.AddFilter(Me.UYVYAP, "Sequoyan UYVY-AP")
            Return True
        Catch ex As Exception
            MsgBox("Problem with AddUYVY. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public BMAdapter As IBaseFilter
    Public BMA_In, BMA_Out As IPin
    Public Function AddAdapter() As Boolean
        Try
            BMAdapter = CType(DsBugWO.CreateDsInstance(New Guid("C80804E5-5AC4-4BF8-889E-8F27A9965CD4"), IBaseFilter_GUID), IBaseFilter)
            GraphBuilder.AddFilter(BMAdapter, "Sequoyan BM Adapter")
            BMAdapter.FindPin("In", BMA_In)
            BMAdapter.FindPin("Out", BMA_Out)
            Return True
        Catch ex As Exception
            MsgBox("Problem with AddAdapter. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public AudioMTConformer As IBaseFilter
    Public AudMTConf_InPin, AudMTConf_OutPin As IPin
    Public Function AddAudioMTConformer() As Boolean
        Try
            AudioMTConformer = CType(DsBugWO.CreateDsInstance(New Guid("A6512C9F-A47B-45ba-A054-0DB0D4BB87F8"), IBaseFilter_GUID), IBaseFilter)
            GraphBuilder.AddFilter(Me.AudioMTConformer, "AudioMTConformer")
            AudioMTConformer.FindPin("In", AudMTConf_InPin)
            AudioMTConformer.FindPin("Out", AudMTConf_OutPin)
            Return True
        Catch ex As Exception
            MsgBox("Problem with AddDirectSound. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public DSR_In As IPin
    Public Function AddDirectSoundRenderer() As Boolean
        Try
            AudioRenderer = CType(DsBugWO.CreateDsInstance(New Guid("79376820-07D0-11CF-A24D-0020AFD79767"), IBaseFilter_GUID), IBaseFilter)
            GraphBuilder.AddFilter(Me.AudioRenderer, "DirectSound Renderer")
            'AudioRenderer_PP = CType(AudioRenderer, ISpecifyPropertyPages)
            Me.EnumeratePinNames(AudioRenderer)
            AudioRenderer.FindPin("Audio Input pin (rendered)", DSR_In)
            Return True
        Catch ex As Exception
            MsgBox("Problem with AddDirectSound. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public PinTee As IBaseFilter
    Public PT_In, PT_Out1, PT_Out2 As IPin
    Public Function AddPinTee() As Boolean
        Try
            'PinTee = CType(DsBugWO.CreateDsInstance(New Guid("79376820-07D0-11CF-A24D-0020AFD79767"), IBaseFilter_GUID), IBaseFilter)
            PinTee = CType(DsBugWO.CreateDsInstance(New Guid("F8388A40-D5BB-11D0-BE5A-0080C706568E"), IBaseFilter_GUID), IBaseFilter)
            GraphBuilder.AddFilter(Me.PinTee, "Pin Tee")
            'AudioRenderer_PP = CType(AudioRenderer, ISpecifyPropertyPages)
            'Me.EnumeratePinNames(PinTee)
            PinTee.FindPin("Input", PT_In)
            PinTee.FindPin("Output1", PT_Out1)
            Return True
        Catch ex As Exception
            MsgBox("Problem with AddDirectSound. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function AddDVDNav() As Boolean
        Try
            'DVD Navigator
            DVDNavigator = CType(DsBugWO.CreateDsInstance(New Guid("9B8C4620-2C1A-11D0-8493-00A02438AD48"), IBaseFilter_GUID), IBaseFilter)
            GraphBuilder.AddFilter(DVDNavigator, "DVD Navigator")
            DVDCtrl = CType(DVDNavigator, IDvdControl2)
            DVDCtrl.SetOption(DvdOptionFlag.DVD_HMSF_TimeCodeEvents, True)
            DVDCtrl.SetOption(DvdOptionFlag.DVD_NotifyParentalLevelChange, True)
            DVDCtrl.SetOption(DvdOptionFlag.DVD_ResetOnStop, True)
            DVDInfo = CType(DVDNavigator, IDvdInfo2)
            'DVDNavigator_PP = CType(DVDNavigator, ISpecifyPropertyPages)
            DVDNavigator.FindPin("Video", DVDNav_VidPin)
            DVDNavigator.FindPin("AC3", DVDNav_AudPin)
            DVDNavigator.FindPin("SubPicture", DVDNav_SubPin)
            DVDCtrl.SelectVideoModePreference(3)

            'DEBUGGING
            'HR = DVDCtrl.SetDVDDirectory("E:\Media\sddvd\TWO_TOWERS_NTSC_R1_D2\VIDEO_TS")
            'HR = DVDCtrl.SetDVDDirectory("F:\MEDIA\SD\InconvienentTruth")
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            'Dim DM As DvdDomain
            'HR = DVDInfo.GetCurrentDomain(DM)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            'Me.AddConsoleLine(DM.ToString)

            'Dim L As New cLanguages(Me.GetExePath & "Languages.csv")

            'HR = DVDCtrl.SelectDefaultMenuLanguage(L.GetLanguageByName("French").DecimalValue)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            'AddConsoleLine("Player menu language set to: " & GetDefaultMenuLanguage())
            'DEBUGGING

            Return True
        Catch ex As Exception
            MsgBox("Problem with add DVD Nav. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function GetLanguageByLCID(ByVal LCID As Long) As String
        Try
            Dim Lang As String = GetUserLocaleInfo(LCID, LOCALE_SENGLANGUAGE)
            Return Lang
        Catch ex As Exception
            AddConsoleLine("error getting language. error: " & ex.Message)
        End Try
    End Function

    Public Const LOCALE_SENGLANGUAGE As Long = &H1001          'English name of lang

    Public Function GetUserLocaleInfo(ByVal dwLocaleID As Long, ByVal dwLCType As Long) As String
        Dim sReturn As String
        Dim r As Long

        'call the function passing the Locale type
        'variable to retrieve the required size of
        'the string buffer needed
        r = GetLocaleInfo(dwLocaleID, dwLCType, sReturn, Len(sReturn))

        'if successful..
        If r Then

            'pad the buffer with spaces
            sReturn = Space$(r)

            'and call again passing the buffer
            r = GetLocaleInfo(dwLocaleID, dwLCType, sReturn, Len(sReturn))

            'if successful (r > 0)
            If r Then

                'r holds the size of the string
                'including the terminating null
                GetUserLocaleInfo = Microsoft.VisualBasic.Left(sReturn, r - 1)

            End If

        End If

    End Function

    Declare Function GetLocaleInfo Lib "kernel32" Alias "GetLocaleInfoA" (ByVal Locale As Integer, ByVal LCType As Integer, ByVal lpLCData As String, ByVal cchData As Integer) As Integer

    Public Function GetDefaultMenuLanguage() As String
        Try
            Dim L As Integer
            HR = DVDInfo.GetDefaultMenuLanguage(L)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            'AddConsoleLine("Default menu language: " & DB.GetLanguageByLCID(L))
            Return GetLanguageByLCID(L)
        Catch ex As Exception
            AddConsoleLine("Problem with GetDefaultMenuLanguage. Error: " & ex.Message)
        End Try
    End Function

    Public Function GetExePath() As String
        Return Replace(Application.ExecutablePath.ToLower, "graphtester.exe", "", 1, -1, CompareMethod.Text)
    End Function

    Public DLAIn As IPin
    Public Function AddDecklinkAudioRenderer() As Boolean
        Try
            AudioRenderer = CType(DsBugWO.CreateDsInstance(New Guid("19FA8CC3-56CE-46AB-825D-5CE1A39B137A"), IBaseFilter_GUID), IBaseFilter)
            GraphBuilder.AddFilter(AudioRenderer, "DeckLink Audio Renderer")
            AudioRenderer.FindPin("In", DLAIn)
            Me.AudioRenderer_PP = CType(AudioRenderer, ISpecifyPropertyPages)
            Return True
        Catch ex As Exception
            MsgBox("Problem with add Decklink audio renderer. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public AJARen As IBaseFilter
    Public AJA_Audio, AJA_Video As IPin
    Public Function AddAJARenderer() As Boolean
        Try
            AJARen = CType(DsBugWO.CreateDsInstance(New Guid("0890EBDD-1A17-432F-9146-E87926EE412E"), IBaseFilter_GUID), IBaseFilter)
            GraphBuilder.AddFilter(AJARen, "AJA Renderer")
            AJARen.FindPin("Video", AJA_Video)
            AJARen.FindPin("Audio", AJA_Audio)
            RefClock = CType(AJARen, IReferenceClock)
            'Me.AudioRenderer_PP = CType(AudioRenderer, ISpecifyPropertyPages)
            Return True
        Catch ex As Exception
            MsgBox("Problem with AddAJARenderer(). Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public DLVIn As IPin
    Public Function AddDecklinkVideoRenderer() As Boolean
        Try
            VideoRenderer = CType(DsBugWO.CreateDsInstance(New Guid("CEB13CC8-3591-45A5-BA0F-20E9A1D72F76"), IBaseFilter_GUID), IBaseFilter)
            HR = GraphBuilder.AddFilter(VideoRenderer, "DeckLink Video Renderer")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = VideoRenderer.FindPin("In", DLVIn)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            Return True
        Catch ex As Exception
            MsgBox("Problem with add Decklink video renderer. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public AudDec_OutPin As IPin
    Public Function AddNVidiaAudioDecoder() As Boolean
        Try
            AudioDecoder = CType(DsBugWO.CreateDsInstance(New Guid("6C0BDF86-C36A-4D83-8BDB-312D2EAF409E"), IBaseFilter_GUID), IBaseFilter)
            GraphBuilder.AddFilter(AudioDecoder, "NVIDIA Audio Decoder")
            If AudioDecoder_PP Is Nothing Then AudioDecoder_PP = CType(AudioDecoder, ISpecifyPropertyPages)
            If nvAudioAtts Is Nothing Then nvAudioAtts = CType(AudioDecoder, NvSharedLib.INvAttributes)
            InitializeAudioDecoder()
            AudioDecoder.FindPin("Audio Input", AudDec_InPin)
            AudioDecoder.FindPin("Audio Output", AudDec_OutPin)
            Return True
        Catch ex As Exception
            MsgBox("Problem with add nVidia audio. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function AddNVidiaVideoDecoder() As Boolean
        Try
            VSDecoder = CType(DsBugWO.CreateDsInstance(New Guid("71E4616A-DB5E-452B-8CA5-71D9CC7805E9"), IBaseFilter_GUID), IBaseFilter)
            GraphBuilder.AddFilter(VSDecoder, "NVIDIA Video Decoder")
            nvVideoAtts = CType(VSDecoder, NvSharedLib.INvAttributes)
            InitializeVideoDecoder()
            VideoDecoder_PP = CType(VSDecoder, ISpecifyPropertyPages)
            VSDecoder.FindPin("~Line21 Output", VidDec_CC_Out)
            VSDecoder.FindPin("~Subpicture Output", VidDec_SP_Out)
            VSDecoder.FindPin("Video Input", VidDec_VidInPin)
            VSDecoder.FindPin("Subpicture Input", VidDec_SubInPin)
            VSDecoder.FindPin("Video Output", VidDec_Vid_Out)

            'only argb4444 sp output
            nvVideoAtts.SetLong(nvcommon.ENvVideoDecoderProps.NVVIDDEC_CONFIG, nvcommon.ENvidiaVideoDecoderProps_ConfigTypes.NVVIDDEC_CONFIG_SUBPICTURE_FORMATS, nvcommon.NVVIDDEC_CONFIG_BITS_SP_ARGB4444)
            nvVideoAtts.SetLong(nvcommon.ENvVideoDecoderProps.NVVIDDEC_CONFIG, nvcommon.ENvidiaVideoDecoderProps_ConfigTypes.NVVIDDEC_CONFIG_DISABLE_DROP_FRAMES, 1)

            If 1 = 0 Then
                'hardware acceleration
                'deinterlace mode: best available
                nvVideoAtts.SetLong(nvcommon.ENvVideoDecoderProps.NVVIDDEC_CONFIG, nvcommon.ENvidiaVideoDecoderProps_ConfigTypes.NVVIDDEC_CONFIG_DEINTERLACE_CONTROL, nvcommon.ENVVIDDEC_CONFIG_DEINTERLACE_MODE_CTRL.NVVIDDEC_CONFIG_DEINTERLACE_CTRL_AUTO)
                nvVideoAtts.SetLong(nvcommon.ENvVideoDecoderProps.NVVIDDEC_CONFIG, nvcommon.ENvidiaVideoDecoderProps_ConfigTypes.NVVIDDEC_CONFIG_DEINTERLACE_MODE, nvcommon.ENVVIDDEC_CONFIG_DEINTERLACE_MODE.NVVIDDEC_CONFIG_DEINTERLACE_NORMAL)
                nvVideoAtts.SetLong(nvcommon.ENvVideoDecoderProps.NVVIDDEC_CONFIG, nvcommon.ENvidiaVideoDecoderProps_ConfigTypes.NVVIDDEC_CONFIG_ENABLE_DXVA, 1)
            Else
                'film/weave
                nvVideoAtts.SetLong(nvcommon.ENvVideoDecoderProps.NVVIDDEC_CONFIG, nvcommon.ENvidiaVideoDecoderProps_ConfigTypes.NVVIDDEC_CONFIG_DEINTERLACE_CONTROL, nvcommon.ENVVIDDEC_CONFIG_DEINTERLACE_MODE_CTRL.NVVIDDEC_CONFIG_DEINTERLACE_CTRL_FILM)
                nvVideoAtts.SetLong(nvcommon.ENvVideoDecoderProps.NVVIDDEC_CONFIG, nvcommon.ENvidiaVideoDecoderProps_ConfigTypes.NVVIDDEC_CONFIG_DEINTERLACE_MODE, nvcommon.ENVVIDDEC_CONFIG_DEINTERLACE_MODE.NVVIDDEC_CONFIG_DEINTERLACE_FILTERED_WEAVE)
                nvVideoAtts.SetLong(nvcommon.ENvVideoDecoderProps.NVVIDDEC_CONFIG, nvcommon.ENvidiaVideoDecoderProps_ConfigTypes.NVVIDDEC_CONFIG_ENABLE_DXVA, 0)
            End If
            Return True
        Catch ex As Exception
            MsgBox("Problem with add NVidia Video Decoder. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public VMR9_In0 As IPin
    Public IQP As IQualProp
    Public Function AddVMR9() As Boolean
        Try
            VMR9 = CType(DsBugWO.CreateDsInstance(New Guid("51B4ABF3-748F-4E3B-A276-C828330E926A"), IBaseFilter_GUID), IBaseFilter)
            GraphBuilder.AddFilter(VMR9, "Video Mixing Renderer 9")
            VMRFilterConfig = CType(VMR9, IVMRFilterConfig9)
            VMRAspectRatio = CType(VMR9, IVMRAspectRatioControl9)
            VMRMixerBitmap = CType(VMR9, IVMRMixerBitmap9)
            VMRMonitorConfig = CType(VMR9, IVMRMonitorConfig9)
            'VMRWindowlessControl = CType(VMR9, IVMRWindowlessControl9)
            VideoRenderer_PP = CType(VMR9, ISpecifyPropertyPages)
            VMRDeinterlaceControl = CType(VMR9, IVMRDeinterlaceControl9)

            'VMR9 Setup
            '1) Add pins
            VMRFilterConfig.SetNumberOfStreams(Convert.ToUInt32(3))

            '2)windowed or windowless?
            'use windowed, windowless is buggy, or so says Yaron/InMatrix
            VMRFilterConfig.SetRenderingMode(VMR9Mode.VMR9Mode_Windowed)

            '3) Aspect ratio
            VMRAspectRatio.SetAspectRatioMode(VMR9AspectRatioMode.VMR9ARMode_None)

            '4) Get Mixer Control
            VMRMixerControl = CType(VMR9, IVMRMixerControl9)

            UsingVMR9 = True
            'SetLetterbox()

            'End VMR9 Setup

            'Me.EnumeratePinNames(VMR9)
            VMR9.FindPin("VMR Input0", Me.VMR9_In0)

            IQP = CType(VMR9, IQualProp)
            'IQP = CType(VMR9_In0, IQualProp)

            Return True
        Catch ex As Exception
            MsgBox("Problem with add VMR9. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public NullNull As IBaseFilter
    Public NNIn, NNOut As IPin

    Public Function AddLine21Decoder2() As Boolean
        Try
            Line21Decoder = CType(DsBugWO.CreateDsInstance(New Guid("E4206432-01A1-4BEE-B3E1-3702C8EDC574"), IBaseFilter_GUID), IBaseFilter)
            GraphBuilder.AddFilter(Line21Decoder, "Line 21 Decoder 2")
            Line21 = CType(Line21Decoder, IAMLine21Decoder)
            Line21.SetServiceState(AMLine21_CCState.Off)
            Line21Decoder.FindPin("In", L21_In)
            Line21Decoder.FindPin("Out", L21_Out)
            Return True
        Catch ex As Exception
            MsgBox("Problem with add Line21Decoder2. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function AddNullNull() As Boolean
        Try
            NullNull = CType(DsBugWO.CreateDsInstance(New Guid("08AF6540-4F21-11CF-AACB-0020AF0B99A3"), IBaseFilter_GUID), IBaseFilter)
            GraphBuilder.AddFilter(Me.NullNull, "Sequoyan NullNull")
            NullNull.FindPin("In", NNIn)
            NullNull.FindPin("Out", NNOut)
            Return True
        Catch ex As Exception
            MsgBox("Problem with AddNullNull. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function SetupGraphStub() As Boolean
        Try
            If GraphBuilder Is Nothing Then
                GraphBuilder = DsBugWO.CreateDsInstance(Clsid.FilterGraphManager, IGraphBuilder_GUID)
                'AddGraphToROT(GraphBuilder)
            End If
            'VideoStep = CType(GraphBuilder, IVideoFrameStep)
            VideoWin = CType(GraphBuilder, IVideoWindow)
            MediaCtrl = CType(GraphBuilder, IMediaControl)
            MediaEvt = CType(GraphBuilder, IMediaEvent)
            MediaEvt.SetNotifyWindow(Me.Handle, WM_DVD_EVENT, IntPtr.Zero)
            Graph_IMF = CType(GraphBuilder, IMediaFilter)
            'BasicAudio = CType(GraphBuilder, IBasicAudio)
            'BasicVideo = CType(GraphBuilder, IBasicVideo2)
            Return True
        Catch ex As Exception
            MsgBox("Problem with SetupGraphStub. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function SetAudDecOutPinMediaType() As Boolean
        Try
            Dim SC As IAMStreamConfig = CType(Me.AudioDecoder, IAMStreamConfig)

            Dim AM As New AM_MEDIA_TYPE
            AM.bFixedSizeSamples = True
            AM.bTemporalCompression = False
            AM.cbFormat = Convert.ToUInt32(40)
            AM.formattype = New Guid("")
            AM.lSampleSize = Convert.ToUInt32(73728)
            AM.majortype = New Guid("")
            AM.pUnk = Nothing
            AM.subtype = New Guid("")

            Dim WFXTN As New WAVEFORMATEXTENSIBLE
            Dim WFX As New WAVEFORMATEX

            WFXTN.dwChannelMask = 0
            WFXTN.Format = WFX

            WFXTN.SubFormat = Nothing

            'WFX.wFormatTag = DVDMedia.WAVE_FORMAT.WAVE_FORMAT_PCM
            WFX.wFormatTag = WAVE_FORMAT.WAVE_FORMAT_DOLBY_AC3_SPDIF
            'WFX.wFormatTag = DVDMedia.WAVE_FORMAT.WAVE_FORMAT_EXTENSIBLE

            AM.pbFormat = Marshal.AllocCoTaskMem(Marshal.SizeOf(WFXTN))
            HR = SC.SetFormat(AM)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
        Catch ex As Exception
            Me.AddLine(ex.Message)
            Return False
        End Try
    End Function

    Public Function ConnectPins() As Boolean
        Try
            Dim hr As Integer
            hr = GraphBuilder.Connect(DVDNav_AudPin, Me.AudDec_InPin)
            'hr = GraphBuilder.Render(DVDNav_AudPin)
            If hr < 0 Then Marshal.ThrowExceptionForHR(hr)

            'Set audio decoder output pin format
            'If Not SetAudDecOutPinMediaType() Then Throw New Exception("Could not set aud dec output pin media type.")

            hr = GraphBuilder.Render(Me.AudDec_OutPin)
            If hr < 0 Then Marshal.ThrowExceptionForHR(hr)

            'hr = GraphBuilder.ConnectDirect(Me.AudDec_OutPin, Me.AudMTConf_InPin)
            'If hr < 0 Then Marshal.ThrowExceptionForHR(hr)

            'hr = GraphBuilder.ConnectDirect(Me.AudMTConf_OutPin, Me.DLAIn)
            'If hr < 0 Then Marshal.ThrowExceptionForHR(hr)

            hr = GraphBuilder.Render(DVDNav_VidPin)
            If hr < 0 Then Marshal.ThrowExceptionForHR(hr)

            hr = GraphBuilder.Render(DVDNav_SubPin)
            If hr < 0 Then Marshal.ThrowExceptionForHR(hr)

            hr = GraphBuilder.Render(VidDec_CC_Out)
            If hr < 0 Then Marshal.ThrowExceptionForHR(hr)

            hr = GraphBuilder.Render(VidDec_SP_Out)
            If hr < 0 Then Marshal.ThrowExceptionForHR(hr)

            Return True
        Catch ex As Exception
            MsgBox("Problem with connect pins. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function FinalizeGraphCreation() As Boolean
        Try
            MediaEvt.SetNotifyWindow(VW.Handle, WM_DVD_EVENT, IntPtr.Zero)
            VideoWin.put_Owner(VW.Handle)
            VideoWin.put_WindowStyle(WS_CHILD Or WS_CLIPSIBLINGS Or WS_CLIPCHILDREN)
            VideoWin.put_MessageDrain(VW.Handle)
            VideoWin.SetWindowPosition(0, 0, VW.ClientRectangle.Right, VW.ClientRectangle.Bottom)
            Line21.SetServiceState(AMLine21_CCState.Off)
            Me.SetupDeinterlacing()
            Return True
        Catch ex As Exception
            MsgBox("Problem with FinalizeGraphCreation. Error: " & ex.Message)
        End Try
    End Function

    Public Function DestroyGraph(ByVal Sender As String) As Boolean
        Try
            If Not Me.UYVYAP Is Nothing Then
                Marshal.ReleaseComObject(UYVYAP)
                UYVYAP = Nothing
            End If

            If Not Me.VSDecoder Is Nothing Then
                Marshal.ReleaseComObject(VSDecoder)
                VSDecoder = Nothing
            End If

            If Not Me.AudioDecoder Is Nothing Then
                Marshal.ReleaseComObject(AudioDecoder)
                AudioDecoder = Nothing
            End If

            If Not Me.VideoRenderer Is Nothing Then
                Marshal.ReleaseComObject(VideoRenderer)
                VideoRenderer = Nothing
            End If

            If Not Me.AudioRenderer Is Nothing Then
                Marshal.ReleaseComObject(AudioRenderer)
                AudioRenderer = Nothing
            End If

            If Not Me.DVDNavigator Is Nothing Then
                Marshal.ReleaseComObject(DVDNavigator)
                DVDNavigator = Nothing
            End If

            If Not Me.CSF Is Nothing Then
                Marshal.ReleaseComObject(CSF)
                CSF = Nothing
            End If

            If Not Me.CSF_VMR Is Nothing Then
                Marshal.ReleaseComObject(CSF_VMR)
                CSF_VMR = Nothing
            End If

            If Not Me.VMR9 Is Nothing Then
                Marshal.ReleaseComObject(VMR9)
                VMR9 = Nothing
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
        'Try
        '    Dim hr As Integer
        '    If Not DVDCtrl Is Nothing And Not MediaCtrl Is Nothing Then
        '        DVDCtrl.Stop()
        '        MediaCtrl.Stop()
        '    End If

        '    MediaEvt.SetNotifyWindow(IntPtr.Zero, WM_DVD_EVENT, IntPtr.Zero)

        '    If Not Me.UYVYAP Is Nothing Then
        '        Marshal.ReleaseComObject(UYVYAP)
        '        UYVYAP = Nothing
        '    End If

        '    If Not DVDCtrl Is Nothing Then
        '        Marshal.ReleaseComObject(DVDCtrl)
        '        DVDCtrl = Nothing
        '    End If

        '    If Not DVDInfo Is Nothing Then
        '        Marshal.ReleaseComObject(DVDInfo)
        '        DVDInfo = Nothing
        '    End If

        '    If Not DVDNavigator Is Nothing Then
        '        Marshal.ReleaseComObject(DVDNavigator)
        '        DVDNavigator = Nothing
        '    End If

        '    If Not GraphBuilder Is Nothing Then
        '        Try
        '            Me.RemoveAllFiltersFromGraph(GraphBuilder)
        '            CleanUpROT()
        '        Catch ex As Exception
        '            Debug.WriteLine("Could not remove the graph from the rot")
        '        End Try
        '    End If

        '    If Not VideoWin Is Nothing Then
        '        VideoWin.put_Visible(DsHlp.OAFALSE)
        '        VideoWin.put_MessageDrain(IntPtr.Zero)
        '        VideoWin.put_Owner(IntPtr.Zero)
        '        VideoWin = Nothing
        '    End If

        '    If Not VideoStep Is Nothing Then
        '        Marshal.ReleaseComObject(VideoStep)
        '        VideoStep = Nothing
        '    End If

        '    'If Not cmdOption.dvdCmd Is Nothing Then
        '    '    Marshal.ReleaseComObject(cmdOption.dvdCmd)
        '    '    cmdOption.dvdCmd = Nothing
        '    'End If

        '    If Not AudioDecoder Is Nothing Then
        '        Marshal.ReleaseComObject(AudioDecoder)
        '        AudioDecoder = Nothing
        '    End If

        '    If Not VSDecoder Is Nothing Then
        '        Marshal.ReleaseComObject(VSDecoder)
        '        VSDecoder = Nothing
        '    End If

        '    If Not Line21Decoder Is Nothing Then
        '        Marshal.ReleaseComObject(Line21Decoder)
        '        Line21Decoder = Nothing
        '    End If

        '    If Not OverlayMixer Is Nothing Then
        '        Marshal.ReleaseComObject(OverlayMixer)
        '        OverlayMixer = Nothing
        '    End If

        '    If Not VideoRenderer Is Nothing Then
        '        Marshal.ReleaseComObject(VideoRenderer)
        '        VideoRenderer = Nothing
        '    End If

        '    If Not AudioRenderer Is Nothing Then
        '        Marshal.ReleaseComObject(AudioRenderer)
        '        AudioRenderer = Nothing
        '    End If

        '    If Not Line21 Is Nothing Then
        '        Marshal.ReleaseComObject(Line21)
        '        Line21 = Nothing
        '    End If

        '    If Not PinConfig Is Nothing Then
        '        Marshal.ReleaseComObject(PinConfig)
        '        PinConfig = Nothing
        '    End If

        '    If Not DVDNavigator_PP Is Nothing Then
        '        Marshal.ReleaseComObject(DVDNavigator_PP)
        '        DVDNavigator_PP = Nothing
        '    End If

        '    If Not AudioDecoder_PP Is Nothing Then
        '        Marshal.ReleaseComObject(AudioDecoder_PP)
        '        AudioDecoder_PP = Nothing
        '    End If

        '    If Not VideoDecoder_PP Is Nothing Then
        '        Marshal.ReleaseComObject(VideoDecoder_PP)
        '        VideoDecoder_PP = Nothing
        '    End If

        '    If Not Line21Decoder_PP Is Nothing Then
        '        Marshal.ReleaseComObject(Line21Decoder_PP)
        '        Line21Decoder_PP = Nothing
        '    End If

        '    If Not OverlayMixer_PP Is Nothing Then
        '        Marshal.ReleaseComObject(OverlayMixer_PP)
        '        OverlayMixer_PP = Nothing
        '    End If

        '    If Not VideoRenderer_PP Is Nothing Then
        '        Marshal.ReleaseComObject(VideoRenderer_PP)
        '        VideoRenderer_PP = Nothing
        '    End If

        '    If Not AudioRenderer_PP Is Nothing Then
        '        Marshal.ReleaseComObject(AudioRenderer_PP)
        '        AudioRenderer_PP = Nothing
        '    End If

        '    If Not MediaCtrl Is Nothing Then
        '        Marshal.ReleaseComObject(MediaCtrl)
        '        MediaCtrl = Nothing
        '    End If

        '    If Not MediaEvt Is Nothing Then
        '        Marshal.ReleaseComObject(MediaEvt)
        '        MediaEvt = Nothing
        '    End If

        '    If Not GraphBuilder Is Nothing Then
        '        Marshal.ReleaseComObject(GraphBuilder)
        '        GraphBuilder = Nothing
        '    End If

        '    If Not VMR9 Is Nothing Then
        '        Marshal.ReleaseComObject(VMR9)
        '        VMR9 = Nothing
        '    End If

        '    If Not BasicVideo Is Nothing Then
        '        Marshal.ReleaseComObject(BasicVideo)
        '        BasicVideo = Nothing
        '    End If

        '    If Not BasicAudio Is Nothing Then
        '        Marshal.ReleaseComObject(BasicAudio)
        '        BasicAudio = Nothing
        '    End If

        '    If Not VMRAspectRatio Is Nothing Then
        '        Marshal.ReleaseComObject(VMRAspectRatio)
        '        VMRAspectRatio = Nothing
        '    End If

        '    If Not VMRFilterConfig Is Nothing Then
        '        Marshal.ReleaseComObject(VMRFilterConfig)
        '        VMRFilterConfig = Nothing
        '    End If

        '    If Not VMRMixerControl Is Nothing Then
        '        Marshal.ReleaseComObject(VMRMixerControl)
        '        VMRMixerControl = Nothing
        '    End If

        '    If Not VMRMixerBitmap Is Nothing Then
        '        Marshal.ReleaseComObject(VMRMixerBitmap)
        '        VMRMixerBitmap = Nothing
        '    End If

        '    If Not VMRMonitorConfig Is Nothing Then
        '        Marshal.ReleaseComObject(VMRMonitorConfig)
        '        VMRMonitorConfig = Nothing
        '    End If

        '    If Not KsPropertySet Is Nothing Then
        '        Marshal.ReleaseComObject(KsPropertySet)
        '        KsPropertySet = Nothing
        '    End If

        '    If Not nvVideoAtts Is Nothing Then
        '        Marshal.ReleaseComObject(nvVideoAtts)
        '        nvVideoAtts = Nothing
        '    End If

        '    If Not nvAudioAtts Is Nothing Then
        '        Marshal.ReleaseComObject(nvAudioAtts)
        '        nvAudioAtts = Nothing
        '    End If

        '    If Not VMRDeinterlaceControl Is Nothing Then
        '        Marshal.ReleaseComObject(VMRDeinterlaceControl)
        '        VMRDeinterlaceControl = Nothing
        '    End If

        '    UsingVMR9 = False
        Return True
        'Catch ex As Exception
        '    AddConsoleLine("problem destroying graph: " & ex.Message)
        '    Return False
        'End Try
    End Function

    Public Function GetSampleGrabberPin(ByVal SG As IBaseFilter, ByVal Which As String) As IPin
        Try
            Dim HR As Integer
            Dim PinEnum As IEnumPins
            HR = SG.EnumPins(PinEnum)
            If HR <> 0 Then Marshal.ThrowExceptionForHR(HR)
            Dim cnt As Integer
            Dim Pins() As Integer
            ReDim Pins(0)
            HR = PinEnum.Next(1, Pins, cnt)
            If HR <> 0 Then Marshal.ThrowExceptionForHR(HR)
            Dim ptr As IntPtr
            Dim tPin As IPin
            While HR = 0 And cnt > 0
                ptr = New IntPtr(CInt(Pins(0)))
                'Debug.WriteLine(ptr.ToString)
                Dim obj As Object = Marshal.GetObjectForIUnknown(ptr)
                tPin = CType(obj, IPin)
                Dim PinID As String
                HR = tPin.QueryId(PinID)
                If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
                Debug.WriteLine(PinID)
                If PinID.ToLower = Which.ToLower Then
                    Return tPin
                End If
                HR = PinEnum.Next(1, Pins, cnt)
            End While
        Catch ex As Exception
            AddConsoleLine("problem getting sample grabber pin. error: " & ex.Message)
        End Try
    End Function

    Public Sub GetIMixerPinConfig(ByVal OM As IBaseFilter)
        Dim HR As Integer
        Dim PinEnum As IEnumPins
        HR = OM.EnumPins(PinEnum)
        If HR <> 0 Then Marshal.ThrowExceptionForHR(HR)
        Dim cnt As Integer
        Dim Pins() As Integer
        ReDim Pins(0)
        HR = PinEnum.Next(1, Pins, cnt)
        If HR <> 0 Then Marshal.ThrowExceptionForHR(HR)
        Dim ptr As IntPtr
        Dim tPin As IPin
        While HR = 0 And cnt > 0
            ptr = New IntPtr(CInt(Pins(0)))
            'Debug.WriteLine(ptr.ToString)
            'Dim obj As Object = Marshal.PtrToStructure(ptr, System.Type.GetTypeFromCLSID(New Guid("56a86891-0ad4-11ce-b03a-0020af0ba770")))
            Dim obj As Object = Marshal.GetObjectForIUnknown(ptr)
            tPin = CType(obj, IPin)
            Dim PinID As String
            HR = tPin.QueryId(PinID)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            'Debug.WriteLine(PinID)
            If PinID = "Input0" Then
                PinConfig = CType(tPin, IMixerPinConfig)
                Dim i As IntPtr
                Dim HRi As Integer
                Try
                    PinConfig.GetAspectRatioMode(i)
                    'Debug.WriteLine("ammode: " & i.ToString)

                    PinConfig.SetAspectRatioMode(AM_ASPECT_RATIO_MODE.AM_ARMODE_STRETCHED)
                    PinConfig.GetAspectRatioMode(i)
                    Debug.WriteLine("ammode: " & i.ToString)

                Catch ex As Exception
                    AddConsoleLine("problem with pin config. error: " & ex.Message)
                End Try
                Exit Sub
            End If
            HR = PinEnum.Next(1, Pins, cnt)
        End While
        'PinConfig = CType(OverlayMixer, IMixerPinConfig2)
    End Sub

    Public Function CountGraphFilters(ByVal G As IGraphBuilder) As Short
        Try
            Dim en As IEnumFilters
            Dim HR As Integer = G.EnumFilters(en)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            Dim C As Short = 0
            Dim cnt As Integer
            Dim Filters() As Integer
            ReDim Filters(0)
            HR = en.Next(1, Filters, cnt)
            If HR <> 0 Then Marshal.ThrowExceptionForHR(HR)
            While HR = 0 And cnt > 0
                C += 1
                HR = en.Next(1, Filters, cnt)
            End While
            Return C
        Catch ex As Exception
            AddConsoleLine("Problem counting filters in graph. error: " & ex.Message)
        End Try
    End Function

    Public Sub RemoveAllFiltersFromGraph(ByVal G As IGraphBuilder)
        Try
            MediaCtrl.Stop()
            Dim HR As Integer
            Dim En As IEnumFilters
            HR = G.EnumFilters(En)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            Dim cnt As Integer
            Dim Filters() As Integer
            Dim NoFilters As Short = CountGraphFilters(G)
            ReDim Filters(NoFilters - 1)
            HR = En.Next(NoFilters, Filters, cnt)
            If HR <> 0 Then Marshal.ThrowExceptionForHR(HR)
            Dim ptr As IntPtr
            Dim tFilter As IBaseFilter
            For Each Pointer As Integer In Filters
                ptr = New IntPtr(Pointer)
                Dim obj As Object = Marshal.GetObjectForIUnknown(ptr)
                tFilter = CType(obj, IBaseFilter)
                HR = G.RemoveFilter(tFilter)
                If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            Next
        Catch ex As Exception
            AddConsoleLine("problem removing all filters from graph. error: " & ex.Message)
        End Try
    End Sub

    Public Function AddFilterByCLSID(ByVal GB As IGraphBuilder, ByVal Filter_GUID As Guid, ByVal FilterName As String) As Short
        Dim IBaseFilter_GUID As New Guid("56a86895-0ad4-11ce-b03a-0020af0ba770")
        Dim tfFilter As IBaseFilter = CType(DsBugWO.CreateDsInstance(Filter_GUID, IBaseFilter_GUID), IBaseFilter)
        Return GB.AddFilter(tfFilter, FilterName)
    End Function

#Region "VMR9 Related"

#Region "Deinterlacing Mode"

    Public Sub SetupDeinterlacing()
        Try
            'setdeinterlacemode("median filtering")

            'Dim pin As IPin
            'VMR9.FindPin("VMR Input0", pin)
            'Dim MT As New DirectShow.VMR9.AM_MEDIA_TYPE
            'Dim HR As Integer = pin.ConnectionMediaType(MT)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            'Select Case MT.formattype.ToString.ToUpper
            '    Case "05589F80-C356-11CE-BF01-00AA0055595A" 'FORMAT_VideoInfo - must be progressive
            '        'do nothing
            '        'AddConsoleLine("FORMAT_VideoInfo")
            '        Exit Sub
            '    Case "F72A76A0-EB0A-11D0-ACE4-0000C0CC16BA" 'FORMAT_VideoInfo2 - could be interlaced
            '        'AddConsoleLine("FORMAT_VideoInfo2")

            '        Dim VIH2 As DVDMedia.VIDEOINFOHEADER2 = CType(Marshal.PtrToStructure(MT.pbFormat, GetType(DVDMedia.VIDEOINFOHEADER2)), DVDMedia.VIDEOINFOHEADER2)
            '        'MsgBox(VIH2.dwBitRate.ToString)
            '        Dim eInterlace As DVDMedia.AM_INTERLACE = Convert.ToInt32(VIH2.dwInterlaceFlags)

            '        If (eInterlace And DVDMedia.AM_INTERLACE.AMINTERLACE_IsInterlaced) Then
            '            AddConsoleLine("content is interlaced")

            '            Dim VidDesc As New VMR9.VMR9VideoDesc
            '            With VidDesc
            '                .dwSize = Convert.ToUInt32(Marshal.SizeOf(VidDesc))
            '                .dwSampleWidth = Convert.ToUInt32(VIH2.bmiHeader.biWidth)
            '                .dwSampleHeight = Convert.ToUInt32(VIH2.bmiHeader.biHeight)

            '                .SampleFormat = ConvertInterlaceFlags(eInterlace)

            '                .InputSampleFreq.dwNumerator = Convert.ToUInt32(60)
            '                .InputSampleFreq.dwDenominator = Convert.ToUInt32(1)
            '                .OutputFrameFreq.dwDenominator = .InputSampleFreq.dwDenominator
            '                .OutputFrameFreq.dwNumerator = .InputSampleFreq.dwNumerator
            '                .dwFourCC = VIH2.bmiHeader.biCompression

            '            End With


            '            'Dim ModeCount As New Integer
            '            'Dim ModeGUIDs(-1) As Guid

            '            'Dim hModeCount As GCHandle = GCHandle.Alloc(ModeCount, GCHandleType.Pinned)
            '            'Dim pModeCount As IntPtr = hModeCount.AddrOfPinnedObject

            '            'Dim hModeGUIDs As GCHandle = GCHandle.Alloc(ModeGUIDs, GCHandleType.Pinned)
            '            'Dim pModeGUIDs As IntPtr = hModeGUIAddrOfPinnedObject

            '            'Dim hVidDesc As GCHandle = GCHandle.Alloc(VidDesc, GCHandleType.Normal)
            '            'Dim pVidDesc As IntPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf(VidDesc.GetType))
            '            'Marshal.StructureToPtr(VidDesc, pVidDesc, True)

            '            'HR = VMRDeinterlaceControl.GetNumberOfDeinterlaceModes(pVidDesc.ToInt32, pModeCount.ToInt32, pModeGUIToInt32)
            '            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            '            'ReDim ModeGUIDs(ModeCount)
            '            'HR = VMRDeinterlaceControl.GetNumberOfDeinterlaceModes(pVidDesc.ToInt32, pModeCount.ToInt32, pModeGUIToInt32)
            '            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            '            Dim ModeCount As New Integer
            '            Dim ModeGUIDs(-1) As Guid
            '            HR = VMRDeinterlaceControl.GetNumberOfDeinterlaceModes(VidDesc, Convert.ToUInt32(ModeCount), Nothing)
            '            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            '            ReDim ModeGUIDs(ModeCount)
            '            HR = VMRDeinterlaceControl.GetNumberOfDeinterlaceModes(VidDesc, Convert.ToUInt32(ModeCount), ModeGUIDs)
            '            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            '        End If

            '        Exit Sub
            'End Select
        Catch ex As Exception
            AddConsoleLine("Problem setting up deinterlacing. Error: " & ex.Message)
        End Try
    End Sub

    Public Function ConvertInterlaceFlags(ByVal dwInterlaceFlags As Integer) As VMR9_SampleFormat
        Try
            If (dwInterlaceFlags And AM_INTERLACE.AMINTERLACE_IsInterlaced) Then
                If (dwInterlaceFlags And AM_INTERLACE.AMINTERLACE_1FieldPerSample) Then
                    If (dwInterlaceFlags And AM_INTERLACE.AMINTERLACE_Field1First) Then
                        Return VMR9_SampleFormat.VMR9_SampleFieldSingleEven
                    Else
                        Return VMR9_SampleFormat.VMR9_SampleFieldSingleOdd
                    End If
                Else
                    If (dwInterlaceFlags And AM_INTERLACE.AMINTERLACE_Field1First) Then
                        Return VMR9_SampleFormat.VMR9_SampleFieldInterleavedEvenFirst
                    Else
                        Return VMR9_SampleFormat.VMR9_SampleFieldInterleavedOddFirst
                    End If
                End If
            Else
                Return VMR9_SampleFormat.VMR9_SampleProgressiveFrame
            End If
        Catch ex As Exception
            AddConsoleLine("Problem converting interlace flags. Error: " & ex.Message)
        End Try
    End Function

#End Region

#End Region 'VMR9 Related

#Region "nVidia Audio Decoder Related"

    Public Sub InitializeAudioDecoder()
        Try
            If nvAudioAtts Is Nothing Then Exit Sub
            nvAudioAtts.SetLong(nvcommon.EINvidiaAudioDecoderProps.NVAUDDEC_CONFIG, nvcommon.ENvidiaAudioDecoderProps_Config.NVAUDDEC_CONFIG_CONNECTED_DEVICE_PROP_CONTROL, nvcommon.ENvidiaAudioDecoderProps_OutputTo.NVAUDDEC_RECEIVER)
            nvAudioAtts.SetLong(nvcommon.EINvidiaAudioDecoderProps.NVAUDDEC_CONFIG, nvcommon.ENvidiaAudioDecoderProps_Config.NVAUDDEC_CONFIG_ENABLE_SPDIF_PASSTHRU, 1)
            nvAudioAtts.SetLong(nvcommon.EINvidiaAudioDecoderProps.NVAUDDEC_CONFIG, nvcommon.ENvidiaAudioDecoderProps_Config.NVAUDDEC_CONFIG_AC3_OUTPUT_MODE, 2)
            'nvAudioAtts.SetLong(nVidia.DecoderControl.nvcommon.EINvidiaAudioDecoderProps.NVAUDDEC_CONFIG, nVidia.DecoderControl.nvcommon.ENvidiaAudioDecoderProps_Config.NVAUDDEC_CONFIG_SPDIF_PROP_CONTROL, 1)
        Catch ex As Exception
            AddConsoleLine("Problem initializing audio decoder. Error: " & ex.Message)
        End Try
    End Sub

#End Region 'nVidia Audio Decoder Related

#Region "nVidia Video Decoder Related"

    Public Sub InitializeVideoDecoder()
        Try
            If nvVideoAtts Is Nothing Then Exit Sub
            nvVideoAtts.SetLong(nvcommon.ENvVideoDecoderProps.NVVIDDEC_CONFIG, nvcommon.ENvidiaVideoDecoderProps_ConfigTypes.NVVIDDEC_CONFIG_DISABLE_TRAY_ICON, 1)

            'film mode
            nvVideoAtts.SetLong(nvcommon.ENvVideoDecoderProps.NVVIDDEC_CONFIG, nvcommon.ENvidiaVideoDecoderProps_ConfigTypes.NVVIDDEC_CONFIG_DEINTERLACE_CONTROL, nvcommon.ENVVIDDEC_CONFIG_DEINTERLACE_MODE_CTRL.NVVIDDEC_CONFIG_DEINTERLACE_CTRL_FILM)

            'Turn off hardware acceleration
            'nvVideoAtts.SetLong(nVidia.DecoderControl.nvcommon.ENvVideoDecoderProps.NVVIDDEC_CONFIG, nVidia.DecoderControl.nvcommon.ENvidiaVideoDecoderProps_ConfigTypes.NVVIDDEC_CONFIG_ENABLE_DXVA, 0)

            ''Set interlacing to Vertical Stretch
            'nvVideoAtts.SetLong(nVidia.DecoderControl.nvcommon.ENvVideoDecoderProps.NVVIDDEC_CONFIG, nVidia.DecoderControl.nvcommon.ENvidiaVideoDecoderProps_ConfigTypes.NVVIDDEC_CONFIG_VMR_DEINTERLACE_TECHNOLOGY, 2)
            'nvVideoAtts.SetLong(nVidia.DecoderControl.nvcommon.ENvVideoDecoderProps.NVVIDDEC_CONFIG, nVidia.DecoderControl.nvcommon.ENvidiaVideoDecoderProps_ConfigTypes.NVVIDDEC_CONFIG_DEINTERLACE_MODE, nVidia.DecoderControl.nvcommon.ENVVIDDEC_CONFIG_DEINTERLACE_MODE.NVVIDDEC_CONFIG_DEINTERLACE_SPECIFIC_VMR)
            'nvVideoAtts.SetLong(nVidia.DecoderControl.nvcommon.ENvVideoDecoderProps.NVVIDDEC_CONTROL, nVidia.DecoderControl.nvcommon.ENvidiaVideoDecoderProps_ControlTypes.NVVIDDEC_CONTROL_SEND_USER_EVENT, 100)

        Catch ex As Exception
            AddConsoleLine("Problem initializing video decoder. Error: " & ex.Message)
        End Try
    End Sub

#End Region 'nVidia Video Decoder Related

#Region "ROT Management"

    Public Sub AddGraphToROT(ByVal GB As IGraphBuilder)
        Try
            Dim ROTID As String = Microsoft.VisualBasic.Right(DateTime.Now.Ticks.ToString, 7)
            DsROT.AddGraphToRot(GB, ROTID)
            If ROTEntries Is Nothing Then ReDim ROTEntries(-1)
            ReDim Preserve ROTEntries(UBound(ROTEntries) + 1)
            ROTEntries(UBound(ROTEntries)) = ROTID
        Catch ex As Exception
            AddConsoleLine("Problem adding entry to ROT. Error: " & ex.Message)
        End Try
    End Sub

    Public Sub CleanUpROT()
        Try
            For Each ROTID As String In ROTEntries
                DsROT.RemoveGraphFromRot(ROTID)
            Next
            ReDim ROTEntries(-1)
        Catch ex As Exception
            AddConsoleLine("Problem removing entry from ROT. Error: " & ex.Message)
        End Try
    End Sub

    Public ROTEntries() As String

#End Region 'ROT Management

#Region "Enumerators"

    Public Function EnumeratePreferedMediaTypes(ByVal P As IPin) As Boolean
        Try
            Dim MTEnum As IEnumMediaTypes
            Dim HR As Integer
            HR = P.EnumMediaTypes(MTEnum)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            Dim MTsPtrs(0) As Integer
            Dim cnt As Integer
            HR = MTEnum.Next(1, MTsPtrs, cnt)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            Dim ptr As IntPtr
            Dim tMT As AM_MEDIA_TYPE
            ReDim MTs(-1)
            Dim VIH2 As VIDEOINFOHEADER2
            Dim VIH As VIDEOINFOHEADER
            Dim BMI As BITMAPINFOHEADER
            While HR = 0 And cnt > 0
                ptr = New IntPtr(CInt(MTsPtrs(0)))
                Dim obj As Object = Marshal.PtrToStructure(ptr, GetType(AM_MEDIA_TYPE))
                'Dim obj As Object = Marshal.GetObjectForIUnknown(ptr)
                tMT = CType(obj, AM_MEDIA_TYPE)
                ReDim Preserve MTs(UBound(MTs) + 1)
                MTs(UBound(MTs)) = tMT
                'VIH2 = CType(Marshal.PtrToStructure(tMT.formatPtr, GetType(DVDMedia.VIDEOINFOHEADER2)), DVDMedia.VIDEOINFOHEADER2)
                'VIH = GetVIH(tMT)
                HR = MTEnum.Next(1, MTsPtrs, cnt)
            End While
            Return True
        Catch ex As Exception
            MsgBox("Problem with EnumeratePreferedMediaTypes. Error: " & ex.Message)
            Return False
        End Try
    End Function

    'Public Sub EnumerateFilters(ByVal FG As IGraphBuilder)
    '    Try
    '        Dim FEnum As IEnumFilters
    '        Dim HR As Integer
    '        HR = FG.EnumFilters(FEnum)
    '        If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
    '        Dim Filters(0) As Integer
    '        Dim Cnt As Integer
    '        HR = FEnum.Next(1, Filters, Cnt)
    '        If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
    '        Dim ptr As IntPtr
    '        Dim tFilter As IBaseFilter
    '        Dim FInfo As FilterInfo
    '        Dim HR1 As Integer
    '        Dim tInt As Integer
    '        Dim tType As Type
    '        Dim tStr As String
    '        While HR = 0 And Cnt > 0
    '            ptr = New IntPtr(CInt(Filters(0)))
    '            'Debug.WriteLine(ptr.ToString)
    '            Dim obj As Object = Marshal.GetObjectForIUnknown(ptr)
    '            tFilter = CType(obj, IBaseFilter)

    '            'tStr = ""
    '            'HR1 = tFilter.QueryVendorInfo(tStr)
    '            'If HR1 < 0 Then Marshal.ThrowExceptionForHR(HR)
    '            'Debug.WriteLine(tStr)

    '            HR1 = tFilter.QueryFilterInfo(tInt)
    '            If HR1 < 0 Then Marshal.ThrowExceptionForHR(HR)
    '            ptr = New IntPtr(tInt)
    '            tType = GetType(FilterInfo)
    '            obj = Marshal.PtrToStructure(ptr, tType)
    '            FInfo = CType(obj, FilterInfo)
    '            Debug.WriteLine(FInfo.achName)

    '            'Dim PinID As String
    '            'HR = tPin.QueryId(PinID)
    '            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
    '            'Debug.WriteLine(PinID)
    '            'HR = PinEnum.Next(1, Pins, Cnt)

    '        End While
    '    Catch ex As Exception
    '        AddConsoleLine("Problem enumerating filters. Error: " & ex.Message)
    '    End Try
    'End Sub

    Public Sub EnumeratePinNames(ByVal Filter As IBaseFilter)
        Try
            Dim HR As Integer
            Dim PinEnum As IEnumPins
            HR = Filter.EnumPins(PinEnum)
            If HR <> 0 Then Marshal.ThrowExceptionForHR(HR)
            Dim cnt As Integer
            Dim Pins() As Integer
            ReDim Pins(0)
            HR = PinEnum.Next(1, Pins, cnt)
            If HR <> 0 Then Marshal.ThrowExceptionForHR(HR)
            Dim ptr As IntPtr
            Dim tPin As IPin
            While HR = 0 And cnt > 0
                ptr = New IntPtr(CInt(Pins(0)))
                Debug.WriteLine(ptr.ToString)
                Dim obj As Object = Marshal.GetObjectForIUnknown(ptr)
                tPin = CType(obj, IPin)
                Dim PinID As String
                HR = tPin.QueryId(PinID)
                If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
                Debug.WriteLine(PinID)
                Me.AddLine(PinID)
                HR = PinEnum.Next(1, Pins, cnt)
            End While
        Catch ex As Exception
            AddConsoleLine("problem getting sample grabber pin. error: " & ex.Message)
        End Try
    End Sub

#End Region 'Enumerators

#Region "Globals"
    Public WM_APP As Integer = &H8000
    Public WM_GRAPHNOTIFY As Integer = WM_APP + 1   ' Private message.
    Public WM_DVD_EVENT As Integer = &H8002 ' message from dvd graph
    Public WM_USER As Integer = &H400
    Public WS_CHILD As Integer = &H40000000 ' attributes for video window
    Public WS_CLIPCHILDREN As Integer = &H2000000
    Public WS_CLIPSIBLINGS As Integer = &H4000000
#End Region 'Globals

#Region "Filters, Interfaces, Etc."

    'Base Filters
    Public DVDNavigator As IBaseFilter
    Public AudioDecoder As IBaseFilter
    Public VSDecoder As IBaseFilter
    Public Line21Decoder As IBaseFilter
    Public OverlayMixer As IBaseFilter
    Public VideoRenderer As IBaseFilter
    Public AudioRenderer As IBaseFilter
    Public VMR9 As IBaseFilter
    Public UYVYAP As IBaseFilter
    Public ElecardDecoder As IBaseFilter
    Public CSF As IBaseFilter
    Public CSF_VMR As IBaseFilter

    'Interfaces
    Public GraphBuilder As IGraphBuilder
    Public DVDCtrl As IDvdControl2
    Public DVDInfo As IDvdInfo2
    Public VideoWin As IVideoWindow
    Public MediaCtrl As IMediaControl
    Public MediaEvt As IMediaEventEx
    Public Graph_IMF As IMediaFilter
    Public VideoStep As IVideoFrameStep
    Public Line21 As IAMLine21Decoder
    Public PinConfig As IMixerPinConfig
    Public ISampGrab As ISampleGrabber
    Public VMRFilterConfig As IVMRFilterConfig9
    Public VMRAspectRatio As IVMRAspectRatioControl9
    Public VMRMixerBitmap As IVMRMixerBitmap9
    Public VMRMixerControl As IVMRMixerControl9
    Public VMRMonitorConfig As IVMRMonitorConfig9
    Public BasicVideo As IBasicVideo2
    Public VMRWindowlessControl As IVMRWindowlessControl9
    Public KsPropertySet As IKsPropertySet
    Public BasicAudio As IBasicAudio
    Public MediaFltr As IMediaFilter
    Public RefClock As IReferenceClock
    Public VMRWindowless As IVMRWindowlessControl9
    Public nvVideoAtts As NvSharedLib.INvAttributes
    Public nvAudioAtts As NvSharedLib.INvAttributes
    Public VMRDeinterlaceControl As IVMRDeinterlaceControl9

    'Property Pages
    Public DVDNavigator_PP As ISpecifyPropertyPages
    Public AudioDecoder_PP As ISpecifyPropertyPages
    Public VideoDecoder_PP As ISpecifyPropertyPages
    Public Line21Decoder_PP As ISpecifyPropertyPages
    Public OverlayMixer_PP As ISpecifyPropertyPages
    Public VideoRenderer_PP As ISpecifyPropertyPages
    Public AudioRenderer_PP As ISpecifyPropertyPages

    'Pins
    Public DVDNav_AudPin As IPin
    Public DVDNav_SubPin As IPin
    Public DVDNav_VidPin As IPin
    Public AudDec_InPin As IPin
    Public VidDec_VidInPin As IPin
    Public VidDec_SubInPin As IPin
    Public VidDec_CC_Out As IPin
    Public VidDec_SP_Out As IPin
    Public VidDec_Vid_Out As IPin

    'Constants
    Public Shared ReadOnly IBaseFilter_GUID As Guid = New System.Guid("56a86895-0ad4-11ce-b03a-0020af0ba770")
    Public Shared ReadOnly IGraphBuilder_GUID As Guid = New System.Guid("56a868a9-0ad4-11ce-b03a-0020af0ba770")

    'Misc
    Public UsingVMR9 As Boolean = False

#End Region

    Public Class FullMediaType
        Public AMMT As AM_MEDIA_TYPE
        Public VIH2 As VIDEOINFOHEADER2
        'Public WFX As DVDMedia.WAVEFORMATEX
        Public WFXTN As WAVEFORMATEXTENSIBLE
        Public VIH As VIDEOINFOHEADER

        Public Sub New()
            AMMT = New AM_MEDIA_TYPE
            VIH2 = New VIDEOINFOHEADER2
            VIH = New VIDEOINFOHEADER
            'WFX = New DVDMedia.WAVEFORMATEX
        End Sub

    End Class

    Public Function GetPinMediaType(ByVal Pin As IPin) As FullMediaType
        Try
            Dim Out As New FullMediaType
            Dim hr As Integer = Pin.ConnectionMediaType(Out.AMMT)
            If hr < 0 Then Marshal.ThrowExceptionForHR(hr)

            Out.VIH2 = GetVIH2(Out.AMMT)
            Out.VIH = GetVIH(Out.AMMT)

            Dim b(Convert.ToInt32(Out.AMMT.cbFormat) - 1) As Byte
            For i As Integer = 0 To UBound(b)
                b(i) = Marshal.ReadByte(Out.AMMT.pbFormat, i)
            Next
            'Out.WFX = GetWaveFormatEx(b)
            Out.WFXTN = Me.GetWaveFormatExten(b)
            'Out.WFX = CType(Marshal.PtrToStructure(Out.AMMT.pbFormat, GetType(DVDMedia.WAVEFORMATEX)), DVDMedia.WAVEFORMATEX)
            Return Out
        Catch ex As Exception
            MsgBox("Problem with GetPinMediaType. Error: " & ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GetVIH2(ByVal AMMT As AM_MEDIA_TYPE) As VIDEOINFOHEADER2
        Try
            Dim b(Convert.ToInt32(AMMT.cbFormat) - 1) As Byte
            For i As Integer = 0 To UBound(b)
                b(i) = Marshal.ReadByte(AMMT.pbFormat, i)
            Next

            Dim VIH2 As New VIDEOINFOHEADER2
            Dim R As DsRECT
            R.Bottom = CInt("&h" & GetByte(b(13)) & GetByte(b(12)))
            R.Right = CInt("&h" & GetByte(b(9)) & GetByte(b(8)))
            R.Top = 0
            R.Left = 0
            VIH2.rcSource = R
            VIH2.rcTarget = R
            VIH2.dwBitRate = CInt("&h" & GetByte(b(35)) & GetByte(b(34)) & GetByte(b(33)) & GetByte(b(32)))
            VIH2.dwBitErrorRate = CInt("&h" & GetByte(b(39)) & GetByte(b(38)) & GetByte(b(37)) & GetByte(b(36)))
            VIH2.AvgTimePerFrame = CInt("&h" & GetByte(b(47)) & GetByte(b(46)) & GetByte(b(45)) & GetByte(b(44)) & GetByte(b(43)) & GetByte(b(42)) & GetByte(b(41)) & GetByte(b(40)))
            VIH2.dwInterlaceFlags = CInt("&h" & GetByte(b(51)) & GetByte(b(50)) & GetByte(b(49)) & GetByte(b(48)))
            VIH2.dwCopyProtectFlags = CInt("&h" & GetByte(b(55)) & GetByte(b(54)) & GetByte(b(53)) & GetByte(b(52)))
            VIH2.dwPictAspectRatioX = CInt("&h" & GetByte(b(59)) & GetByte(b(58)) & GetByte(b(57)) & GetByte(b(56)))
            VIH2.dwPictAspectRatioY = CInt("&h" & GetByte(b(63)) & GetByte(b(62)) & GetByte(b(61)) & GetByte(b(60)))
            VIH2.dwControlFlags = CInt("&h" & GetByte(b(67)) & GetByte(b(66)) & GetByte(b(65)) & GetByte(b(64)))
            VIH2.dwReserved2 = CInt("&h" & GetByte(b(71)) & GetByte(b(70)) & GetByte(b(69)) & GetByte(b(68)))
            VIH2.bmiHeader = GetBMI(b, False, True)
            Return VIH2
        Catch ex As Exception
            MsgBox("Problem getting VIH2. Error: " & ex.Message)
        End Try
    End Function

    Public Function GetVIH(ByVal AMMT As AM_MEDIA_TYPE) As VIDEOINFOHEADER
        Try
            Dim VIH As New VIDEOINFOHEADER
            Dim b(Convert.ToInt32(AMMT.cbFormat) - 1) As Byte
            For i As Integer = 0 To UBound(b)
                b(i) = Marshal.ReadByte(AMMT.pbFormat, i)
            Next

            VIH.AvgTimePerFrame = CInt("&h" & GetByte(b(23)) & GetByte(b(22)) & GetByte(b(21)) & GetByte(b(20)))
            VIH.BitRate = CInt("&h" & GetByte(b(35)) & GetByte(b(34)) & GetByte(b(33)) & GetByte(b(32)))
            VIH.BitErrorRate = CInt("&h" & GetByte(b(39)) & GetByte(b(38)) & GetByte(b(37)) & GetByte(b(36)))
            VIH.AvgTimePerFrame = CInt("&h" & GetByte(b(47)) & GetByte(b(46)) & GetByte(b(45)) & GetByte(b(44)) & GetByte(b(43)) & GetByte(b(42)) & GetByte(b(41)) & GetByte(b(40)))

            Dim R As New DsRECT
            R.Bottom = CInt("&h" & GetByte(b(13)) & GetByte(b(12)))
            R.Right = CInt("&h" & GetByte(b(9)) & GetByte(b(8)))
            R.Top = 0
            R.Left = 0
            VIH.SrcRect = R
            VIH.TagRect = R

            Dim bmiPointer As Integer
            VIH.BmiHeader = GetBMI(b, True, False)

            Return VIH
        Catch ex As Exception
            MsgBox("Problem getting VIH. Error: " & ex.Message)
        End Try
    End Function

    Public Function GetBMI(ByVal b() As Byte, ByVal ForVIH As Boolean, ByVal ForVIH2 As Boolean) As BITMAPINFOHEADER
        Try
            Dim OS As Short
            If ForVIH Then
                OS = 48
            End If
            If ForVIH2 Then
                OS = 72
            End If

            ''debugging
            'OS = 0
            ''debugging

            Dim BMI As BITMAPINFOHEADER
            BMI.biSize = CInt("&h" & GetByte(b(OS + 3)) & GetByte(b(OS + 2)) & GetByte(b(OS + 1)) & GetByte(b(OS)))
            BMI.biWidth = CInt("&h" & GetByte(b(OS + 7)) & GetByte(b(OS + 6)) & GetByte(b(OS + 5)) & GetByte(b(OS + 4)))
            BMI.biHeight = CInt("&h" & GetByte(b(OS + 11)) & GetByte(b(OS + 10)) & GetByte(b(OS + 9)) & GetByte(b(OS + 8)))
            BMI.biPlanes = CInt("&h" & GetByte(b(OS + 13)) & GetByte(b(OS + 12)))
            BMI.biBitCount = CInt("&h" & GetByte(b(OS + 15)) & GetByte(b(OS + 14)))
            BMI.biCompression = CInt("&h" & GetByte(b(OS + 19)) & GetByte(b(OS + 18)) & GetByte(b(OS + 17)) & GetByte(b(OS + 16)))
            BMI.biSizeImage = CInt("&h" & GetByte(b(OS + 23)) & GetByte(b(OS + 22)) & GetByte(b(OS + 21)) & GetByte(b(OS + 20)))
            BMI.biXPelsPerMeter = CInt("&h" & GetByte(b(OS + 27)) & GetByte(b(OS + 26)) & GetByte(b(OS + 25)) & GetByte(b(OS + 24)))
            BMI.biYPelsPerMeter = CInt("&h" & GetByte(b(OS + 31)) & GetByte(b(OS + 30)) & GetByte(b(OS + 29)) & GetByte(b(OS + 28)))
            BMI.biClrUsed = CInt("&h" & GetByte(b(OS + 35)) & GetByte(b(OS + 34)) & GetByte(b(OS + 33)) & GetByte(b(OS + 32)))
            BMI.biClrImportant = CInt("&h" & GetByte(b(OS + 39)) & GetByte(b(OS + 38)) & GetByte(b(OS + 37)) & GetByte(b(OS + 36)))
            Dim CT(UBound(b) - (OS + 40)) As Byte
            Dim cnt As Integer = 0
            For i As Short = OS + 40 To UBound(b)
                CT(cnt) = b(i)
                cnt += 1
            Next

            Dim ColorColl((CT.Length / 4) - 1) As Color
            cnt = 0
            For i As Short = 0 To UBound(CT) Step 4
                ColorColl(cnt) = Color.FromArgb(CInt("&h" & GetByte(CT(i))), CInt("&h" & GetByte(CT(i + 1))), CInt("&h" & GetByte(CT(i + 2))))
                cnt += 1
            Next

            Return BMI
        Catch ex As Exception
            MsgBox("Problem with GetBMI. Error: " & ex.Message)
        End Try
    End Function

    Public Function GetWaveFormatExten(ByVal B() As Byte) As WAVEFORMATEXTENSIBLE
        Try
            Dim Out As New WAVEFORMATEXTENSIBLE
            Out.Format = GetWaveFormatEx(B)
            If B.Length = 18 Then Return Out
            Out.SubFormat = New Guid(GetByte(B(27)) & GetByte(B(26)) & GetByte(B(25)) & GetByte(B(24)) & "-" & GetByte(B(29)) & GetByte(B(28)) & "-" & GetByte(B(31)) & GetByte(B(30)) & "-" & GetByte(B(33)) & GetByte(B(32)) & "-" & GetByte(B(34)) & GetByte(B(35)) & GetByte(B(36)) & GetByte(B(37)) & GetByte(B(38)) & GetByte(B(39)))
            Out.dwChannelMask = CInt("&h" & GetByte(B(23)) & GetByte(B(22)) & GetByte(B(21)) & GetByte(B(20))) 'This may be key.  Figure out which bytes are the channel mask.
            Out.wValidBitsPerSample = CInt("&h" & GetByte(B(19)) & GetByte(B(18)))
            Out.wReserved = 0
            Out.wSamplesPerBlock = 0
            Return Out
        Catch ex As Exception
            MsgBox("problem getting waveformat ex. error: " & ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GetWaveFormatEx(ByVal B() As Byte) As WAVEFORMATEX
        Try
            Dim Out As New WAVEFORMATEX
            Out.wFormatTag = CInt("&h" & GetByte(B(1)) & GetByte(B(0)))
            Out.nChannels = CInt("&h" & GetByte(B(3)) & GetByte(B(2)))
            Out.nSamplesPerSec = CInt("&h" & GetByte(B(7)) & GetByte(B(6)) & GetByte(B(5)) & GetByte(B(4)))
            Out.nAvgBytesPerSec = CInt("&h" & GetByte(B(11)) & GetByte(B(10)) & GetByte(B(9)) & GetByte(B(8)))
            Out.nBlockAlign = CInt("&h" & GetByte(B(13)) & GetByte(B(12)))
            Out.wBitsPerSample = CInt("&h" & GetByte(B(15)) & GetByte(B(14)))
            Out.cbSize = CInt("&h" & GetByte(B(17)) & GetByte(B(16)))
            Return Out
        Catch ex As Exception
            MsgBox("problem getting waveformat ex. error: " & ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GetByte(ByVal InByte As Byte) As String
        Try
            Dim O As String = Hex(InByte)
            If O.Length = 1 Then O = "0" & O
            Return O
        Catch ex As Exception
            MsgBox("Problem with GetByte. Error: " & ex.Message)
            Return ""
        End Try
    End Function

#End Region 'Filter Graph

    Public Function AddLine(ByVal S As String) As Boolean
        Try
            Me.txtConsole.Text = S & vbNewLine & Me.txtConsole.Text
            Return True
        Catch ex As Exception
            Me.txtConsole.Text = "Problem adding line to console. Error: " & ex.Message & vbNewLine & Me.txtConsole.Text
            Return False
        End Try
    End Function

    Private Sub btnEnumPins_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnumPins.Click
        Try
            Dim f As IBaseFilter
            Dim hr As Integer = GraphBuilder.FindFilterByName(Me.txtFilterName.Text, f)
            If hr < 0 Then Marshal.ThrowExceptionForHR(hr)
            EnumeratePinNames(f)
        Catch ex As Exception
            MsgBox("problem with enum pins btn. error: " & ex.Message)
        End Try
    End Sub

#Region "DVD Controls"

    Public DVDDir As String
    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        Try
            'DVDPlayer.Play()

            'If Not Player Is Nothing Then
            '    Player.Play()
            '    Exit Sub
            'End If

            If Not Graph Is Nothing Then
                Graph.MediaCtrl.Run()
                Exit Sub
            End If

            '    'todo: re-enable this for DVD playbac
            '    DVDDir = "Y:\Media\DVDImages\TWO_TOWERS_NTSC_R1_D2\VIDEO_TS"
            '    If Not DVDDir Is Nothing AndAlso Not DVDDir = "" Then
            '        HR = DVDCtrl.SetDVDDirectory(DVDDir)
            '        If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            '    End If

            If Me.GetMediaControlState = eMediaControlState.Stopped Then
                HR = MediaCtrl.Run
                If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
                'ifAMTC.SendInititalizationSample()
            End If

            '    Dim DM As DvdDomain
            '    HR = DVDInfo.GetCurrentDomain(DM)
            '    If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            '    If DM = DvdDomain.Stop Then
            '        HR = DVDCtrl.PlayForwards(1.0, DvdCmdFlags.Block Or DvdCmdFlags.Flush, New OptIDvdCmd)
            '        If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            '    End If

        Catch ex As Exception
            MsgBox("problem starting graph. error: " & ex.Message)
        End Try
    End Sub

    Public Function GetMediaControlState() As eMediaControlState
        Try
            Dim s As Integer
            HR = MediaCtrl.GetState(4000, s)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            Dim out As eMediaControlState
            Select Case s
                Case 0
                    out = eMediaControlState.Stopped
                Case 1
                    out = eMediaControlState.Paused
                Case 2
                    out = eMediaControlState.Running
            End Select
        Catch ex As Exception
            Me.AddConsoleLine("Problem with GetMediaControlState. Error: " & ex.Message)
        End Try
    End Function

    Private Sub btnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
        Try
            'DVDPlayer.DirectionalBtnHit(DvdRelButton.Upper)
            HR = DVDCtrl.SelectRelativeButton(DvdRelButton.Upper)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRight.Click
        Try
            HR = DVDCtrl.SelectRelativeButton(DvdRelButton.Right)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeft.Click
        Try
            HR = DVDCtrl.SelectRelativeButton(DvdRelButton.Left)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown.Click
        Try
            HR = DVDCtrl.SelectRelativeButton(DvdRelButton.Lower)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        Try
            'HR = DVDPlayer.Graph.DVDCtrl.ActivateButton()
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            HR = DVDCtrl.ActivateButton
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRootMenu_main_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRootMenu_main.Click
        Try
            HR = DVDCtrl.ShowMenu(DvdMenuID.Root, DvdCmdFlags.Flush, New OptIDvdCmd)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnTitleMenu_main_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTitleMenu_main.Click
        Try
            HR = DVDCtrl.ShowMenu(DvdMenuID.Title, DvdCmdFlags.Flush, New OptIDvdCmd)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        Graph.MediaCtrl.Stop()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Try
            HR = DVDCtrl.PlayPrevChapter(DvdCmdFlags.SendEvt, New OptIDvdCmd)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Try
            HR = DVDCtrl.PlayNextChapter(DvdCmdFlags.SendEvt, New OptIDvdCmd)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
        Catch ex As Exception

        End Try
    End Sub

#End Region 'DVD Controls

#Region "Property Pages"

    Public PGs As DsCAUUID

    Private Sub btnPP_VMR9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPP_VMR9.Click
        Try
            VideoRenderer_PP.GetPages(PGs)
            Dim FI As New FilterInfo
            DsUtils.OleCreatePropertyFrame(Me.Handle, 0, 0, FI.achName, 1, Me.VMR9, PGs.cElems, PGs.pElems, 0, 0, Nothing)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPP_MCMpgDmx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPP_MCMpgDmx.Click
        Try
            MCE_DMX_PP.GetPages(PGs)
            Dim FI As New FilterInfo
            DsUtils.OleCreatePropertyFrame(Me.Handle, 0, 0, FI.achName, 1, MCE_DMXA, PGs.cElems, PGs.pElems, 0, 0, Nothing)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnMC_ImgScl_PP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMC_ImgScl_PP.Click
        Try
            Graph.MCE_ImgSiz_PP.GetPages(PGs)
            Dim FI As New FilterInfo
            DsUtils.OleCreatePropertyFrame(Me.Handle, 0, 0, FI.achName, 1, Graph.MCE_ImgSiz, PGs.cElems, PGs.pElems, 0, 0, Nothing)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPP_DVDNav_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPP_DVDNav.Click
        Try
            DVDNavigator_PP.GetPages(PGs)
            Dim FI As New FilterInfo
            DsUtils.OleCreatePropertyFrame(Me.Handle, 0, 0, FI.achName, 1, Me.DVDNavigator, PGs.cElems, PGs.pElems, 0, 0, Nothing)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPP_CSF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPP_CSF.Click

    End Sub

    Private Sub btnPP_AudDec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPP_AudDec.Click
        Try
            Player.Graph.ViewAudioDecoderPropertyPage()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPP_VidDec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPP_VidDec.Click
        Try
            Graph.VideoDecoder_PP.GetPages(PGs)
            Dim FI As New FilterInfo
            DsUtils.OleCreatePropertyFrame(Me.Handle, 0, 0, FI.achName, 1, Graph.VSDecoder, PGs.cElems, PGs.pElems, 0, 0, Nothing)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPP_CSFVMR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPP_CSFVMR.Click
        Try
            CSF_VMR_PP.GetPages(PGs)
            Dim FI As New FilterInfo
            DsUtils.OleCreatePropertyFrame(Me.Handle, 0, 0, FI.achName, 1, Me.CSF_VMR, PGs.cElems, PGs.pElems, 0, 0, Nothing)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPP_AudRen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPP_AudRen.Click
        Try
            AudioRenderer_PP.GetPages(PGs)
            Dim FI As New FilterInfo
            DsUtils.OleCreatePropertyFrame(Me.Handle, 0, 0, FI.achName, 1, Me.AudioRenderer, PGs.cElems, PGs.pElems, 0, 0, Nothing)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPP_VidRen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPP_VidRen.Click
        Try
            MCE_CHG_PP.GetPages(PGs)
            Dim FI As New FilterInfo
            DsUtils.OleCreatePropertyFrame(Me.Handle, 0, 0, FI.achName, 1, Me.MCE_CHG, PGs.cElems, PGs.pElems, 0, 0, Nothing)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnKeystonePP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeystonePP.Click
        Try
            Key_PP.GetPages(PGs)
            Dim FI As New FilterInfo
            DsUtils.OleCreatePropertyFrame(Me.Handle, 0, 0, FI.achName, 1, Me.Keystone, PGs.cElems, PGs.pElems, 0, 0, Nothing)
        Catch ex As Exception

        End Try
    End Sub

#End Region 'Property Pages

    Private Sub btnGraphEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGraphEdit.Click
        System.Diagnostics.Process.Start("C:\program files\graphedit\Graphedt.exe")
    End Sub

    Private Sub btnSelectDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectDir.Click
        Try
            Dim dlg As New OpenFileDialog
            dlg.Filter = "DVD IFOs|*.ifo|DVD VOBs|*.vob"
            dlg.InitialDirectory = "c:\DVDImages"
            dlg.Multiselect = False
            dlg.Title = "Select a VOB or IFO"
            If dlg.ShowDialog = DialogResult.OK Then
                DVDDir = Replace(dlg.FileName.ToLower, "video_ts.ifo", "", 1, -1, CompareMethod.Text)
            Else
                DVDDir = ""
            End If
        Catch ex As Exception
            MsgBox("Problem with select dvd dir. Error: " & ex.Message)
        End Try
    End Sub

    Private CurTime As Long

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        Try
            If RefClock IsNot Nothing Then
                RefClock.GetTime(CurTime)
                If CurTime <> Nothing Then
                    Me.txtMain.Text = CurTime
                    Debug.WriteLine(CurTime)
                End If
            End If


            'Dim i As Integer = 0

            'Dim Handle As GCHandle = GCHandle.Alloc(i, GCHandleType.Pinned)
            'Dim ptr As Integer = Handle.AddrOfPinnedObject.ToInt32

            'HR = IQP.get_AvgFrameRate(ptr)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            'Me.txtFR.Text = i

            'HR = IQP.get_Jitter(ptr)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            'Me.txtJitter.Text = i
        Catch ex As Exception
            Debug.WriteLine("Problem with timer tick. Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnStartTimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartTimer.Click
        Me.Timer.Start()
    End Sub

    Private ClosedCaptionLogFile As FileStream
    Private ClosedCaptionLogWriter As StreamWriter
    Private WithEvents ClosedCaptionProcessing As cLine21Processing
    Private TempClosedCaptionBuffer() As Byte
    Private LogClosedCaptionCurrentRow As Short = 0
    Private ClosedCaptionCurrentLine As String
    Private ClosedCaptionLogging As Boolean = True

    Private Sub GetL21BufferFromL21G()
        Try
            If Not Me.ClosedCaptionLogging Then Exit Sub
            If ClosedCaptionProcessing Is Nothing Then ClosedCaptionProcessing = New cLine21Processing
            Dim SamplePtr As IntPtr
            Dim BufferSize As Integer
            HR = iL21G.GetBuffer(SamplePtr, BufferSize)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            ReDim TempClosedCaptionBuffer(BufferSize - 1)
            Marshal.Copy(SamplePtr, TempClosedCaptionBuffer, 0, BufferSize)

            'DEBUGGING
            If 1 = 1 Then
                Dim out As New StringBuilder()
                For Each BY As Byte In TempClosedCaptionBuffer
                    out.Append(PadString(Hex(BY), 2, "0", True) & " ")
                Next
                Debug.WriteLine("Length=" & BufferSize & " Data=" & out.ToString)
            End If
            'DEBUGGING

            ClosedCaptionProcessing.AddRawL21Data(TempClosedCaptionBuffer)
        Catch ex As Exception
            MsgBox("Problem with GetL21BufferFromL21G. Error: " & ex.Message)
        End Try
    End Sub

    Private Sub HandleNewLine(ByVal Line() As String) Handles ClosedCaptionProcessing.NewL21Line
        'For Each l As String In Line
        '    Debug.WriteLine("L21: " & l)
        'Next
    End Sub

    Public Sub HandleEvent()
        Dim hr, p1, p2 As Integer
        Dim code As DsEvCode
        If MediaEvt Is Nothing Then Exit Sub
        Do
            hr = MediaEvt.GetEvent(code, p1, p2, 0)
            If hr < 0 Then Exit Do
            LocalEventHandler(code, p1, p2)
            If Not MediaEvt Is Nothing Then
                hr = MediaEvt.FreeEventParams(code, p1, p2)
            End If
        Loop While hr = 0
    End Sub

    Private Sub LocalEventHandler(ByVal code As DsEvCode, ByVal p1 As Integer, ByVal p2 As Integer)
        Try
            Select Case code
                'Case DsEvCode.DvdCurrentHmsfTime

                Case DsEvCode.QualityChange
                    Debug.WriteLine("EVENT: QualityChange")

                Case DsEvCode.DisplayChanged
                    Debug.WriteLine("EVENT: Display Changed")

                Case DsEvCode.VMRRenderDeviceSet

                    'Case DsEvCode.DvdChaptStart
                    '    Debug.WriteLine("EVENT: Chapter Start")

                    'Case DsEvCode.DvdTitleChange
                    '    Debug.WriteLine("EVENT: Title Change")

                    'Case DsEvCode.DvdDomChange
                    '    Debug.WriteLine("EVENT: Domain Change")

                    'Case DsEvCode.DvdCmdStart
                    '    Debug.WriteLine("EVENT: DVD Command Start")

                    'Case DsEvCode.DvdCmdEnd
                    '    Debug.WriteLine("EVENT: DVD Command End")

                    'Case DsEvCode.DvdStillOn
                    '    Debug.WriteLine("EVENT: Still On")

                    'Case DsEvCode.DvdStillOff
                    '    Debug.WriteLine("EVENT: Still Off")

                    'Case DsEvCode.DvdButtonChange
                    '    Debug.WriteLine("EVENT: Button Change")

                    'Case DsEvCode.DvdNoFpPgc
                    '    Debug.WriteLine("EVENT: No First Play PGC")

                    'Case DsEvCode.DvdAudioStChange
                    '    Debug.WriteLine("EVENT: Audio Stream Change")

                    'Case DsEvCode.DvdSubPicStChange

                    'Case DsEvCode.DvdAngleChange
                    '    Debug.WriteLine("EVENT: Angle Change")

                    'Case DsEvCode.DvdParentalLChange
                    '    Debug.WriteLine("EVENT: Parental Level Change")

                    'Case DsEvCode.DvdValidUopsChange
                    '    Debug.WriteLine("EVENT: UOPs Change")

                    'Case DsEvCode.DvdError
                    '    Debug.WriteLine("EVENT: DVD Error")

                    'Case DsEvCode.DvdWarning
                    '    Debug.WriteLine("EVENT: DVD Warning")

                    'Case DsEvCode.DvdPlaybStopped
                    '    Debug.WriteLine("EVENT: Playback Stopped")

                Case DsEvCode.StErrStPlaying
                    Debug.WriteLine("EVENT: Stream Error")

                    'Case DsEvCode.DvdButtonAActivated
                    '    Debug.WriteLine("EVENT: Button Activated")

                    'Case DsEvCode.DvdChaptAutoStop
                    '    Debug.WriteLine("EVENT: Chapter Auto Stop")

                    'Case DsEvCode.DvdKaraokeMode
                    '    Debug.WriteLine("EVENT: Karaoke Mode")

                    'Case DsEvCode.DvdPlaybRateChange
                    '    Debug.WriteLine("EVENT: Playback Rate Change")

                    'Case DsEvCode.DvdPeriodtop
                    '    Debug.WriteLine("EVENT: Stop After Play Period")

                Case 88
                    Debug.WriteLine("EVENT: EC_QUALITY_CHANGE_KEYSTONE")

                Case 89
                    Debug.WriteLine("EVENT: EC_KEYSTONE_32")

                Case 97 'EC_KEYSTONE_FIELDORDER
                    Debug.WriteLine("EVENT: EC_KEYSTONE_FIELDORDER")

                Case 14 'EC_PAUSED
                    Debug.WriteLine("EVENT: EC_PAUSED")

                Case 13 'EC_CLOCK_CHANGED
                    Debug.WriteLine("EVENT: EC_CLOCK_CHANGED")

                Case 80 'EC_GRAPH_CHANGED
                    Debug.WriteLine("EVENT: EC_GRAPH_CHANGED")

                Case DsEvCode.VideoSizeChanged
                    Dim i1 As Integer = (p1 >> 16) And &HFFFF
                    Dim i2 As Integer = p1 And &HFFFF
                    Debug.WriteLine("EVENT: Video Size Change - " & i1 & " " & i2)

                Case DsEvCode.UserAbort
                    Debug.WriteLine("EVENT: User Abort")

                Case 1074397284 'EC_L21G  sample available
                    'Debug.WriteLine("EVENT: EC_L21G Sample Available")
                    If p1 > 0 Then
                        GetL21BufferFromL21G()
                    End If

                Case 1074397285 'EC_AMTCBuffer sample available
                    Debug.WriteLine("EVENT: EC_AMTCBuffer sample available")

                Case 96 'Keystone sample times
                    Debug.WriteLine("EVENT: Keystone Sample Times: " & p1 & " - " & p2)

                Case 97 'AMTC sample times
                    Debug.WriteLine("EVENT AMTC Sample Times: " & p1 & " - " & p2)

                Case 98 'EC_KEYSTONE_MPEGTC
                    Debug.WriteLine("EVENT: EC_KEYSTONE_MPEGTC")

                Case 99 'EC_KEYSTONE_INTERLACING			0x63
                    Debug.WriteLine("EVENT: EC_KEYSTONE_INTERLACING: " & p1)

                Case 100 'EC_KEYSTONE_FORCEFRAMEGRAB		0x64
                    Debug.WriteLine("EVENT: EC_KEYSTONE_FORCEFRAMEGRAB")

                Case 3 'EC_ERRORABORT
                    Debug.WriteLine("EVENT: EC_ERRORABORT")

                Case &H110 'EC_DVD_PLAYBACK_RATE_CHANGE
                    Debug.WriteLine("EVENT: EC_DVD_PLAYBACK_RATE_CHANGE. Rate: " & p1)

                Case &H65 'EC_KEYSTONE_PROGRESSIVESEQUENCE
                    Debug.WriteLine("EVENT: EC_KEYSTONE_PROGRESSIVESEQUENCE")

                Case &H8065 'NVVIDDEC_EVENT_PICTURE_FRAGMENT
                    Debug.WriteLine("EVENT: NVVIDDEC_EVENT_PICTURE_FRAGMENT")

                Case &H66 'EC_KEYSTONE_DISCONTINUITY
                    Debug.WriteLine("EVENT: EC_KEYSTONE_DISCONTINUITY")

                Case &H67 'EC_KEYSTONE_MACROVISION
                    If p1 > 0 Then
                        Debug.WriteLine("MACROVISION ENABLED!!!")
                    End If
                    Debug.WriteLine("EVENT: EC_KEYSTONE_MACROVISION_LEVEL: " & p1)

                Case &H8066 'NVVIDDEC_EVENT_MACROVISION_LEVEL
                    Debug.WriteLine("EVENT: NVVIDDEC_EVENT_MACROVISION_LEVEL:" & p1 & " " & p2)
                    'we're getting it from Keystone

                Case 284 'EC_DVD_PROGRAM_CELL_CHANGE
                    Debug.WriteLine("EVENT: EC_DVD_PROGRAM_CELL_CHANGE")

                Case 285 'EC_DVD_TITLE_SET_CHANGE
                    Debug.WriteLine("EVENT: EC_DVD_TITLE_SET_CHANGE: " & p1)

                Case 286 'EC_DVD_PROGRAM_CHAIN_CHANGE
                    Debug.WriteLine("EVENT: EC_DVD_PROGRAM_CHAIN_CHANGE: " & p1)

                Case 105 'EC_Keystone_Omni_FRAMERECEIVED
                    Debug.WriteLine("EC_Keystone_Omni_FRAMERECEIVED")

                Case 512 'EC_Keystone_Omni_FRAMEDROPPED
                    Debug.WriteLine("EC_Keystone_Omni_FRAMEDROPPED")

                Case Else
                    Debug.WriteLine("EVENT: UNKNOWN- " & code & " " & p1 & " " & p2)

            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRW.Click
        Graph.MediaSeek.SetRate(-4.0)
    End Sub

    Private Sub btnFF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFF.Click
        Graph.MediaSeek.SetRate(4.0)
    End Sub

End Class

'SCRAP
'Me.EnumeratePinNames(Me.UYVYAP)
'Exit Sub

'Dim pin As IPin
'Me.VideoRenderer.FindPin("In", pin)
''Me.UYVYAP.FindPin("1", pin)

'If pin Is Nothing Then Throw New Exception("Pin is nothing.")

''If EnumeratePreferedMediaTypes(pin) Then
''    MsgBox("hi")
''End If
''Exit Sub

'Dim MT As New DirectShow.VMR9.AM_MEDIA_TYPE
'Dim HR As Integer = pin.ConnectionMediaType(MT)
'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

'Select Case MT.formattype.ToString.ToUpper
'    Case "05589F80-C356-11CE-BF01-00AA0055595A" 'FORMAT_VideoInfo - must be progressive
'        'VideoInfo
'        Exit Sub

'    Case "F72A76A0-EB0A-11D0-ACE4-0000C0CC16BA" 'FORMAT_VideoInfo2 - could be interlaced
'        'VideoInfo2
'        Dim VIH2 As DVDMedia.VIDEOINFOHEADER2 = CType(Marshal.PtrToStructure(MT.pbFormat, GetType(DVDMedia.VIDEOINFOHEADER2)), DVDMedia.VIDEOINFOHEADER2)
'        Exit Sub

'        Dim eInterlace As DVDMedia.AM_INTERLACE = Convert.ToInt32(VIH2.dwInterlaceFlags)

'        If (eInterlace And DVDMedia.AM_INTERLACE.AMINTERLACE_IsInterlaced) Then
'            AddConsoleLine("content is interlaced")

'            Dim VidDesc As New VMR9.VMR9VideoDesc
'            With VidDesc
'                .dwSize = Convert.ToUInt32(Marshal.SizeOf(VidDesc))
'                .dwSampleWidth = Convert.ToUInt32(VIH2.bmiHeader.biWidth)
'                .dwSampleHeight = Convert.ToUInt32(VIH2.bmiHeader.biHeight)

'                .SampleFormat = ConvertInterlaceFlags(eInterlace)

'                .InputSampleFreq.dwNumerator = Convert.ToUInt32(60)
'                .InputSampleFreq.dwDenominator = Convert.ToUInt32(1)
'                .OutputFrameFreq.dwDenominator = .InputSampleFreq.dwDenominator
'                .OutputFrameFreq.dwNumerator = .InputSampleFreq.dwNumerator
'                .dwFourCC = VIH2.bmiHeader.biCompression

'            End With


'            'Dim ModeCount As New Integer
'            'Dim ModeGUIDs(-1) As Guid

'            'Dim hModeCount As GCHandle = GCHandle.Alloc(ModeCount, GCHandleType.Pinned)
'            'Dim pModeCount As IntPtr = hModeCount.AddrOfPinnedObject

'            'Dim hModeGUIDs As GCHandle = GCHandle.Alloc(ModeGUIDs, GCHandleType.Pinned)
'            'Dim pModeGUIDs As IntPtr = hModeGUIAddrOfPinnedObject

'            'Dim hVidDesc As GCHandle = GCHandle.Alloc(VidDesc, GCHandleType.Normal)
'            'Dim pVidDesc As IntPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf(VidDesc.GetType))
'            'Marshal.StructureToPtr(VidDesc, pVidDesc, True)

'            'HR = VMRDeinterlaceControl.GetNumberOfDeinterlaceModes(pVidDesc.ToInt32, pModeCount.ToInt32, pModeGUIToInt32)
'            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
'            'ReDim ModeGUIDs(ModeCount)
'            'HR = VMRDeinterlaceControl.GetNumberOfDeinterlaceModes(pVidDesc.ToInt32, pModeCount.ToInt32, pModeGUIToInt32)
'            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

'            Dim ModeCount As New Integer
'            Dim ModeGUIDs(-1) As Guid
'            HR = VMRDeinterlaceControl.GetNumberOfDeinterlaceModes(VidDesc, Convert.ToUInt32(ModeCount), Nothing)
'            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
'            ReDim ModeGUIDs(ModeCount)
'            HR = VMRDeinterlaceControl.GetNumberOfDeinterlaceModes(VidDesc, Convert.ToUInt32(ModeCount), ModeGUIDs)
'            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
'        End If

'        Exit Sub
'End Select
'MsgBox("hi")
