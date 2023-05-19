Imports System.Runtime.InteropServices
Imports SMT.Libraries.Common.Media.DVD.IOCTL.cDVDIOCTL
Imports SMT.Libraries.Common.Media.DVD.IOCTL
Imports SMT.Libraries.Common.Media.DVD.IFOProcessing
Imports System.Text
Imports SMT.Libraries.Common.Media.DirectShow.Microsoft_DShow
Imports SMT.Libraries.Common.Media.DirectShow.SMT_DShow.Filters.Keystone
Imports System.IO
Imports SMT.Libraries.Common.Media.DirectShow.nVidia.DecoderControl
Imports SMT.Libraries.Common.Win32

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
    Friend WithEvents MainMenus As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents tcIFO As System.Windows.Forms.TabControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtIOCTL_BCAInfo As System.Windows.Forms.TextBox
    Friend WithEvents txtIOCTL_ManInfo As System.Windows.Forms.TextBox
    Friend WithEvents lblIOCTL_BookVer As System.Windows.Forms.Label
    Friend WithEvents lblIOCTL_RegManInfo As System.Windows.Forms.Label
    Friend WithEvents lblIOCTL_CopySystem As System.Windows.Forms.Label
    Friend WithEvents lblIOCTL_BookType As System.Windows.Forms.Label
    Friend WithEvents lblIOCTL_MinRate As System.Windows.Forms.Label
    Friend WithEvents lblIOCTL_DiscSize As System.Windows.Forms.Label
    Friend WithEvents lblIOCTL_LayerType As System.Windows.Forms.Label
    Friend WithEvents lblIOCTL_TrackPath As System.Windows.Forms.Label
    Friend WithEvents lblIOCTL_NumberOfLayers As System.Windows.Forms.Label
    Friend WithEvents lblIOCTL_TrackDensity As System.Windows.Forms.Label
    Friend WithEvents lblIOCTL_LinearDensity As System.Windows.Forms.Label
    Friend WithEvents lblIOCTL_StartingDataSector As System.Windows.Forms.Label
    Friend WithEvents lblIOCTL_EndDataSector As System.Windows.Forms.Label
    Friend WithEvents lblIOCTL_EndLayerZeroSector As System.Windows.Forms.Label
    Friend WithEvents lblIOCTL_BCAFlag As System.Windows.Forms.Label
    Friend WithEvents pnlReg_8 As System.Windows.Forms.Panel
    Friend WithEvents pnlReg_7 As System.Windows.Forms.Panel
    Friend WithEvents pnlReg_6 As System.Windows.Forms.Panel
    Friend WithEvents pnlReg_5 As System.Windows.Forms.Panel
    Friend WithEvents pnlReg_4 As System.Windows.Forms.Panel
    Friend WithEvents pnlReg_3 As System.Windows.Forms.Panel
    Friend WithEvents pnlReg_2 As System.Windows.Forms.Panel
    Friend WithEvents pnlReg_1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ddlDriveLetter As System.Windows.Forms.ComboBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents tcVMGM As System.Windows.Forms.TabControl
    Friend WithEvents tpVMGMenuSpace As System.Windows.Forms.TabPage
    Friend WithEvents tpVMGGlobalTT As System.Windows.Forms.TabPage
    Friend WithEvents tpVMGPM As System.Windows.Forms.TabPage
    Friend WithEvents tpVMGVTSs As System.Windows.Forms.TabPage
    Friend WithEvents tpVMGTextData As System.Windows.Forms.TabPage
    Friend WithEvents tpVMGVOBs As System.Windows.Forms.TabPage
    Friend WithEvents tpVideoManager As System.Windows.Forms.TabPage
    Friend WithEvents lblVMG_SpecVer As System.Windows.Forms.Label
    Friend WithEvents lblVMG_VolCnt As System.Windows.Forms.Label
    Friend WithEvents lblVMG_VolID As System.Windows.Forms.Label
    Friend WithEvents lblVMG_SideID As System.Windows.Forms.Label
    Friend WithEvents lblVMG_VTSCnt As System.Windows.Forms.Label
    Friend WithEvents lblVMG_ProvID As System.Windows.Forms.Label
    Friend WithEvents pnlVMG_R8 As System.Windows.Forms.Panel
    Friend WithEvents pnlVMG_R7 As System.Windows.Forms.Panel
    Friend WithEvents pnlVMG_R6 As System.Windows.Forms.Panel
    Friend WithEvents pnlVMG_R5 As System.Windows.Forms.Panel
    Friend WithEvents pnlVMG_R4 As System.Windows.Forms.Panel
    Friend WithEvents pnlVMG_R3 As System.Windows.Forms.Panel
    Friend WithEvents pnlVMG_R2 As System.Windows.Forms.Panel
    Friend WithEvents pnlVMG_R1 As System.Windows.Forms.Panel
    Friend WithEvents lblVMG_GlobalTTCount As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents tcVMGVOBs As System.Windows.Forms.TabControl
    Friend WithEvents tpVMGVOBs_Video As System.Windows.Forms.TabPage
    Friend WithEvents tpVMGVOBs_Audio As System.Windows.Forms.TabPage
    Friend WithEvents tpVMGVOBs_Subs As System.Windows.Forms.TabPage
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents lblVMG_AudioCnt As System.Windows.Forms.Label
    Friend WithEvents lblVMG_SubCount As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents nudVMG_GTT As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents lblVMG_GTT_BtnCmd As System.Windows.Forms.Label
    Friend WithEvents lblVMG_GTT_PrePostCmd As System.Windows.Forms.Label
    Friend WithEvents lblVMG_GTT_CellCmd As System.Windows.Forms.Label
    Friend WithEvents lblVMG_GTT_Sequential As System.Windows.Forms.Label
    Friend WithEvents lblVMG_GTT_TimePlaySearch As System.Windows.Forms.Label
    Friend WithEvents lblVMG_GTT_AngCount As System.Windows.Forms.Label
    Friend WithEvents lblVMG_GTT_PTTCnt As System.Windows.Forms.Label
    Friend WithEvents lblVMG_GTT_PMask As System.Windows.Forms.Label
    Friend WithEvents lblVMG_GTT_ParentVTS As System.Windows.Forms.Label
    Friend WithEvents lblVMG_GTT_VTSTT As System.Windows.Forms.Label
    Friend WithEvents lblVMG_GTT_PTTPlaySearch As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents lblVMG_Vid_Compression As System.Windows.Forms.Label
    Friend WithEvents lblVMG_Vid_VidStd As System.Windows.Forms.Label
    Friend WithEvents lblVMG_Vid_AR As System.Windows.Forms.Label
    Friend WithEvents lblVMG_Vid_PanScan As System.Windows.Forms.Label
    Friend WithEvents lblVMG_Vid_Letterbox As System.Windows.Forms.Label
    Friend WithEvents lblVMG_Vid_CCF1 As System.Windows.Forms.Label
    Friend WithEvents lblVMG_Vid_CCF2 As System.Windows.Forms.Label
    Friend WithEvents lblVMG_Vid_Bitrate As System.Windows.Forms.Label
    Friend WithEvents lblVMG_Vid_Resolution As System.Windows.Forms.Label
    Friend WithEvents lblVMG_Vid_Letterboxed As System.Windows.Forms.Label
    Friend WithEvents lblVMG_Vid_FilmMode As System.Windows.Forms.Label
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents lblVMG_Aud_SampRate As System.Windows.Forms.Label
    Friend WithEvents lblVMG_Aud_Quan As System.Windows.Forms.Label
    Friend WithEvents lblVMG_Aud_Compression As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents Label95 As System.Windows.Forms.Label
    Friend WithEvents Label96 As System.Windows.Forms.Label
    Friend WithEvents Label97 As System.Windows.Forms.Label
    Friend WithEvents Label98 As System.Windows.Forms.Label
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents Label100 As System.Windows.Forms.Label
    Friend WithEvents Label101 As System.Windows.Forms.Label
    Friend WithEvents Label102 As System.Windows.Forms.Label
    Friend WithEvents Label103 As System.Windows.Forms.Label
    Friend WithEvents Label104 As System.Windows.Forms.Label
    Friend WithEvents Label105 As System.Windows.Forms.Label
    Friend WithEvents Label106 As System.Windows.Forms.Label
    Friend WithEvents Label107 As System.Windows.Forms.Label
    Friend WithEvents Label108 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents lblVMG_Sub_LangCodeEx As System.Windows.Forms.Label
    Friend WithEvents lblVMG_Sub_Lang As System.Windows.Forms.Label
    Friend WithEvents lblVMG_Sub_Compression As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents lblVMG_Sub_LangSpecified As System.Windows.Forms.Label
    Friend WithEvents tpVTS As System.Windows.Forms.TabPage
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents nudCurrentVTS As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents tpJacketPics As System.Windows.Forms.TabPage
    Friend WithEvents lbJacketPics As System.Windows.Forms.ListBox
    Friend WithEvents tpLayerBreak As System.Windows.Forms.TabPage
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents lblLB_TT As System.Windows.Forms.Label
    Friend WithEvents lblLB_CH As System.Windows.Forms.Label
    Friend WithEvents lblLB_RT As System.Windows.Forms.Label
    Friend WithEvents lblLB_SourceTime As System.Windows.Forms.Label
    Friend WithEvents Label110 As System.Windows.Forms.Label
    Friend WithEvents pnlLikelyLayerbreak As System.Windows.Forms.Panel
    Friend WithEvents Label109 As System.Windows.Forms.Label
    Friend WithEvents Label112 As System.Windows.Forms.Label
    Friend WithEvents Label113 As System.Windows.Forms.Label
    Friend WithEvents Label115 As System.Windows.Forms.Label
    Friend WithEvents Label117 As System.Windows.Forms.Label
    Friend WithEvents pnlLBsMulti As System.Windows.Forms.Panel
    Friend WithEvents lblLB_Multi_ST As System.Windows.Forms.Label
    Friend WithEvents lblLB_Multi_TT As System.Windows.Forms.Label
    Friend WithEvents lblLB_Multi_RT As System.Windows.Forms.Label
    Friend WithEvents lblLB_Multi_CH As System.Windows.Forms.Label
    Friend WithEvents pnlNoCandidateLBs As System.Windows.Forms.Panel
    Friend WithEvents Label126 As System.Windows.Forms.Label
    Friend WithEvents Label119 As System.Windows.Forms.Label
    Friend WithEvents lblLB_Multi_cnt As System.Windows.Forms.Label
    Friend WithEvents Label111 As System.Windows.Forms.Label
    Friend WithEvents nudLBMulti As System.Windows.Forms.NumericUpDown
    Friend WithEvents pnlJP_OneMoment As System.Windows.Forms.Panel
    Friend WithEvents Label114 As System.Windows.Forms.Label
    Friend WithEvents Label116 As System.Windows.Forms.Label
    Friend WithEvents txtDVDPath As System.Windows.Forms.TextBox
    Friend WithEvents rbUseDisc As System.Windows.Forms.RadioButton
    Friend WithEvents rbUsePath As System.Windows.Forms.RadioButton
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents gbIOCTL As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.MainMenus = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.btnRun = New System.Windows.Forms.Button
        Me.gbIOCTL = New System.Windows.Forms.GroupBox
        Me.lblIOCTL_BCAFlag = New System.Windows.Forms.Label
        Me.lblIOCTL_EndLayerZeroSector = New System.Windows.Forms.Label
        Me.lblIOCTL_EndDataSector = New System.Windows.Forms.Label
        Me.lblIOCTL_StartingDataSector = New System.Windows.Forms.Label
        Me.lblIOCTL_LinearDensity = New System.Windows.Forms.Label
        Me.lblIOCTL_TrackDensity = New System.Windows.Forms.Label
        Me.lblIOCTL_NumberOfLayers = New System.Windows.Forms.Label
        Me.lblIOCTL_TrackPath = New System.Windows.Forms.Label
        Me.lblIOCTL_LayerType = New System.Windows.Forms.Label
        Me.lblIOCTL_DiscSize = New System.Windows.Forms.Label
        Me.lblIOCTL_MinRate = New System.Windows.Forms.Label
        Me.lblIOCTL_BookType = New System.Windows.Forms.Label
        Me.lblIOCTL_CopySystem = New System.Windows.Forms.Label
        Me.lblIOCTL_RegManInfo = New System.Windows.Forms.Label
        Me.lblIOCTL_BookVer = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.txtIOCTL_BCAInfo = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtIOCTL_ManInfo = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.pnlReg_8 = New System.Windows.Forms.Panel
        Me.pnlReg_7 = New System.Windows.Forms.Panel
        Me.pnlReg_6 = New System.Windows.Forms.Panel
        Me.pnlReg_5 = New System.Windows.Forms.Panel
        Me.pnlReg_4 = New System.Windows.Forms.Panel
        Me.pnlReg_3 = New System.Windows.Forms.Panel
        Me.pnlReg_2 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnlReg_1 = New System.Windows.Forms.Panel
        Me.tcIFO = New System.Windows.Forms.TabControl
        Me.tpVideoManager = New System.Windows.Forms.TabPage
        Me.tcVMGM = New System.Windows.Forms.TabControl
        Me.tpVMGMenuSpace = New System.Windows.Forms.TabPage
        Me.Button1 = New System.Windows.Forms.Button
        Me.tpVMGGlobalTT = New System.Windows.Forms.TabPage
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label61 = New System.Windows.Forms.Label
        Me.lblVMG_GTT_PTTCnt = New System.Windows.Forms.Label
        Me.Label59 = New System.Windows.Forms.Label
        Me.lblVMG_GTT_AngCount = New System.Windows.Forms.Label
        Me.Label67 = New System.Windows.Forms.Label
        Me.lblVMG_GTT_VTSTT = New System.Windows.Forms.Label
        Me.Label63 = New System.Windows.Forms.Label
        Me.lblVMG_GTT_PMask = New System.Windows.Forms.Label
        Me.Label65 = New System.Windows.Forms.Label
        Me.lblVMG_GTT_ParentVTS = New System.Windows.Forms.Label
        Me.lblVMG_GTT_BtnCmd = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.lblVMG_GTT_PrePostCmd = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.lblVMG_GTT_CellCmd = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.lblVMG_GTT_Sequential = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.lblVMG_GTT_PTTPlaySearch = New System.Windows.Forms.Label
        Me.lblVMG_GTT_TimePlaySearch = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.Label57 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.nudVMG_GTT = New System.Windows.Forms.NumericUpDown
        Me.lblVMG_GlobalTTCount = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.tpVMGVTSs = New System.Windows.Forms.TabPage
        Me.tpVMGPM = New System.Windows.Forms.TabPage
        Me.tpVMGTextData = New System.Windows.Forms.TabPage
        Me.tpVMGVOBs = New System.Windows.Forms.TabPage
        Me.tcVMGVOBs = New System.Windows.Forms.TabControl
        Me.tpVMGVOBs_Video = New System.Windows.Forms.TabPage
        Me.lblVMG_Vid_FilmMode = New System.Windows.Forms.Label
        Me.Label78 = New System.Windows.Forms.Label
        Me.lblVMG_Vid_Letterboxed = New System.Windows.Forms.Label
        Me.Label76 = New System.Windows.Forms.Label
        Me.lblVMG_Vid_Resolution = New System.Windows.Forms.Label
        Me.Label74 = New System.Windows.Forms.Label
        Me.lblVMG_Vid_Bitrate = New System.Windows.Forms.Label
        Me.Label72 = New System.Windows.Forms.Label
        Me.lblVMG_Vid_CCF2 = New System.Windows.Forms.Label
        Me.Label70 = New System.Windows.Forms.Label
        Me.lblVMG_Vid_CCF1 = New System.Windows.Forms.Label
        Me.Label68 = New System.Windows.Forms.Label
        Me.lblVMG_Vid_Letterbox = New System.Windows.Forms.Label
        Me.Label64 = New System.Windows.Forms.Label
        Me.lblVMG_Vid_PanScan = New System.Windows.Forms.Label
        Me.Label60 = New System.Windows.Forms.Label
        Me.lblVMG_Vid_AR = New System.Windows.Forms.Label
        Me.Label56 = New System.Windows.Forms.Label
        Me.lblVMG_Vid_VidStd = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.lblVMG_Vid_Compression = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.tpVMGVOBs_Audio = New System.Windows.Forms.TabPage
        Me.lblVMG_Aud_SampRate = New System.Windows.Forms.Label
        Me.Label79 = New System.Windows.Forms.Label
        Me.lblVMG_Aud_Quan = New System.Windows.Forms.Label
        Me.Label81 = New System.Windows.Forms.Label
        Me.lblVMG_Aud_Compression = New System.Windows.Forms.Label
        Me.Label89 = New System.Windows.Forms.Label
        Me.lblVMG_AudioCnt = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.tpVMGVOBs_Subs = New System.Windows.Forms.TabPage
        Me.lblVMG_Sub_LangSpecified = New System.Windows.Forms.Label
        Me.Label66 = New System.Windows.Forms.Label
        Me.lblVMG_Sub_LangCodeEx = New System.Windows.Forms.Label
        Me.Label58 = New System.Windows.Forms.Label
        Me.lblVMG_Sub_Lang = New System.Windows.Forms.Label
        Me.Label71 = New System.Windows.Forms.Label
        Me.lblVMG_Sub_Compression = New System.Windows.Forms.Label
        Me.Label75 = New System.Windows.Forms.Label
        Me.lblVMG_SubCount = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.lblVMG_ProvID = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.lblVMG_VTSCnt = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.lblVMG_SideID = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.lblVMG_VolID = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.lblVMG_VolCnt = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.pnlVMG_R8 = New System.Windows.Forms.Panel
        Me.pnlVMG_R7 = New System.Windows.Forms.Panel
        Me.pnlVMG_R6 = New System.Windows.Forms.Panel
        Me.pnlVMG_R5 = New System.Windows.Forms.Panel
        Me.pnlVMG_R4 = New System.Windows.Forms.Panel
        Me.pnlVMG_R3 = New System.Windows.Forms.Panel
        Me.pnlVMG_R2 = New System.Windows.Forms.Panel
        Me.Label37 = New System.Windows.Forms.Label
        Me.pnlVMG_R1 = New System.Windows.Forms.Panel
        Me.lblVMG_SpecVer = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.tpJacketPics = New System.Windows.Forms.TabPage
        Me.lbJacketPics = New System.Windows.Forms.ListBox
        Me.pnlJP_OneMoment = New System.Windows.Forms.Panel
        Me.Label114 = New System.Windows.Forms.Label
        Me.tpVTS = New System.Windows.Forms.TabPage
        Me.Label50 = New System.Windows.Forms.Label
        Me.nudCurrentVTS = New System.Windows.Forms.NumericUpDown
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label62 = New System.Windows.Forms.Label
        Me.Label69 = New System.Windows.Forms.Label
        Me.Label77 = New System.Windows.Forms.Label
        Me.Label82 = New System.Windows.Forms.Label
        Me.Label84 = New System.Windows.Forms.Label
        Me.Label86 = New System.Windows.Forms.Label
        Me.Label88 = New System.Windows.Forms.Label
        Me.Label90 = New System.Windows.Forms.Label
        Me.Label91 = New System.Windows.Forms.Label
        Me.Label92 = New System.Windows.Forms.Label
        Me.Label93 = New System.Windows.Forms.Label
        Me.Label94 = New System.Windows.Forms.Label
        Me.Label95 = New System.Windows.Forms.Label
        Me.Label96 = New System.Windows.Forms.Label
        Me.Label97 = New System.Windows.Forms.Label
        Me.Label98 = New System.Windows.Forms.Label
        Me.Label99 = New System.Windows.Forms.Label
        Me.Label100 = New System.Windows.Forms.Label
        Me.Label101 = New System.Windows.Forms.Label
        Me.Label102 = New System.Windows.Forms.Label
        Me.Label103 = New System.Windows.Forms.Label
        Me.Label104 = New System.Windows.Forms.Label
        Me.Label105 = New System.Windows.Forms.Label
        Me.Label106 = New System.Windows.Forms.Label
        Me.Label107 = New System.Windows.Forms.Label
        Me.Label108 = New System.Windows.Forms.Label
        Me.tpLayerBreak = New System.Windows.Forms.TabPage
        Me.pnlLBsMulti = New System.Windows.Forms.Panel
        Me.nudLBMulti = New System.Windows.Forms.NumericUpDown
        Me.Label111 = New System.Windows.Forms.Label
        Me.lblLB_Multi_cnt = New System.Windows.Forms.Label
        Me.Label119 = New System.Windows.Forms.Label
        Me.Label109 = New System.Windows.Forms.Label
        Me.lblLB_Multi_ST = New System.Windows.Forms.Label
        Me.Label112 = New System.Windows.Forms.Label
        Me.Label113 = New System.Windows.Forms.Label
        Me.lblLB_Multi_TT = New System.Windows.Forms.Label
        Me.Label115 = New System.Windows.Forms.Label
        Me.lblLB_Multi_RT = New System.Windows.Forms.Label
        Me.Label117 = New System.Windows.Forms.Label
        Me.lblLB_Multi_CH = New System.Windows.Forms.Label
        Me.pnlNoCandidateLBs = New System.Windows.Forms.Panel
        Me.Label126 = New System.Windows.Forms.Label
        Me.pnlLikelyLayerbreak = New System.Windows.Forms.Panel
        Me.Label110 = New System.Windows.Forms.Label
        Me.lblLB_SourceTime = New System.Windows.Forms.Label
        Me.Label83 = New System.Windows.Forms.Label
        Me.Label87 = New System.Windows.Forms.Label
        Me.lblLB_TT = New System.Windows.Forms.Label
        Me.Label85 = New System.Windows.Forms.Label
        Me.lblLB_RT = New System.Windows.Forms.Label
        Me.Label80 = New System.Windows.Forms.Label
        Me.lblLB_CH = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ddlDriveLetter = New System.Windows.Forms.ComboBox
        Me.Label73 = New System.Windows.Forms.Label
        Me.Label116 = New System.Windows.Forms.Label
        Me.txtDVDPath = New System.Windows.Forms.TextBox
        Me.rbUseDisc = New System.Windows.Forms.RadioButton
        Me.rbUsePath = New System.Windows.Forms.RadioButton
        Me.btnBrowse = New System.Windows.Forms.Button
        Me.gbIOCTL.SuspendLayout()
        Me.tcIFO.SuspendLayout()
        Me.tpVideoManager.SuspendLayout()
        Me.tcVMGM.SuspendLayout()
        Me.tpVMGMenuSpace.SuspendLayout()
        Me.tpVMGGlobalTT.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.nudVMG_GTT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpVMGVOBs.SuspendLayout()
        Me.tcVMGVOBs.SuspendLayout()
        Me.tpVMGVOBs_Video.SuspendLayout()
        Me.tpVMGVOBs_Audio.SuspendLayout()
        Me.tpVMGVOBs_Subs.SuspendLayout()
        Me.tpJacketPics.SuspendLayout()
        Me.pnlJP_OneMoment.SuspendLayout()
        Me.tpVTS.SuspendLayout()
        CType(Me.nudCurrentVTS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpLayerBreak.SuspendLayout()
        Me.pnlLBsMulti.SuspendLayout()
        CType(Me.nudLBMulti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNoCandidateLBs.SuspendLayout()
        Me.pnlLikelyLayerbreak.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenus
        '
        Me.MainMenus.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem5})
        Me.MenuItem1.Text = "File"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 0
        Me.MenuItem5.Text = "Exit"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Edit"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Tools"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "Help"
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(8, 4)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(75, 23)
        Me.btnRun.TabIndex = 0
        Me.btnRun.Text = "Run"
        '
        'gbIOCTL
        '
        Me.gbIOCTL.Controls.Add(Me.lblIOCTL_BCAFlag)
        Me.gbIOCTL.Controls.Add(Me.lblIOCTL_EndLayerZeroSector)
        Me.gbIOCTL.Controls.Add(Me.lblIOCTL_EndDataSector)
        Me.gbIOCTL.Controls.Add(Me.lblIOCTL_StartingDataSector)
        Me.gbIOCTL.Controls.Add(Me.lblIOCTL_LinearDensity)
        Me.gbIOCTL.Controls.Add(Me.lblIOCTL_TrackDensity)
        Me.gbIOCTL.Controls.Add(Me.lblIOCTL_NumberOfLayers)
        Me.gbIOCTL.Controls.Add(Me.lblIOCTL_TrackPath)
        Me.gbIOCTL.Controls.Add(Me.lblIOCTL_LayerType)
        Me.gbIOCTL.Controls.Add(Me.lblIOCTL_DiscSize)
        Me.gbIOCTL.Controls.Add(Me.lblIOCTL_MinRate)
        Me.gbIOCTL.Controls.Add(Me.lblIOCTL_BookType)
        Me.gbIOCTL.Controls.Add(Me.lblIOCTL_CopySystem)
        Me.gbIOCTL.Controls.Add(Me.lblIOCTL_RegManInfo)
        Me.gbIOCTL.Controls.Add(Me.lblIOCTL_BookVer)
        Me.gbIOCTL.Controls.Add(Me.Label26)
        Me.gbIOCTL.Controls.Add(Me.Label25)
        Me.gbIOCTL.Controls.Add(Me.txtIOCTL_BCAInfo)
        Me.gbIOCTL.Controls.Add(Me.Label24)
        Me.gbIOCTL.Controls.Add(Me.Label23)
        Me.gbIOCTL.Controls.Add(Me.Label22)
        Me.gbIOCTL.Controls.Add(Me.Label21)
        Me.gbIOCTL.Controls.Add(Me.Label20)
        Me.gbIOCTL.Controls.Add(Me.Label19)
        Me.gbIOCTL.Controls.Add(Me.Label18)
        Me.gbIOCTL.Controls.Add(Me.Label17)
        Me.gbIOCTL.Controls.Add(Me.Label16)
        Me.gbIOCTL.Controls.Add(Me.Label15)
        Me.gbIOCTL.Controls.Add(Me.Label14)
        Me.gbIOCTL.Controls.Add(Me.Label13)
        Me.gbIOCTL.Controls.Add(Me.Label12)
        Me.gbIOCTL.Controls.Add(Me.Label11)
        Me.gbIOCTL.Controls.Add(Me.Label10)
        Me.gbIOCTL.Controls.Add(Me.txtIOCTL_ManInfo)
        Me.gbIOCTL.Controls.Add(Me.Label9)
        Me.gbIOCTL.Controls.Add(Me.Label8)
        Me.gbIOCTL.Controls.Add(Me.Label7)
        Me.gbIOCTL.Controls.Add(Me.Label6)
        Me.gbIOCTL.Controls.Add(Me.Label5)
        Me.gbIOCTL.Controls.Add(Me.Label4)
        Me.gbIOCTL.Controls.Add(Me.Label3)
        Me.gbIOCTL.Controls.Add(Me.Label2)
        Me.gbIOCTL.Controls.Add(Me.pnlReg_8)
        Me.gbIOCTL.Controls.Add(Me.pnlReg_7)
        Me.gbIOCTL.Controls.Add(Me.pnlReg_6)
        Me.gbIOCTL.Controls.Add(Me.pnlReg_5)
        Me.gbIOCTL.Controls.Add(Me.pnlReg_4)
        Me.gbIOCTL.Controls.Add(Me.pnlReg_3)
        Me.gbIOCTL.Controls.Add(Me.pnlReg_2)
        Me.gbIOCTL.Controls.Add(Me.Label1)
        Me.gbIOCTL.Controls.Add(Me.pnlReg_1)
        Me.gbIOCTL.Location = New System.Drawing.Point(4, 32)
        Me.gbIOCTL.Name = "gbIOCTL"
        Me.gbIOCTL.Size = New System.Drawing.Size(344, 508)
        Me.gbIOCTL.TabIndex = 1
        Me.gbIOCTL.TabStop = False
        Me.gbIOCTL.Text = "Disc Info"
        '
        'lblIOCTL_BCAFlag
        '
        Me.lblIOCTL_BCAFlag.Location = New System.Drawing.Point(116, 384)
        Me.lblIOCTL_BCAFlag.Name = "lblIOCTL_BCAFlag"
        Me.lblIOCTL_BCAFlag.Size = New System.Drawing.Size(224, 16)
        Me.lblIOCTL_BCAFlag.TabIndex = 51
        '
        'lblIOCTL_EndLayerZeroSector
        '
        Me.lblIOCTL_EndLayerZeroSector.Location = New System.Drawing.Point(116, 368)
        Me.lblIOCTL_EndLayerZeroSector.Name = "lblIOCTL_EndLayerZeroSector"
        Me.lblIOCTL_EndLayerZeroSector.Size = New System.Drawing.Size(224, 16)
        Me.lblIOCTL_EndLayerZeroSector.TabIndex = 50
        '
        'lblIOCTL_EndDataSector
        '
        Me.lblIOCTL_EndDataSector.Location = New System.Drawing.Point(116, 352)
        Me.lblIOCTL_EndDataSector.Name = "lblIOCTL_EndDataSector"
        Me.lblIOCTL_EndDataSector.Size = New System.Drawing.Size(224, 16)
        Me.lblIOCTL_EndDataSector.TabIndex = 49
        '
        'lblIOCTL_StartingDataSector
        '
        Me.lblIOCTL_StartingDataSector.Location = New System.Drawing.Point(116, 336)
        Me.lblIOCTL_StartingDataSector.Name = "lblIOCTL_StartingDataSector"
        Me.lblIOCTL_StartingDataSector.Size = New System.Drawing.Size(224, 16)
        Me.lblIOCTL_StartingDataSector.TabIndex = 48
        '
        'lblIOCTL_LinearDensity
        '
        Me.lblIOCTL_LinearDensity.Location = New System.Drawing.Point(116, 320)
        Me.lblIOCTL_LinearDensity.Name = "lblIOCTL_LinearDensity"
        Me.lblIOCTL_LinearDensity.Size = New System.Drawing.Size(224, 16)
        Me.lblIOCTL_LinearDensity.TabIndex = 47
        '
        'lblIOCTL_TrackDensity
        '
        Me.lblIOCTL_TrackDensity.Location = New System.Drawing.Point(116, 304)
        Me.lblIOCTL_TrackDensity.Name = "lblIOCTL_TrackDensity"
        Me.lblIOCTL_TrackDensity.Size = New System.Drawing.Size(224, 16)
        Me.lblIOCTL_TrackDensity.TabIndex = 46
        '
        'lblIOCTL_NumberOfLayers
        '
        Me.lblIOCTL_NumberOfLayers.Location = New System.Drawing.Point(116, 288)
        Me.lblIOCTL_NumberOfLayers.Name = "lblIOCTL_NumberOfLayers"
        Me.lblIOCTL_NumberOfLayers.Size = New System.Drawing.Size(224, 16)
        Me.lblIOCTL_NumberOfLayers.TabIndex = 45
        '
        'lblIOCTL_TrackPath
        '
        Me.lblIOCTL_TrackPath.Location = New System.Drawing.Point(116, 272)
        Me.lblIOCTL_TrackPath.Name = "lblIOCTL_TrackPath"
        Me.lblIOCTL_TrackPath.Size = New System.Drawing.Size(224, 16)
        Me.lblIOCTL_TrackPath.TabIndex = 44
        '
        'lblIOCTL_LayerType
        '
        Me.lblIOCTL_LayerType.Location = New System.Drawing.Point(116, 256)
        Me.lblIOCTL_LayerType.Name = "lblIOCTL_LayerType"
        Me.lblIOCTL_LayerType.Size = New System.Drawing.Size(224, 16)
        Me.lblIOCTL_LayerType.TabIndex = 43
        '
        'lblIOCTL_DiscSize
        '
        Me.lblIOCTL_DiscSize.Location = New System.Drawing.Point(116, 240)
        Me.lblIOCTL_DiscSize.Name = "lblIOCTL_DiscSize"
        Me.lblIOCTL_DiscSize.Size = New System.Drawing.Size(224, 16)
        Me.lblIOCTL_DiscSize.TabIndex = 42
        '
        'lblIOCTL_MinRate
        '
        Me.lblIOCTL_MinRate.Location = New System.Drawing.Point(116, 224)
        Me.lblIOCTL_MinRate.Name = "lblIOCTL_MinRate"
        Me.lblIOCTL_MinRate.Size = New System.Drawing.Size(224, 16)
        Me.lblIOCTL_MinRate.TabIndex = 41
        '
        'lblIOCTL_BookType
        '
        Me.lblIOCTL_BookType.Location = New System.Drawing.Point(116, 208)
        Me.lblIOCTL_BookType.Name = "lblIOCTL_BookType"
        Me.lblIOCTL_BookType.Size = New System.Drawing.Size(224, 16)
        Me.lblIOCTL_BookType.TabIndex = 40
        '
        'lblIOCTL_CopySystem
        '
        Me.lblIOCTL_CopySystem.Location = New System.Drawing.Point(112, 68)
        Me.lblIOCTL_CopySystem.Name = "lblIOCTL_CopySystem"
        Me.lblIOCTL_CopySystem.Size = New System.Drawing.Size(224, 16)
        Me.lblIOCTL_CopySystem.TabIndex = 39
        '
        'lblIOCTL_RegManInfo
        '
        Me.lblIOCTL_RegManInfo.Location = New System.Drawing.Point(112, 52)
        Me.lblIOCTL_RegManInfo.Name = "lblIOCTL_RegManInfo"
        Me.lblIOCTL_RegManInfo.Size = New System.Drawing.Size(224, 16)
        Me.lblIOCTL_RegManInfo.TabIndex = 38
        '
        'lblIOCTL_BookVer
        '
        Me.lblIOCTL_BookVer.Location = New System.Drawing.Point(116, 192)
        Me.lblIOCTL_BookVer.Name = "lblIOCTL_BookVer"
        Me.lblIOCTL_BookVer.Size = New System.Drawing.Size(224, 16)
        Me.lblIOCTL_BookVer.TabIndex = 37
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(4, 68)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(100, 16)
        Me.Label26.TabIndex = 36
        Me.Label26.Text = "CopySystem"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(4, 52)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(100, 16)
        Me.Label25.TabIndex = 35
        Me.Label25.Text = "Reg. Man. Info."
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtIOCTL_BCAInfo
        '
        Me.txtIOCTL_BCAInfo.Location = New System.Drawing.Point(116, 404)
        Me.txtIOCTL_BCAInfo.Multiline = True
        Me.txtIOCTL_BCAInfo.Name = "txtIOCTL_BCAInfo"
        Me.txtIOCTL_BCAInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIOCTL_BCAInfo.Size = New System.Drawing.Size(220, 100)
        Me.txtIOCTL_BCAInfo.TabIndex = 34
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(8, 400)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(100, 16)
        Me.Label24.TabIndex = 33
        Me.Label24.Text = "BCA Information"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(8, 384)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(100, 16)
        Me.Label23.TabIndex = 32
        Me.Label23.Text = "BCAFlag"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(8, 368)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(100, 16)
        Me.Label22.TabIndex = 31
        Me.Label22.Text = "EndLayer0Sector "
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(8, 352)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(100, 16)
        Me.Label21.TabIndex = 30
        Me.Label21.Text = "EndDataSector"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(8, 336)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(100, 16)
        Me.Label20.TabIndex = 29
        Me.Label20.Text = "StartingDataSector"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(8, 320)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(100, 16)
        Me.Label19.TabIndex = 28
        Me.Label19.Text = "LinearDensity"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(8, 304)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(100, 16)
        Me.Label18.TabIndex = 27
        Me.Label18.Text = "TrackDensity"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(8, 288)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 16)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "NumberOfLayers"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(8, 272)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 16)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "TrackPath"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(8, 256)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 16)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "LayerType"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 240)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 16)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "DiscSize"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(8, 224)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 16)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "MaximumRate"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 208)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 16)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "BookType "
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 192)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 16)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "BookVersion"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(4, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 28)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Manufacturing Information"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtIOCTL_ManInfo
        '
        Me.txtIOCTL_ManInfo.Location = New System.Drawing.Point(112, 88)
        Me.txtIOCTL_ManInfo.Multiline = True
        Me.txtIOCTL_ManInfo.Name = "txtIOCTL_ManInfo"
        Me.txtIOCTL_ManInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIOCTL_ManInfo.Size = New System.Drawing.Size(224, 100)
        Me.txtIOCTL_ManInfo.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(252, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 12)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "8"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(232, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 12)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "7"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(212, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 12)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "6"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(192, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 12)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "5"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(172, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 12)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "4"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(152, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 12)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "3"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(132, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 12)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "2"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(112, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 12)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "1"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlReg_8
        '
        Me.pnlReg_8.BackColor = System.Drawing.Color.Red
        Me.pnlReg_8.Location = New System.Drawing.Point(252, 32)
        Me.pnlReg_8.Name = "pnlReg_8"
        Me.pnlReg_8.Size = New System.Drawing.Size(16, 16)
        Me.pnlReg_8.TabIndex = 9
        '
        'pnlReg_7
        '
        Me.pnlReg_7.BackColor = System.Drawing.Color.Red
        Me.pnlReg_7.Location = New System.Drawing.Point(232, 32)
        Me.pnlReg_7.Name = "pnlReg_7"
        Me.pnlReg_7.Size = New System.Drawing.Size(16, 16)
        Me.pnlReg_7.TabIndex = 8
        '
        'pnlReg_6
        '
        Me.pnlReg_6.BackColor = System.Drawing.Color.Red
        Me.pnlReg_6.Location = New System.Drawing.Point(212, 32)
        Me.pnlReg_6.Name = "pnlReg_6"
        Me.pnlReg_6.Size = New System.Drawing.Size(16, 16)
        Me.pnlReg_6.TabIndex = 7
        '
        'pnlReg_5
        '
        Me.pnlReg_5.BackColor = System.Drawing.Color.Red
        Me.pnlReg_5.Location = New System.Drawing.Point(192, 32)
        Me.pnlReg_5.Name = "pnlReg_5"
        Me.pnlReg_5.Size = New System.Drawing.Size(16, 16)
        Me.pnlReg_5.TabIndex = 6
        '
        'pnlReg_4
        '
        Me.pnlReg_4.BackColor = System.Drawing.Color.Red
        Me.pnlReg_4.Location = New System.Drawing.Point(172, 32)
        Me.pnlReg_4.Name = "pnlReg_4"
        Me.pnlReg_4.Size = New System.Drawing.Size(16, 16)
        Me.pnlReg_4.TabIndex = 5
        '
        'pnlReg_3
        '
        Me.pnlReg_3.BackColor = System.Drawing.Color.Red
        Me.pnlReg_3.Location = New System.Drawing.Point(152, 32)
        Me.pnlReg_3.Name = "pnlReg_3"
        Me.pnlReg_3.Size = New System.Drawing.Size(16, 16)
        Me.pnlReg_3.TabIndex = 4
        '
        'pnlReg_2
        '
        Me.pnlReg_2.BackColor = System.Drawing.Color.Red
        Me.pnlReg_2.Location = New System.Drawing.Point(132, 32)
        Me.pnlReg_2.Name = "pnlReg_2"
        Me.pnlReg_2.Size = New System.Drawing.Size(16, 16)
        Me.pnlReg_2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(36, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Region"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pnlReg_1
        '
        Me.pnlReg_1.BackColor = System.Drawing.Color.Red
        Me.pnlReg_1.Location = New System.Drawing.Point(112, 32)
        Me.pnlReg_1.Name = "pnlReg_1"
        Me.pnlReg_1.Size = New System.Drawing.Size(16, 16)
        Me.pnlReg_1.TabIndex = 2
        '
        'tcIFO
        '
        Me.tcIFO.Controls.Add(Me.tpVideoManager)
        Me.tcIFO.Controls.Add(Me.tpJacketPics)
        Me.tcIFO.Controls.Add(Me.tpVTS)
        Me.tcIFO.Controls.Add(Me.tpLayerBreak)
        Me.tcIFO.Location = New System.Drawing.Point(4, 16)
        Me.tcIFO.Name = "tcIFO"
        Me.tcIFO.SelectedIndex = 0
        Me.tcIFO.Size = New System.Drawing.Size(480, 488)
        Me.tcIFO.TabIndex = 0
        '
        'tpVideoManager
        '
        Me.tpVideoManager.Controls.Add(Me.tcVMGM)
        Me.tpVideoManager.Controls.Add(Me.lblVMG_ProvID)
        Me.tpVideoManager.Controls.Add(Me.Label47)
        Me.tpVideoManager.Controls.Add(Me.lblVMG_VTSCnt)
        Me.tpVideoManager.Controls.Add(Me.Label45)
        Me.tpVideoManager.Controls.Add(Me.lblVMG_SideID)
        Me.tpVideoManager.Controls.Add(Me.Label43)
        Me.tpVideoManager.Controls.Add(Me.lblVMG_VolID)
        Me.tpVideoManager.Controls.Add(Me.Label41)
        Me.tpVideoManager.Controls.Add(Me.lblVMG_VolCnt)
        Me.tpVideoManager.Controls.Add(Me.Label39)
        Me.tpVideoManager.Controls.Add(Me.Label29)
        Me.tpVideoManager.Controls.Add(Me.Label30)
        Me.tpVideoManager.Controls.Add(Me.Label31)
        Me.tpVideoManager.Controls.Add(Me.Label32)
        Me.tpVideoManager.Controls.Add(Me.Label33)
        Me.tpVideoManager.Controls.Add(Me.Label34)
        Me.tpVideoManager.Controls.Add(Me.Label35)
        Me.tpVideoManager.Controls.Add(Me.Label36)
        Me.tpVideoManager.Controls.Add(Me.pnlVMG_R8)
        Me.tpVideoManager.Controls.Add(Me.pnlVMG_R7)
        Me.tpVideoManager.Controls.Add(Me.pnlVMG_R6)
        Me.tpVideoManager.Controls.Add(Me.pnlVMG_R5)
        Me.tpVideoManager.Controls.Add(Me.pnlVMG_R4)
        Me.tpVideoManager.Controls.Add(Me.pnlVMG_R3)
        Me.tpVideoManager.Controls.Add(Me.pnlVMG_R2)
        Me.tpVideoManager.Controls.Add(Me.Label37)
        Me.tpVideoManager.Controls.Add(Me.pnlVMG_R1)
        Me.tpVideoManager.Controls.Add(Me.lblVMG_SpecVer)
        Me.tpVideoManager.Controls.Add(Me.Label28)
        Me.tpVideoManager.Location = New System.Drawing.Point(4, 22)
        Me.tpVideoManager.Name = "tpVideoManager"
        Me.tpVideoManager.Size = New System.Drawing.Size(472, 462)
        Me.tpVideoManager.TabIndex = 0
        Me.tpVideoManager.Text = "Video Manager"
        '
        'tcVMGM
        '
        Me.tcVMGM.Controls.Add(Me.tpVMGMenuSpace)
        Me.tcVMGM.Controls.Add(Me.tpVMGGlobalTT)
        Me.tcVMGM.Controls.Add(Me.tpVMGVTSs)
        Me.tcVMGM.Controls.Add(Me.tpVMGPM)
        Me.tcVMGM.Controls.Add(Me.tpVMGTextData)
        Me.tcVMGM.Controls.Add(Me.tpVMGVOBs)
        Me.tcVMGM.Location = New System.Drawing.Point(4, 144)
        Me.tcVMGM.Name = "tcVMGM"
        Me.tcVMGM.SelectedIndex = 0
        Me.tcVMGM.Size = New System.Drawing.Size(468, 316)
        Me.tcVMGM.TabIndex = 68
        '
        'tpVMGMenuSpace
        '
        Me.tpVMGMenuSpace.Controls.Add(Me.Button1)
        Me.tpVMGMenuSpace.Location = New System.Drawing.Point(4, 22)
        Me.tpVMGMenuSpace.Name = "tpVMGMenuSpace"
        Me.tpVMGMenuSpace.Size = New System.Drawing.Size(460, 290)
        Me.tpVMGMenuSpace.TabIndex = 0
        Me.tpVMGMenuSpace.Text = "VMG Menu Space"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tpVMGGlobalTT
        '
        Me.tpVMGGlobalTT.Controls.Add(Me.GroupBox4)
        Me.tpVMGGlobalTT.Controls.Add(Me.Label27)
        Me.tpVMGGlobalTT.Controls.Add(Me.nudVMG_GTT)
        Me.tpVMGGlobalTT.Controls.Add(Me.lblVMG_GlobalTTCount)
        Me.tpVMGGlobalTT.Controls.Add(Me.Label38)
        Me.tpVMGGlobalTT.Location = New System.Drawing.Point(4, 22)
        Me.tpVMGGlobalTT.Name = "tpVMGGlobalTT"
        Me.tpVMGGlobalTT.Size = New System.Drawing.Size(460, 290)
        Me.tpVMGGlobalTT.TabIndex = 1
        Me.tpVMGGlobalTT.Text = "Global Titles"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label61)
        Me.GroupBox4.Controls.Add(Me.lblVMG_GTT_PTTCnt)
        Me.GroupBox4.Controls.Add(Me.Label59)
        Me.GroupBox4.Controls.Add(Me.lblVMG_GTT_AngCount)
        Me.GroupBox4.Controls.Add(Me.Label67)
        Me.GroupBox4.Controls.Add(Me.lblVMG_GTT_VTSTT)
        Me.GroupBox4.Controls.Add(Me.Label63)
        Me.GroupBox4.Controls.Add(Me.lblVMG_GTT_PMask)
        Me.GroupBox4.Controls.Add(Me.Label65)
        Me.GroupBox4.Controls.Add(Me.lblVMG_GTT_ParentVTS)
        Me.GroupBox4.Controls.Add(Me.lblVMG_GTT_BtnCmd)
        Me.GroupBox4.Controls.Add(Me.Label53)
        Me.GroupBox4.Controls.Add(Me.lblVMG_GTT_PrePostCmd)
        Me.GroupBox4.Controls.Add(Me.Label51)
        Me.GroupBox4.Controls.Add(Me.lblVMG_GTT_CellCmd)
        Me.GroupBox4.Controls.Add(Me.Label48)
        Me.GroupBox4.Controls.Add(Me.lblVMG_GTT_Sequential)
        Me.GroupBox4.Controls.Add(Me.Label46)
        Me.GroupBox4.Controls.Add(Me.lblVMG_GTT_PTTPlaySearch)
        Me.GroupBox4.Controls.Add(Me.lblVMG_GTT_TimePlaySearch)
        Me.GroupBox4.Controls.Add(Me.Label55)
        Me.GroupBox4.Controls.Add(Me.Label57)
        Me.GroupBox4.Location = New System.Drawing.Point(4, 44)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(272, 196)
        Me.GroupBox4.TabIndex = 81
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GTT"
        '
        'Label61
        '
        Me.Label61.Location = New System.Drawing.Point(8, 32)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(104, 16)
        Me.Label61.TabIndex = 73
        Me.Label61.Text = "Chapter Count"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVMG_GTT_PTTCnt
        '
        Me.lblVMG_GTT_PTTCnt.Location = New System.Drawing.Point(116, 32)
        Me.lblVMG_GTT_PTTCnt.Name = "lblVMG_GTT_PTTCnt"
        Me.lblVMG_GTT_PTTCnt.Size = New System.Drawing.Size(152, 16)
        Me.lblVMG_GTT_PTTCnt.TabIndex = 74
        '
        'Label59
        '
        Me.Label59.Location = New System.Drawing.Point(8, 16)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(104, 16)
        Me.Label59.TabIndex = 71
        Me.Label59.Text = "Angle Count"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVMG_GTT_AngCount
        '
        Me.lblVMG_GTT_AngCount.Location = New System.Drawing.Point(116, 16)
        Me.lblVMG_GTT_AngCount.Name = "lblVMG_GTT_AngCount"
        Me.lblVMG_GTT_AngCount.Size = New System.Drawing.Size(152, 16)
        Me.lblVMG_GTT_AngCount.TabIndex = 72
        '
        'Label67
        '
        Me.Label67.Location = New System.Drawing.Point(8, 80)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(104, 16)
        Me.Label67.TabIndex = 79
        Me.Label67.Text = "VTS_TT"
        Me.Label67.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVMG_GTT_VTSTT
        '
        Me.lblVMG_GTT_VTSTT.Location = New System.Drawing.Point(116, 80)
        Me.lblVMG_GTT_VTSTT.Name = "lblVMG_GTT_VTSTT"
        Me.lblVMG_GTT_VTSTT.Size = New System.Drawing.Size(152, 16)
        Me.lblVMG_GTT_VTSTT.TabIndex = 80
        '
        'Label63
        '
        Me.Label63.Location = New System.Drawing.Point(8, 48)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(104, 16)
        Me.Label63.TabIndex = 75
        Me.Label63.Text = "Parental Mask"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVMG_GTT_PMask
        '
        Me.lblVMG_GTT_PMask.Location = New System.Drawing.Point(116, 48)
        Me.lblVMG_GTT_PMask.Name = "lblVMG_GTT_PMask"
        Me.lblVMG_GTT_PMask.Size = New System.Drawing.Size(152, 16)
        Me.lblVMG_GTT_PMask.TabIndex = 76
        '
        'Label65
        '
        Me.Label65.Location = New System.Drawing.Point(8, 64)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(104, 16)
        Me.Label65.TabIndex = 77
        Me.Label65.Text = "Parent VTS"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVMG_GTT_ParentVTS
        '
        Me.lblVMG_GTT_ParentVTS.Location = New System.Drawing.Point(116, 64)
        Me.lblVMG_GTT_ParentVTS.Name = "lblVMG_GTT_ParentVTS"
        Me.lblVMG_GTT_ParentVTS.Size = New System.Drawing.Size(152, 16)
        Me.lblVMG_GTT_ParentVTS.TabIndex = 78
        '
        'lblVMG_GTT_BtnCmd
        '
        Me.lblVMG_GTT_BtnCmd.Location = New System.Drawing.Point(116, 144)
        Me.lblVMG_GTT_BtnCmd.Name = "lblVMG_GTT_BtnCmd"
        Me.lblVMG_GTT_BtnCmd.Size = New System.Drawing.Size(152, 16)
        Me.lblVMG_GTT_BtnCmd.TabIndex = 75
        '
        'Label53
        '
        Me.Label53.Location = New System.Drawing.Point(8, 144)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(104, 16)
        Me.Label53.TabIndex = 74
        Me.Label53.Text = "Button Command"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVMG_GTT_PrePostCmd
        '
        Me.lblVMG_GTT_PrePostCmd.Location = New System.Drawing.Point(116, 128)
        Me.lblVMG_GTT_PrePostCmd.Name = "lblVMG_GTT_PrePostCmd"
        Me.lblVMG_GTT_PrePostCmd.Size = New System.Drawing.Size(152, 16)
        Me.lblVMG_GTT_PrePostCmd.TabIndex = 73
        '
        'Label51
        '
        Me.Label51.Location = New System.Drawing.Point(8, 128)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(104, 16)
        Me.Label51.TabIndex = 72
        Me.Label51.Text = "PrePost Command"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVMG_GTT_CellCmd
        '
        Me.lblVMG_GTT_CellCmd.Location = New System.Drawing.Point(116, 112)
        Me.lblVMG_GTT_CellCmd.Name = "lblVMG_GTT_CellCmd"
        Me.lblVMG_GTT_CellCmd.Size = New System.Drawing.Size(152, 16)
        Me.lblVMG_GTT_CellCmd.TabIndex = 71
        '
        'Label48
        '
        Me.Label48.Location = New System.Drawing.Point(8, 112)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(104, 16)
        Me.Label48.TabIndex = 70
        Me.Label48.Text = "Cell Command"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVMG_GTT_Sequential
        '
        Me.lblVMG_GTT_Sequential.Location = New System.Drawing.Point(116, 96)
        Me.lblVMG_GTT_Sequential.Name = "lblVMG_GTT_Sequential"
        Me.lblVMG_GTT_Sequential.Size = New System.Drawing.Size(152, 16)
        Me.lblVMG_GTT_Sequential.TabIndex = 69
        '
        'Label46
        '
        Me.Label46.Location = New System.Drawing.Point(8, 96)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(104, 16)
        Me.Label46.TabIndex = 68
        Me.Label46.Text = "Sequential"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVMG_GTT_PTTPlaySearch
        '
        Me.lblVMG_GTT_PTTPlaySearch.Location = New System.Drawing.Point(116, 160)
        Me.lblVMG_GTT_PTTPlaySearch.Name = "lblVMG_GTT_PTTPlaySearch"
        Me.lblVMG_GTT_PTTPlaySearch.Size = New System.Drawing.Size(152, 16)
        Me.lblVMG_GTT_PTTPlaySearch.TabIndex = 77
        '
        'lblVMG_GTT_TimePlaySearch
        '
        Me.lblVMG_GTT_TimePlaySearch.Location = New System.Drawing.Point(116, 176)
        Me.lblVMG_GTT_TimePlaySearch.Name = "lblVMG_GTT_TimePlaySearch"
        Me.lblVMG_GTT_TimePlaySearch.Size = New System.Drawing.Size(152, 16)
        Me.lblVMG_GTT_TimePlaySearch.TabIndex = 79
        '
        'Label55
        '
        Me.Label55.Location = New System.Drawing.Point(8, 160)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(104, 16)
        Me.Label55.TabIndex = 76
        Me.Label55.Text = "PTT Play/Search"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label57
        '
        Me.Label57.Location = New System.Drawing.Point(8, 176)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(104, 16)
        Me.Label57.TabIndex = 78
        Me.Label57.Text = "Time Play/Search"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(8, 24)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(100, 16)
        Me.Label27.TabIndex = 69
        Me.Label27.Text = "Current Title"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'nudVMG_GTT
        '
        Me.nudVMG_GTT.Location = New System.Drawing.Point(108, 20)
        Me.nudVMG_GTT.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudVMG_GTT.Name = "nudVMG_GTT"
        Me.nudVMG_GTT.Size = New System.Drawing.Size(44, 20)
        Me.nudVMG_GTT.TabIndex = 68
        '
        'lblVMG_GlobalTTCount
        '
        Me.lblVMG_GlobalTTCount.Location = New System.Drawing.Point(112, 4)
        Me.lblVMG_GlobalTTCount.Name = "lblVMG_GlobalTTCount"
        Me.lblVMG_GlobalTTCount.Size = New System.Drawing.Size(224, 16)
        Me.lblVMG_GlobalTTCount.TabIndex = 67
        '
        'Label38
        '
        Me.Label38.Location = New System.Drawing.Point(8, 4)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(104, 16)
        Me.Label38.TabIndex = 66
        Me.Label38.Text = "Global Title Count"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tpVMGVTSs
        '
        Me.tpVMGVTSs.Location = New System.Drawing.Point(4, 22)
        Me.tpVMGVTSs.Name = "tpVMGVTSs"
        Me.tpVMGVTSs.Size = New System.Drawing.Size(460, 290)
        Me.tpVMGVTSs.TabIndex = 3
        Me.tpVMGVTSs.Text = "VTSs"
        '
        'tpVMGPM
        '
        Me.tpVMGPM.Location = New System.Drawing.Point(4, 22)
        Me.tpVMGPM.Name = "tpVMGPM"
        Me.tpVMGPM.Size = New System.Drawing.Size(460, 290)
        Me.tpVMGPM.TabIndex = 2
        Me.tpVMGPM.Text = "Parental Management"
        '
        'tpVMGTextData
        '
        Me.tpVMGTextData.Location = New System.Drawing.Point(4, 22)
        Me.tpVMGTextData.Name = "tpVMGTextData"
        Me.tpVMGTextData.Size = New System.Drawing.Size(460, 290)
        Me.tpVMGTextData.TabIndex = 4
        Me.tpVMGTextData.Text = "Text Data"
        '
        'tpVMGVOBs
        '
        Me.tpVMGVOBs.Controls.Add(Me.tcVMGVOBs)
        Me.tpVMGVOBs.Location = New System.Drawing.Point(4, 22)
        Me.tpVMGVOBs.Name = "tpVMGVOBs"
        Me.tpVMGVOBs.Size = New System.Drawing.Size(460, 290)
        Me.tpVMGVOBs.TabIndex = 5
        Me.tpVMGVOBs.Text = "VMG VOBs"
        '
        'tcVMGVOBs
        '
        Me.tcVMGVOBs.Controls.Add(Me.tpVMGVOBs_Video)
        Me.tcVMGVOBs.Controls.Add(Me.tpVMGVOBs_Audio)
        Me.tcVMGVOBs.Controls.Add(Me.tpVMGVOBs_Subs)
        Me.tcVMGVOBs.Location = New System.Drawing.Point(0, 0)
        Me.tcVMGVOBs.Name = "tcVMGVOBs"
        Me.tcVMGVOBs.SelectedIndex = 0
        Me.tcVMGVOBs.Size = New System.Drawing.Size(456, 288)
        Me.tcVMGVOBs.TabIndex = 0
        '
        'tpVMGVOBs_Video
        '
        Me.tpVMGVOBs_Video.Controls.Add(Me.lblVMG_Vid_FilmMode)
        Me.tpVMGVOBs_Video.Controls.Add(Me.Label78)
        Me.tpVMGVOBs_Video.Controls.Add(Me.lblVMG_Vid_Letterboxed)
        Me.tpVMGVOBs_Video.Controls.Add(Me.Label76)
        Me.tpVMGVOBs_Video.Controls.Add(Me.lblVMG_Vid_Resolution)
        Me.tpVMGVOBs_Video.Controls.Add(Me.Label74)
        Me.tpVMGVOBs_Video.Controls.Add(Me.lblVMG_Vid_Bitrate)
        Me.tpVMGVOBs_Video.Controls.Add(Me.Label72)
        Me.tpVMGVOBs_Video.Controls.Add(Me.lblVMG_Vid_CCF2)
        Me.tpVMGVOBs_Video.Controls.Add(Me.Label70)
        Me.tpVMGVOBs_Video.Controls.Add(Me.lblVMG_Vid_CCF1)
        Me.tpVMGVOBs_Video.Controls.Add(Me.Label68)
        Me.tpVMGVOBs_Video.Controls.Add(Me.lblVMG_Vid_Letterbox)
        Me.tpVMGVOBs_Video.Controls.Add(Me.Label64)
        Me.tpVMGVOBs_Video.Controls.Add(Me.lblVMG_Vid_PanScan)
        Me.tpVMGVOBs_Video.Controls.Add(Me.Label60)
        Me.tpVMGVOBs_Video.Controls.Add(Me.lblVMG_Vid_AR)
        Me.tpVMGVOBs_Video.Controls.Add(Me.Label56)
        Me.tpVMGVOBs_Video.Controls.Add(Me.lblVMG_Vid_VidStd)
        Me.tpVMGVOBs_Video.Controls.Add(Me.Label52)
        Me.tpVMGVOBs_Video.Controls.Add(Me.lblVMG_Vid_Compression)
        Me.tpVMGVOBs_Video.Controls.Add(Me.Label49)
        Me.tpVMGVOBs_Video.Location = New System.Drawing.Point(4, 22)
        Me.tpVMGVOBs_Video.Name = "tpVMGVOBs_Video"
        Me.tpVMGVOBs_Video.Size = New System.Drawing.Size(448, 262)
        Me.tpVMGVOBs_Video.TabIndex = 0
        Me.tpVMGVOBs_Video.Text = "Video"
        '
        'lblVMG_Vid_FilmMode
        '
        Me.lblVMG_Vid_FilmMode.Location = New System.Drawing.Point(108, 164)
        Me.lblVMG_Vid_FilmMode.Name = "lblVMG_Vid_FilmMode"
        Me.lblVMG_Vid_FilmMode.Size = New System.Drawing.Size(224, 16)
        Me.lblVMG_Vid_FilmMode.TabIndex = 91
        '
        'Label78
        '
        Me.Label78.Location = New System.Drawing.Point(4, 164)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(100, 16)
        Me.Label78.TabIndex = 90
        Me.Label78.Text = "Film Mode"
        Me.Label78.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVMG_Vid_Letterboxed
        '
        Me.lblVMG_Vid_Letterboxed.Location = New System.Drawing.Point(108, 148)
        Me.lblVMG_Vid_Letterboxed.Name = "lblVMG_Vid_Letterboxed"
        Me.lblVMG_Vid_Letterboxed.Size = New System.Drawing.Size(224, 16)
        Me.lblVMG_Vid_Letterboxed.TabIndex = 89
        '
        'Label76
        '
        Me.Label76.Location = New System.Drawing.Point(4, 148)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(100, 16)
        Me.Label76.TabIndex = 88
        Me.Label76.Text = "Letterboxed"
        Me.Label76.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVMG_Vid_Resolution
        '
        Me.lblVMG_Vid_Resolution.Location = New System.Drawing.Point(108, 132)
        Me.lblVMG_Vid_Resolution.Name = "lblVMG_Vid_Resolution"
        Me.lblVMG_Vid_Resolution.Size = New System.Drawing.Size(224, 16)
        Me.lblVMG_Vid_Resolution.TabIndex = 87
        '
        'Label74
        '
        Me.Label74.Location = New System.Drawing.Point(4, 132)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(100, 16)
        Me.Label74.TabIndex = 86
        Me.Label74.Text = "Resolution"
        Me.Label74.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVMG_Vid_Bitrate
        '
        Me.lblVMG_Vid_Bitrate.Location = New System.Drawing.Point(108, 116)
        Me.lblVMG_Vid_Bitrate.Name = "lblVMG_Vid_Bitrate"
        Me.lblVMG_Vid_Bitrate.Size = New System.Drawing.Size(224, 16)
        Me.lblVMG_Vid_Bitrate.TabIndex = 85
        '
        'Label72
        '
        Me.Label72.Location = New System.Drawing.Point(4, 116)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(100, 16)
        Me.Label72.TabIndex = 84
        Me.Label72.Text = "BitrateType"
        Me.Label72.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVMG_Vid_CCF2
        '
        Me.lblVMG_Vid_CCF2.Location = New System.Drawing.Point(108, 100)
        Me.lblVMG_Vid_CCF2.Name = "lblVMG_Vid_CCF2"
        Me.lblVMG_Vid_CCF2.Size = New System.Drawing.Size(224, 16)
        Me.lblVMG_Vid_CCF2.TabIndex = 83
        '
        'Label70
        '
        Me.Label70.Location = New System.Drawing.Point(4, 100)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(100, 16)
        Me.Label70.TabIndex = 82
        Me.Label70.Text = "CC in Field2"
        Me.Label70.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVMG_Vid_CCF1
        '
        Me.lblVMG_Vid_CCF1.Location = New System.Drawing.Point(108, 84)
        Me.lblVMG_Vid_CCF1.Name = "lblVMG_Vid_CCF1"
        Me.lblVMG_Vid_CCF1.Size = New System.Drawing.Size(224, 16)
        Me.lblVMG_Vid_CCF1.TabIndex = 81
        '
        'Label68
        '
        Me.Label68.Location = New System.Drawing.Point(4, 84)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(100, 16)
        Me.Label68.TabIndex = 80
        Me.Label68.Text = "CC in Field1"
        Me.Label68.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVMG_Vid_Letterbox
        '
        Me.lblVMG_Vid_Letterbox.Location = New System.Drawing.Point(108, 68)
        Me.lblVMG_Vid_Letterbox.Name = "lblVMG_Vid_Letterbox"
        Me.lblVMG_Vid_Letterbox.Size = New System.Drawing.Size(224, 16)
        Me.lblVMG_Vid_Letterbox.TabIndex = 79
        '
        'Label64
        '
        Me.Label64.Location = New System.Drawing.Point(4, 68)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(100, 16)
        Me.Label64.TabIndex = 78
        Me.Label64.Text = "Letterbox"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVMG_Vid_PanScan
        '
        Me.lblVMG_Vid_PanScan.Location = New System.Drawing.Point(108, 52)
        Me.lblVMG_Vid_PanScan.Name = "lblVMG_Vid_PanScan"
        Me.lblVMG_Vid_PanScan.Size = New System.Drawing.Size(224, 16)
        Me.lblVMG_Vid_PanScan.TabIndex = 77
        '
        'Label60
        '
        Me.Label60.Location = New System.Drawing.Point(4, 52)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(100, 16)
        Me.Label60.TabIndex = 76
        Me.Label60.Text = "PanScan"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVMG_Vid_AR
        '
        Me.lblVMG_Vid_AR.Location = New System.Drawing.Point(108, 36)
        Me.lblVMG_Vid_AR.Name = "lblVMG_Vid_AR"
        Me.lblVMG_Vid_AR.Size = New System.Drawing.Size(224, 16)
        Me.lblVMG_Vid_AR.TabIndex = 75
        '
        'Label56
        '
        Me.Label56.Location = New System.Drawing.Point(4, 36)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(100, 16)
        Me.Label56.TabIndex = 74
        Me.Label56.Text = "Aspect Ratio"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVMG_Vid_VidStd
        '
        Me.lblVMG_Vid_VidStd.Location = New System.Drawing.Point(108, 20)
        Me.lblVMG_Vid_VidStd.Name = "lblVMG_Vid_VidStd"
        Me.lblVMG_Vid_VidStd.Size = New System.Drawing.Size(224, 16)
        Me.lblVMG_Vid_VidStd.TabIndex = 73
        '
        'Label52
        '
        Me.Label52.Location = New System.Drawing.Point(4, 20)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(100, 16)
        Me.Label52.TabIndex = 72
        Me.Label52.Text = "Video Standard"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVMG_Vid_Compression
        '
        Me.lblVMG_Vid_Compression.Location = New System.Drawing.Point(108, 4)
        Me.lblVMG_Vid_Compression.Name = "lblVMG_Vid_Compression"
        Me.lblVMG_Vid_Compression.Size = New System.Drawing.Size(224, 16)
        Me.lblVMG_Vid_Compression.TabIndex = 71
        '
        'Label49
        '
        Me.Label49.Location = New System.Drawing.Point(4, 4)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(100, 16)
        Me.Label49.TabIndex = 70
        Me.Label49.Text = "Compression"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tpVMGVOBs_Audio
        '
        Me.tpVMGVOBs_Audio.Controls.Add(Me.lblVMG_Aud_SampRate)
        Me.tpVMGVOBs_Audio.Controls.Add(Me.Label79)
        Me.tpVMGVOBs_Audio.Controls.Add(Me.lblVMG_Aud_Quan)
        Me.tpVMGVOBs_Audio.Controls.Add(Me.Label81)
        Me.tpVMGVOBs_Audio.Controls.Add(Me.lblVMG_Aud_Compression)
        Me.tpVMGVOBs_Audio.Controls.Add(Me.Label89)
        Me.tpVMGVOBs_Audio.Controls.Add(Me.lblVMG_AudioCnt)
        Me.tpVMGVOBs_Audio.Controls.Add(Me.Label40)
        Me.tpVMGVOBs_Audio.Location = New System.Drawing.Point(4, 22)
        Me.tpVMGVOBs_Audio.Name = "tpVMGVOBs_Audio"
        Me.tpVMGVOBs_Audio.Size = New System.Drawing.Size(448, 262)
        Me.tpVMGVOBs_Audio.TabIndex = 1
        Me.tpVMGVOBs_Audio.Text = "Audio"
        '
        'lblVMG_Aud_SampRate
        '
        Me.lblVMG_Aud_SampRate.Location = New System.Drawing.Point(108, 52)
        Me.lblVMG_Aud_SampRate.Name = "lblVMG_Aud_SampRate"
        Me.lblVMG_Aud_SampRate.Size = New System.Drawing.Size(224, 16)
        Me.lblVMG_Aud_SampRate.TabIndex = 103
        '
        'Label79
        '
        Me.Label79.Location = New System.Drawing.Point(4, 52)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(100, 16)
        Me.Label79.TabIndex = 102
        Me.Label79.Text = "Sample Rate"
        Me.Label79.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVMG_Aud_Quan
        '
        Me.lblVMG_Aud_Quan.Location = New System.Drawing.Point(108, 36)
        Me.lblVMG_Aud_Quan.Name = "lblVMG_Aud_Quan"
        Me.lblVMG_Aud_Quan.Size = New System.Drawing.Size(224, 16)
        Me.lblVMG_Aud_Quan.TabIndex = 101
        '
        'Label81
        '
        Me.Label81.Location = New System.Drawing.Point(4, 36)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(100, 16)
        Me.Label81.TabIndex = 100
        Me.Label81.Text = "Quantization"
        Me.Label81.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVMG_Aud_Compression
        '
        Me.lblVMG_Aud_Compression.Location = New System.Drawing.Point(108, 20)
        Me.lblVMG_Aud_Compression.Name = "lblVMG_Aud_Compression"
        Me.lblVMG_Aud_Compression.Size = New System.Drawing.Size(224, 16)
        Me.lblVMG_Aud_Compression.TabIndex = 93
        '
        'Label89
        '
        Me.Label89.Location = New System.Drawing.Point(4, 20)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(100, 16)
        Me.Label89.TabIndex = 92
        Me.Label89.Text = "Compression"
        Me.Label89.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVMG_AudioCnt
        '
        Me.lblVMG_AudioCnt.Location = New System.Drawing.Point(108, 4)
        Me.lblVMG_AudioCnt.Name = "lblVMG_AudioCnt"
        Me.lblVMG_AudioCnt.Size = New System.Drawing.Size(224, 16)
        Me.lblVMG_AudioCnt.TabIndex = 69
        '
        'Label40
        '
        Me.Label40.Location = New System.Drawing.Point(4, 4)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(100, 16)
        Me.Label40.TabIndex = 68
        Me.Label40.Text = "Audio Count"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tpVMGVOBs_Subs
        '
        Me.tpVMGVOBs_Subs.Controls.Add(Me.lblVMG_Sub_LangSpecified)
        Me.tpVMGVOBs_Subs.Controls.Add(Me.Label66)
        Me.tpVMGVOBs_Subs.Controls.Add(Me.lblVMG_Sub_LangCodeEx)
        Me.tpVMGVOBs_Subs.Controls.Add(Me.Label58)
        Me.tpVMGVOBs_Subs.Controls.Add(Me.lblVMG_Sub_Lang)
        Me.tpVMGVOBs_Subs.Controls.Add(Me.Label71)
        Me.tpVMGVOBs_Subs.Controls.Add(Me.lblVMG_Sub_Compression)
        Me.tpVMGVOBs_Subs.Controls.Add(Me.Label75)
        Me.tpVMGVOBs_Subs.Controls.Add(Me.lblVMG_SubCount)
        Me.tpVMGVOBs_Subs.Controls.Add(Me.Label42)
        Me.tpVMGVOBs_Subs.Location = New System.Drawing.Point(4, 22)
        Me.tpVMGVOBs_Subs.Name = "tpVMGVOBs_Subs"
        Me.tpVMGVOBs_Subs.Size = New System.Drawing.Size(448, 262)
        Me.tpVMGVOBs_Subs.TabIndex = 2
        Me.tpVMGVOBs_Subs.Text = "Subtitles"
        '
        'lblVMG_Sub_LangSpecified
        '
        Me.lblVMG_Sub_LangSpecified.Location = New System.Drawing.Point(108, 68)
        Me.lblVMG_Sub_LangSpecified.Name = "lblVMG_Sub_LangSpecified"
        Me.lblVMG_Sub_LangSpecified.Size = New System.Drawing.Size(224, 16)
        Me.lblVMG_Sub_LangSpecified.TabIndex = 111
        '
        'Label66
        '
        Me.Label66.Location = New System.Drawing.Point(4, 68)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(100, 16)
        Me.Label66.TabIndex = 110
        Me.Label66.Text = "LangSpecified"
        Me.Label66.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVMG_Sub_LangCodeEx
        '
        Me.lblVMG_Sub_LangCodeEx.Location = New System.Drawing.Point(108, 52)
        Me.lblVMG_Sub_LangCodeEx.Name = "lblVMG_Sub_LangCodeEx"
        Me.lblVMG_Sub_LangCodeEx.Size = New System.Drawing.Size(224, 16)
        Me.lblVMG_Sub_LangCodeEx.TabIndex = 109
        '
        'Label58
        '
        Me.Label58.Location = New System.Drawing.Point(4, 52)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(100, 16)
        Me.Label58.TabIndex = 108
        Me.Label58.Text = "LangCodeEx"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVMG_Sub_Lang
        '
        Me.lblVMG_Sub_Lang.Location = New System.Drawing.Point(108, 36)
        Me.lblVMG_Sub_Lang.Name = "lblVMG_Sub_Lang"
        Me.lblVMG_Sub_Lang.Size = New System.Drawing.Size(224, 16)
        Me.lblVMG_Sub_Lang.TabIndex = 107
        '
        'Label71
        '
        Me.Label71.Location = New System.Drawing.Point(4, 36)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(100, 16)
        Me.Label71.TabIndex = 106
        Me.Label71.Text = "Language"
        Me.Label71.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVMG_Sub_Compression
        '
        Me.lblVMG_Sub_Compression.Location = New System.Drawing.Point(108, 20)
        Me.lblVMG_Sub_Compression.Name = "lblVMG_Sub_Compression"
        Me.lblVMG_Sub_Compression.Size = New System.Drawing.Size(224, 16)
        Me.lblVMG_Sub_Compression.TabIndex = 105
        '
        'Label75
        '
        Me.Label75.Location = New System.Drawing.Point(4, 20)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(100, 16)
        Me.Label75.TabIndex = 104
        Me.Label75.Text = "Compression"
        Me.Label75.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVMG_SubCount
        '
        Me.lblVMG_SubCount.Location = New System.Drawing.Point(108, 4)
        Me.lblVMG_SubCount.Name = "lblVMG_SubCount"
        Me.lblVMG_SubCount.Size = New System.Drawing.Size(224, 16)
        Me.lblVMG_SubCount.TabIndex = 71
        '
        'Label42
        '
        Me.Label42.Location = New System.Drawing.Point(4, 4)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(100, 16)
        Me.Label42.TabIndex = 70
        Me.Label42.Text = "Subtitle Count"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVMG_ProvID
        '
        Me.lblVMG_ProvID.Location = New System.Drawing.Point(108, 124)
        Me.lblVMG_ProvID.Name = "lblVMG_ProvID"
        Me.lblVMG_ProvID.Size = New System.Drawing.Size(224, 16)
        Me.lblVMG_ProvID.TabIndex = 67
        '
        'Label47
        '
        Me.Label47.Location = New System.Drawing.Point(4, 124)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(100, 16)
        Me.Label47.TabIndex = 66
        Me.Label47.Text = "Provider ID"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVMG_VTSCnt
        '
        Me.lblVMG_VTSCnt.Location = New System.Drawing.Point(108, 108)
        Me.lblVMG_VTSCnt.Name = "lblVMG_VTSCnt"
        Me.lblVMG_VTSCnt.Size = New System.Drawing.Size(224, 16)
        Me.lblVMG_VTSCnt.TabIndex = 65
        '
        'Label45
        '
        Me.Label45.Location = New System.Drawing.Point(4, 108)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(100, 16)
        Me.Label45.TabIndex = 64
        Me.Label45.Text = "VTS Count"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVMG_SideID
        '
        Me.lblVMG_SideID.Location = New System.Drawing.Point(108, 92)
        Me.lblVMG_SideID.Name = "lblVMG_SideID"
        Me.lblVMG_SideID.Size = New System.Drawing.Size(224, 16)
        Me.lblVMG_SideID.TabIndex = 63
        '
        'Label43
        '
        Me.Label43.Location = New System.Drawing.Point(4, 92)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(100, 16)
        Me.Label43.TabIndex = 62
        Me.Label43.Text = "Side ID"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVMG_VolID
        '
        Me.lblVMG_VolID.Location = New System.Drawing.Point(108, 76)
        Me.lblVMG_VolID.Name = "lblVMG_VolID"
        Me.lblVMG_VolID.Size = New System.Drawing.Size(224, 16)
        Me.lblVMG_VolID.TabIndex = 61
        '
        'Label41
        '
        Me.Label41.Location = New System.Drawing.Point(4, 76)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(100, 16)
        Me.Label41.TabIndex = 60
        Me.Label41.Text = "Volume ID"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblVMG_VolCnt
        '
        Me.lblVMG_VolCnt.Location = New System.Drawing.Point(108, 60)
        Me.lblVMG_VolCnt.Name = "lblVMG_VolCnt"
        Me.lblVMG_VolCnt.Size = New System.Drawing.Size(224, 16)
        Me.lblVMG_VolCnt.TabIndex = 59
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(4, 60)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(100, 16)
        Me.Label39.TabIndex = 58
        Me.Label39.Text = "Volume Count"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(248, 8)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(16, 12)
        Me.Label29.TabIndex = 57
        Me.Label29.Text = "8"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(228, 8)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(16, 12)
        Me.Label30.TabIndex = 56
        Me.Label30.Text = "7"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(208, 8)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(16, 12)
        Me.Label31.TabIndex = 55
        Me.Label31.Text = "6"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(188, 8)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(16, 12)
        Me.Label32.TabIndex = 54
        Me.Label32.Text = "5"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(168, 8)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(16, 12)
        Me.Label33.TabIndex = 53
        Me.Label33.Text = "4"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(148, 8)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(16, 12)
        Me.Label34.TabIndex = 52
        Me.Label34.Text = "3"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(128, 8)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(16, 12)
        Me.Label35.TabIndex = 51
        Me.Label35.Text = "2"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(108, 8)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(16, 12)
        Me.Label36.TabIndex = 50
        Me.Label36.Text = "1"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlVMG_R8
        '
        Me.pnlVMG_R8.BackColor = System.Drawing.Color.Red
        Me.pnlVMG_R8.Location = New System.Drawing.Point(248, 20)
        Me.pnlVMG_R8.Name = "pnlVMG_R8"
        Me.pnlVMG_R8.Size = New System.Drawing.Size(16, 16)
        Me.pnlVMG_R8.TabIndex = 49
        '
        'pnlVMG_R7
        '
        Me.pnlVMG_R7.BackColor = System.Drawing.Color.Red
        Me.pnlVMG_R7.Location = New System.Drawing.Point(228, 20)
        Me.pnlVMG_R7.Name = "pnlVMG_R7"
        Me.pnlVMG_R7.Size = New System.Drawing.Size(16, 16)
        Me.pnlVMG_R7.TabIndex = 48
        '
        'pnlVMG_R6
        '
        Me.pnlVMG_R6.BackColor = System.Drawing.Color.Red
        Me.pnlVMG_R6.Location = New System.Drawing.Point(208, 20)
        Me.pnlVMG_R6.Name = "pnlVMG_R6"
        Me.pnlVMG_R6.Size = New System.Drawing.Size(16, 16)
        Me.pnlVMG_R6.TabIndex = 47
        '
        'pnlVMG_R5
        '
        Me.pnlVMG_R5.BackColor = System.Drawing.Color.Red
        Me.pnlVMG_R5.Location = New System.Drawing.Point(188, 20)
        Me.pnlVMG_R5.Name = "pnlVMG_R5"
        Me.pnlVMG_R5.Size = New System.Drawing.Size(16, 16)
        Me.pnlVMG_R5.TabIndex = 46
        '
        'pnlVMG_R4
        '
        Me.pnlVMG_R4.BackColor = System.Drawing.Color.Red
        Me.pnlVMG_R4.Location = New System.Drawing.Point(168, 20)
        Me.pnlVMG_R4.Name = "pnlVMG_R4"
        Me.pnlVMG_R4.Size = New System.Drawing.Size(16, 16)
        Me.pnlVMG_R4.TabIndex = 45
        '
        'pnlVMG_R3
        '
        Me.pnlVMG_R3.BackColor = System.Drawing.Color.Red
        Me.pnlVMG_R3.Location = New System.Drawing.Point(148, 20)
        Me.pnlVMG_R3.Name = "pnlVMG_R3"
        Me.pnlVMG_R3.Size = New System.Drawing.Size(16, 16)
        Me.pnlVMG_R3.TabIndex = 44
        '
        'pnlVMG_R2
        '
        Me.pnlVMG_R2.BackColor = System.Drawing.Color.Red
        Me.pnlVMG_R2.Location = New System.Drawing.Point(128, 20)
        Me.pnlVMG_R2.Name = "pnlVMG_R2"
        Me.pnlVMG_R2.Size = New System.Drawing.Size(16, 16)
        Me.pnlVMG_R2.TabIndex = 43
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(36, 20)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(68, 16)
        Me.Label37.TabIndex = 41
        Me.Label37.Text = "Region"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pnlVMG_R1
        '
        Me.pnlVMG_R1.BackColor = System.Drawing.Color.Red
        Me.pnlVMG_R1.Location = New System.Drawing.Point(108, 20)
        Me.pnlVMG_R1.Name = "pnlVMG_R1"
        Me.pnlVMG_R1.Size = New System.Drawing.Size(16, 16)
        Me.pnlVMG_R1.TabIndex = 42
        '
        'lblVMG_SpecVer
        '
        Me.lblVMG_SpecVer.Location = New System.Drawing.Point(108, 44)
        Me.lblVMG_SpecVer.Name = "lblVMG_SpecVer"
        Me.lblVMG_SpecVer.Size = New System.Drawing.Size(224, 16)
        Me.lblVMG_SpecVer.TabIndex = 40
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(4, 44)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(100, 16)
        Me.Label28.TabIndex = 39
        Me.Label28.Text = "Spec Version"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tpJacketPics
        '
        Me.tpJacketPics.Controls.Add(Me.lbJacketPics)
        Me.tpJacketPics.Controls.Add(Me.pnlJP_OneMoment)
        Me.tpJacketPics.Location = New System.Drawing.Point(4, 22)
        Me.tpJacketPics.Name = "tpJacketPics"
        Me.tpJacketPics.Size = New System.Drawing.Size(472, 462)
        Me.tpJacketPics.TabIndex = 2
        Me.tpJacketPics.Text = "Jacket Pictures"
        '
        'lbJacketPics
        '
        Me.lbJacketPics.Location = New System.Drawing.Point(28, 32)
        Me.lbJacketPics.Name = "lbJacketPics"
        Me.lbJacketPics.Size = New System.Drawing.Size(192, 56)
        Me.lbJacketPics.TabIndex = 0
        '
        'pnlJP_OneMoment
        '
        Me.pnlJP_OneMoment.Controls.Add(Me.Label114)
        Me.pnlJP_OneMoment.Location = New System.Drawing.Point(24, 12)
        Me.pnlJP_OneMoment.Name = "pnlJP_OneMoment"
        Me.pnlJP_OneMoment.Size = New System.Drawing.Size(200, 100)
        Me.pnlJP_OneMoment.TabIndex = 1
        Me.pnlJP_OneMoment.Visible = False
        '
        'Label114
        '
        Me.Label114.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label114.Location = New System.Drawing.Point(20, 32)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(160, 23)
        Me.Label114.TabIndex = 0
        Me.Label114.Text = "One Moment ..."
        Me.Label114.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tpVTS
        '
        Me.tpVTS.Controls.Add(Me.Label50)
        Me.tpVTS.Controls.Add(Me.nudCurrentVTS)
        Me.tpVTS.Controls.Add(Me.Label44)
        Me.tpVTS.Controls.Add(Me.Label54)
        Me.tpVTS.Controls.Add(Me.Label62)
        Me.tpVTS.Controls.Add(Me.Label69)
        Me.tpVTS.Controls.Add(Me.Label77)
        Me.tpVTS.Controls.Add(Me.Label82)
        Me.tpVTS.Controls.Add(Me.Label84)
        Me.tpVTS.Controls.Add(Me.Label86)
        Me.tpVTS.Controls.Add(Me.Label88)
        Me.tpVTS.Controls.Add(Me.Label90)
        Me.tpVTS.Controls.Add(Me.Label91)
        Me.tpVTS.Controls.Add(Me.Label92)
        Me.tpVTS.Controls.Add(Me.Label93)
        Me.tpVTS.Controls.Add(Me.Label94)
        Me.tpVTS.Controls.Add(Me.Label95)
        Me.tpVTS.Controls.Add(Me.Label96)
        Me.tpVTS.Controls.Add(Me.Label97)
        Me.tpVTS.Controls.Add(Me.Label98)
        Me.tpVTS.Controls.Add(Me.Label99)
        Me.tpVTS.Controls.Add(Me.Label100)
        Me.tpVTS.Controls.Add(Me.Label101)
        Me.tpVTS.Controls.Add(Me.Label102)
        Me.tpVTS.Controls.Add(Me.Label103)
        Me.tpVTS.Controls.Add(Me.Label104)
        Me.tpVTS.Controls.Add(Me.Label105)
        Me.tpVTS.Controls.Add(Me.Label106)
        Me.tpVTS.Controls.Add(Me.Label107)
        Me.tpVTS.Controls.Add(Me.Label108)
        Me.tpVTS.Location = New System.Drawing.Point(4, 22)
        Me.tpVTS.Name = "tpVTS"
        Me.tpVTS.Size = New System.Drawing.Size(472, 462)
        Me.tpVTS.TabIndex = 1
        Me.tpVTS.Text = "VTS"
        '
        'Label50
        '
        Me.Label50.Location = New System.Drawing.Point(4, 8)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(100, 16)
        Me.Label50.TabIndex = 147
        Me.Label50.Text = "Current VTS"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'nudCurrentVTS
        '
        Me.nudCurrentVTS.Location = New System.Drawing.Point(104, 4)
        Me.nudCurrentVTS.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudCurrentVTS.Name = "nudCurrentVTS"
        Me.nudCurrentVTS.Size = New System.Drawing.Size(44, 20)
        Me.nudCurrentVTS.TabIndex = 146
        '
        'Label44
        '
        Me.Label44.Location = New System.Drawing.Point(176, 327)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(224, 16)
        Me.Label44.TabIndex = 145
        '
        'Label54
        '
        Me.Label54.Location = New System.Drawing.Point(72, 327)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(100, 16)
        Me.Label54.TabIndex = 144
        Me.Label54.Text = "Dolby Sur Ok"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label62
        '
        Me.Label62.Location = New System.Drawing.Point(176, 311)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(224, 16)
        Me.Label62.TabIndex = 143
        '
        'Label69
        '
        Me.Label69.Location = New System.Drawing.Point(72, 311)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(100, 16)
        Me.Label69.TabIndex = 142
        Me.Label69.Text = "Solo/Duet"
        Me.Label69.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label77
        '
        Me.Label77.Location = New System.Drawing.Point(176, 295)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(224, 16)
        Me.Label77.TabIndex = 141
        '
        'Label82
        '
        Me.Label82.Location = New System.Drawing.Point(72, 295)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(100, 16)
        Me.Label82.TabIndex = 140
        Me.Label82.Text = "MC Intro"
        Me.Label82.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label84
        '
        Me.Label84.Location = New System.Drawing.Point(176, 279)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(224, 16)
        Me.Label84.TabIndex = 139
        '
        'Label86
        '
        Me.Label86.Location = New System.Drawing.Point(72, 279)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(100, 16)
        Me.Label86.TabIndex = 138
        Me.Label86.Text = "Karaoke Ver"
        Me.Label86.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label88
        '
        Me.Label88.Location = New System.Drawing.Point(176, 263)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(224, 16)
        Me.Label88.TabIndex = 137
        '
        'Label90
        '
        Me.Label90.Location = New System.Drawing.Point(72, 263)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(100, 16)
        Me.Label90.TabIndex = 136
        Me.Label90.Text = "Ch Assignments"
        Me.Label90.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label91
        '
        Me.Label91.Location = New System.Drawing.Point(176, 247)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(224, 16)
        Me.Label91.TabIndex = 135
        '
        'Label92
        '
        Me.Label92.Location = New System.Drawing.Point(72, 247)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(100, 16)
        Me.Label92.TabIndex = 134
        Me.Label92.Text = "LangCodeExt"
        Me.Label92.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label93
        '
        Me.Label93.Location = New System.Drawing.Point(176, 231)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(224, 16)
        Me.Label93.TabIndex = 133
        '
        'Label94
        '
        Me.Label94.Location = New System.Drawing.Point(72, 231)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(100, 16)
        Me.Label94.TabIndex = 132
        Me.Label94.Text = "Lang Code"
        Me.Label94.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label95
        '
        Me.Label95.Location = New System.Drawing.Point(176, 215)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(224, 16)
        Me.Label95.TabIndex = 131
        '
        'Label96
        '
        Me.Label96.Location = New System.Drawing.Point(72, 215)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(100, 16)
        Me.Label96.TabIndex = 130
        Me.Label96.Text = "Sample Rate"
        Me.Label96.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label97
        '
        Me.Label97.Location = New System.Drawing.Point(176, 199)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(224, 16)
        Me.Label97.TabIndex = 129
        '
        'Label98
        '
        Me.Label98.Location = New System.Drawing.Point(72, 199)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(100, 16)
        Me.Label98.TabIndex = 128
        Me.Label98.Text = "Quantization"
        Me.Label98.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label99
        '
        Me.Label99.Location = New System.Drawing.Point(176, 183)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(224, 16)
        Me.Label99.TabIndex = 127
        '
        'Label100
        '
        Me.Label100.Location = New System.Drawing.Point(72, 183)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(100, 16)
        Me.Label100.TabIndex = 126
        Me.Label100.Text = "Mode"
        Me.Label100.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label101
        '
        Me.Label101.Location = New System.Drawing.Point(176, 167)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(224, 16)
        Me.Label101.TabIndex = 125
        '
        'Label102
        '
        Me.Label102.Location = New System.Drawing.Point(72, 167)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(100, 16)
        Me.Label102.TabIndex = 124
        Me.Label102.Text = "Lang Type"
        Me.Label102.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label103
        '
        Me.Label103.Location = New System.Drawing.Point(176, 151)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(224, 16)
        Me.Label103.TabIndex = 123
        '
        'Label104
        '
        Me.Label104.Location = New System.Drawing.Point(72, 151)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(100, 16)
        Me.Label104.TabIndex = 122
        Me.Label104.Text = "MultiCh Ext"
        Me.Label104.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label105
        '
        Me.Label105.Location = New System.Drawing.Point(176, 135)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(224, 16)
        Me.Label105.TabIndex = 121
        '
        'Label106
        '
        Me.Label106.Location = New System.Drawing.Point(72, 135)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(100, 16)
        Me.Label106.TabIndex = 120
        Me.Label106.Text = "Compression"
        Me.Label106.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label107
        '
        Me.Label107.Location = New System.Drawing.Point(176, 119)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(224, 16)
        Me.Label107.TabIndex = 119
        '
        'Label108
        '
        Me.Label108.Location = New System.Drawing.Point(72, 119)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(100, 16)
        Me.Label108.TabIndex = 118
        Me.Label108.Text = "Audio Count"
        Me.Label108.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tpLayerBreak
        '
        Me.tpLayerBreak.Controls.Add(Me.pnlLBsMulti)
        Me.tpLayerBreak.Controls.Add(Me.pnlNoCandidateLBs)
        Me.tpLayerBreak.Controls.Add(Me.pnlLikelyLayerbreak)
        Me.tpLayerBreak.Location = New System.Drawing.Point(4, 22)
        Me.tpLayerBreak.Name = "tpLayerBreak"
        Me.tpLayerBreak.Size = New System.Drawing.Size(472, 462)
        Me.tpLayerBreak.TabIndex = 3
        Me.tpLayerBreak.Text = "Layer Break"
        '
        'pnlLBsMulti
        '
        Me.pnlLBsMulti.Controls.Add(Me.nudLBMulti)
        Me.pnlLBsMulti.Controls.Add(Me.Label111)
        Me.pnlLBsMulti.Controls.Add(Me.lblLB_Multi_cnt)
        Me.pnlLBsMulti.Controls.Add(Me.Label119)
        Me.pnlLBsMulti.Controls.Add(Me.Label109)
        Me.pnlLBsMulti.Controls.Add(Me.lblLB_Multi_ST)
        Me.pnlLBsMulti.Controls.Add(Me.Label112)
        Me.pnlLBsMulti.Controls.Add(Me.Label113)
        Me.pnlLBsMulti.Controls.Add(Me.lblLB_Multi_TT)
        Me.pnlLBsMulti.Controls.Add(Me.Label115)
        Me.pnlLBsMulti.Controls.Add(Me.lblLB_Multi_RT)
        Me.pnlLBsMulti.Controls.Add(Me.Label117)
        Me.pnlLBsMulti.Controls.Add(Me.lblLB_Multi_CH)
        Me.pnlLBsMulti.Location = New System.Drawing.Point(4, 4)
        Me.pnlLBsMulti.Name = "pnlLBsMulti"
        Me.pnlLBsMulti.Size = New System.Drawing.Size(216, 128)
        Me.pnlLBsMulti.TabIndex = 10
        Me.pnlLBsMulti.Visible = False
        '
        'nudLBMulti
        '
        Me.nudLBMulti.Location = New System.Drawing.Point(108, 36)
        Me.nudLBMulti.Name = "nudLBMulti"
        Me.nudLBMulti.Size = New System.Drawing.Size(32, 20)
        Me.nudLBMulti.TabIndex = 12
        '
        'Label111
        '
        Me.Label111.Location = New System.Drawing.Point(4, 36)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(100, 16)
        Me.Label111.TabIndex = 11
        Me.Label111.Text = "Current:"
        Me.Label111.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblLB_Multi_cnt
        '
        Me.lblLB_Multi_cnt.Location = New System.Drawing.Point(108, 20)
        Me.lblLB_Multi_cnt.Name = "lblLB_Multi_cnt"
        Me.lblLB_Multi_cnt.Size = New System.Drawing.Size(100, 16)
        Me.lblLB_Multi_cnt.TabIndex = 10
        '
        'Label119
        '
        Me.Label119.Location = New System.Drawing.Point(4, 20)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(100, 16)
        Me.Label119.TabIndex = 9
        Me.Label119.Text = "# Candidates:"
        Me.Label119.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label109
        '
        Me.Label109.Location = New System.Drawing.Point(4, 108)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(100, 16)
        Me.Label109.TabIndex = 7
        Me.Label109.Text = "Source Time:"
        Me.Label109.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblLB_Multi_ST
        '
        Me.lblLB_Multi_ST.Location = New System.Drawing.Point(108, 108)
        Me.lblLB_Multi_ST.Name = "lblLB_Multi_ST"
        Me.lblLB_Multi_ST.Size = New System.Drawing.Size(100, 16)
        Me.lblLB_Multi_ST.TabIndex = 8
        '
        'Label112
        '
        Me.Label112.Location = New System.Drawing.Point(4, 60)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(100, 16)
        Me.Label112.TabIndex = 1
        Me.Label112.Text = "Title:"
        Me.Label112.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label113
        '
        Me.Label113.Location = New System.Drawing.Point(4, 92)
        Me.Label113.Name = "Label113"
        Me.Label113.Size = New System.Drawing.Size(100, 16)
        Me.Label113.TabIndex = 3
        Me.Label113.Text = "Running Time:"
        Me.Label113.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblLB_Multi_TT
        '
        Me.lblLB_Multi_TT.Location = New System.Drawing.Point(108, 60)
        Me.lblLB_Multi_TT.Name = "lblLB_Multi_TT"
        Me.lblLB_Multi_TT.Size = New System.Drawing.Size(100, 16)
        Me.lblLB_Multi_TT.TabIndex = 4
        '
        'Label115
        '
        Me.Label115.Location = New System.Drawing.Point(4, 76)
        Me.Label115.Name = "Label115"
        Me.Label115.Size = New System.Drawing.Size(100, 16)
        Me.Label115.TabIndex = 2
        Me.Label115.Text = "Chapter:"
        Me.Label115.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblLB_Multi_RT
        '
        Me.lblLB_Multi_RT.Location = New System.Drawing.Point(108, 92)
        Me.lblLB_Multi_RT.Name = "lblLB_Multi_RT"
        Me.lblLB_Multi_RT.Size = New System.Drawing.Size(100, 16)
        Me.lblLB_Multi_RT.TabIndex = 6
        '
        'Label117
        '
        Me.Label117.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label117.Location = New System.Drawing.Point(4, 4)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(208, 16)
        Me.Label117.TabIndex = 0
        Me.Label117.Text = "Multiple Possible Layerbreaks"
        Me.Label117.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblLB_Multi_CH
        '
        Me.lblLB_Multi_CH.Location = New System.Drawing.Point(108, 76)
        Me.lblLB_Multi_CH.Name = "lblLB_Multi_CH"
        Me.lblLB_Multi_CH.Size = New System.Drawing.Size(100, 16)
        Me.lblLB_Multi_CH.TabIndex = 5
        '
        'pnlNoCandidateLBs
        '
        Me.pnlNoCandidateLBs.Controls.Add(Me.Label126)
        Me.pnlNoCandidateLBs.Location = New System.Drawing.Point(4, 4)
        Me.pnlNoCandidateLBs.Name = "pnlNoCandidateLBs"
        Me.pnlNoCandidateLBs.Size = New System.Drawing.Size(212, 92)
        Me.pnlNoCandidateLBs.TabIndex = 11
        Me.pnlNoCandidateLBs.Visible = False
        '
        'Label126
        '
        Me.Label126.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label126.Location = New System.Drawing.Point(8, 8)
        Me.Label126.Name = "Label126"
        Me.Label126.Size = New System.Drawing.Size(180, 16)
        Me.Label126.TabIndex = 0
        Me.Label126.Text = "No Layerbreak Candidates"
        Me.Label126.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlLikelyLayerbreak
        '
        Me.pnlLikelyLayerbreak.Controls.Add(Me.Label110)
        Me.pnlLikelyLayerbreak.Controls.Add(Me.lblLB_SourceTime)
        Me.pnlLikelyLayerbreak.Controls.Add(Me.Label83)
        Me.pnlLikelyLayerbreak.Controls.Add(Me.Label87)
        Me.pnlLikelyLayerbreak.Controls.Add(Me.lblLB_TT)
        Me.pnlLikelyLayerbreak.Controls.Add(Me.Label85)
        Me.pnlLikelyLayerbreak.Controls.Add(Me.lblLB_RT)
        Me.pnlLikelyLayerbreak.Controls.Add(Me.Label80)
        Me.pnlLikelyLayerbreak.Controls.Add(Me.lblLB_CH)
        Me.pnlLikelyLayerbreak.Location = New System.Drawing.Point(4, 4)
        Me.pnlLikelyLayerbreak.Name = "pnlLikelyLayerbreak"
        Me.pnlLikelyLayerbreak.Size = New System.Drawing.Size(212, 92)
        Me.pnlLikelyLayerbreak.TabIndex = 9
        Me.pnlLikelyLayerbreak.Visible = False
        '
        'Label110
        '
        Me.Label110.Location = New System.Drawing.Point(4, 72)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(100, 16)
        Me.Label110.TabIndex = 7
        Me.Label110.Text = "Source Time:"
        Me.Label110.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblLB_SourceTime
        '
        Me.lblLB_SourceTime.Location = New System.Drawing.Point(108, 72)
        Me.lblLB_SourceTime.Name = "lblLB_SourceTime"
        Me.lblLB_SourceTime.Size = New System.Drawing.Size(100, 16)
        Me.lblLB_SourceTime.TabIndex = 8
        '
        'Label83
        '
        Me.Label83.Location = New System.Drawing.Point(4, 24)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(100, 16)
        Me.Label83.TabIndex = 1
        Me.Label83.Text = "Title:"
        Me.Label83.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label87
        '
        Me.Label87.Location = New System.Drawing.Point(4, 56)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(100, 16)
        Me.Label87.TabIndex = 3
        Me.Label87.Text = "Running Time:"
        Me.Label87.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblLB_TT
        '
        Me.lblLB_TT.Location = New System.Drawing.Point(108, 24)
        Me.lblLB_TT.Name = "lblLB_TT"
        Me.lblLB_TT.Size = New System.Drawing.Size(100, 16)
        Me.lblLB_TT.TabIndex = 4
        '
        'Label85
        '
        Me.Label85.Location = New System.Drawing.Point(4, 40)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(100, 16)
        Me.Label85.TabIndex = 2
        Me.Label85.Text = "Chapter:"
        Me.Label85.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblLB_RT
        '
        Me.lblLB_RT.Location = New System.Drawing.Point(108, 56)
        Me.lblLB_RT.Name = "lblLB_RT"
        Me.lblLB_RT.Size = New System.Drawing.Size(100, 16)
        Me.lblLB_RT.TabIndex = 6
        '
        'Label80
        '
        Me.Label80.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.Location = New System.Drawing.Point(48, 4)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(132, 16)
        Me.Label80.TabIndex = 0
        Me.Label80.Text = "Likely Layerbreak"
        Me.Label80.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblLB_CH
        '
        Me.lblLB_CH.Location = New System.Drawing.Point(108, 40)
        Me.lblLB_CH.Name = "lblLB_CH"
        Me.lblLB_CH.Size = New System.Drawing.Size(100, 16)
        Me.lblLB_CH.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tcIFO)
        Me.GroupBox2.Location = New System.Drawing.Point(352, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(488, 508)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "IFO Info"
        '
        'ddlDriveLetter
        '
        Me.ddlDriveLetter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlDriveLetter.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.ddlDriveLetter.Location = New System.Drawing.Point(180, 4)
        Me.ddlDriveLetter.Name = "ddlDriveLetter"
        Me.ddlDriveLetter.Size = New System.Drawing.Size(40, 21)
        Me.ddlDriveLetter.TabIndex = 1
        '
        'Label73
        '
        Me.Label73.Location = New System.Drawing.Point(120, 8)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(60, 16)
        Me.Label73.TabIndex = 3
        Me.Label73.Text = "DVD Drive"
        Me.Label73.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label116
        '
        Me.Label116.Location = New System.Drawing.Point(263, 8)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(56, 16)
        Me.Label116.TabIndex = 4
        Me.Label116.Text = "DVD Path"
        Me.Label116.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtDVDPath
        '
        Me.txtDVDPath.Location = New System.Drawing.Point(320, 4)
        Me.txtDVDPath.Name = "txtDVDPath"
        Me.txtDVDPath.Size = New System.Drawing.Size(460, 20)
        Me.txtDVDPath.TabIndex = 5
        Me.txtDVDPath.Text = "E:\MEDIA\SDDVD\IFOs\Radius_072007"
        '
        'rbUseDisc
        '
        Me.rbUseDisc.Location = New System.Drawing.Point(106, 4)
        Me.rbUseDisc.Name = "rbUseDisc"
        Me.rbUseDisc.Size = New System.Drawing.Size(17, 24)
        Me.rbUseDisc.TabIndex = 6
        '
        'rbUsePath
        '
        Me.rbUsePath.Checked = True
        Me.rbUsePath.Location = New System.Drawing.Point(247, 4)
        Me.rbUsePath.Name = "rbUsePath"
        Me.rbUsePath.Size = New System.Drawing.Size(19, 24)
        Me.rbUsePath.TabIndex = 7
        Me.rbUsePath.TabStop = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(784, 4)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(52, 23)
        Me.btnBrowse.TabIndex = 8
        Me.btnBrowse.Text = "Browse"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(844, 541)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.rbUsePath)
        Me.Controls.Add(Me.rbUseDisc)
        Me.Controls.Add(Me.txtDVDPath)
        Me.Controls.Add(Me.Label116)
        Me.Controls.Add(Me.Label73)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbIOCTL)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.ddlDriveLetter)
        Me.Menu = Me.MainMenus
        Me.Name = "frmMain"
        Me.Text = "Sequoyan DVD Parser"
        Me.gbIOCTL.ResumeLayout(False)
        Me.gbIOCTL.PerformLayout()
        Me.tcIFO.ResumeLayout(False)
        Me.tpVideoManager.ResumeLayout(False)
        Me.tcVMGM.ResumeLayout(False)
        Me.tpVMGMenuSpace.ResumeLayout(False)
        Me.tpVMGGlobalTT.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.nudVMG_GTT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpVMGVOBs.ResumeLayout(False)
        Me.tcVMGVOBs.ResumeLayout(False)
        Me.tpVMGVOBs_Video.ResumeLayout(False)
        Me.tpVMGVOBs_Audio.ResumeLayout(False)
        Me.tpVMGVOBs_Subs.ResumeLayout(False)
        Me.tpJacketPics.ResumeLayout(False)
        Me.pnlJP_OneMoment.ResumeLayout(False)
        Me.tpVTS.ResumeLayout(False)
        CType(Me.nudCurrentVTS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpLayerBreak.ResumeLayout(False)
        Me.pnlLBsMulti.ResumeLayout(False)
        CType(Me.nudLBMulti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNoCandidateLBs.ResumeLayout(False)
        Me.pnlLikelyLayerbreak.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public DVDIOCTL As cDVDIOCTL
    Public CurrentDVD As cDVD

#Region "SHARED"

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DVDIOCTL = New cDVDIOCTL
        Me.ddlDriveLetter.SelectedIndex = 3
        SetupViewer()
        If My.Settings.LAST_PATH <> "" Then
            Me.txtDVDPath.Text = My.Settings.LAST_PATH
            Me.rbUsePath.Checked = True
        End If
    End Sub

    Public ReadOnly Property DVDPath() As String
        Get
            If Me.rbUseDisc.Checked Then
                Return Me.ddlDriveLetter.SelectedItem.ToString() & ":\VIDEO_TS\"
            Else
                Return Me.txtDVDPath.Text
            End If
        End Get
    End Property

    Public ReadOnly Property DVDDriveLetter() As Char
        Get
            Return Microsoft.VisualBasic.Left(Path.GetPathRoot(DVDPath), 1)
        End Get
    End Property

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Dim dlg As New FolderBrowserDialog
        dlg.RootFolder = Environment.SpecialFolder.MyComputer
        dlg.ShowNewFolderButton = True
        If My.Settings.LAST_PATH = "" Then
            dlg.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Else
            dlg.SelectedPath = My.Settings.LAST_PATH
        End If
        If dlg.ShowDialog = DialogResult.OK Then
            Me.txtDVDPath.Text = dlg.SelectedPath & "\"
            Me.rbUsePath.Checked = True
        End If
    End Sub

    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click
        Try
            If Me.rbUseDisc.Checked Then
                PopulateIOCTLInfo()
                Me.gbIOCTL.Enabled = True
                My.Settings.LAST_PATH = "D:\"
                My.Settings.Save()
            Else
                My.Settings.LAST_PATH = Me.txtDVDPath.Text
                My.Settings.Save()
                Me.gbIOCTL.Enabled = False
                CurrentDVD = New cDVD(Me.txtDVDPath.Text)
                If CurrentDVD.HasCallSSRSM127 Then
                    Dim Locations() As cDVD.cDVDLocation = CurrentDVD.CallSSRSM127_Location
                    For Each Location As cDVD.cDVDLocation In Locations
                        MsgBox("""CallSS RSM=127"" command found in the current project at the following location: " & Location.ToString)
                    Next
                End If
                Dim NSCs As colNonSeamlessCells = CurrentDVD.GetNonSeamlessCells()
                Debug.WriteLine("hi")
                '    For Each GTT As cGlobalTT In CurrentDVD.VMGM.GlobalTTs
                '        Debug.WriteLine(GTT.ParentalManagementMask)
                '    Next
            End If
            PopulateJacketPictures()
            PopulateLayerbreak()
        Catch ex As Exception
            'MsgBox("Failed to retrieve valid information. Error: " & ex.Message)
            MsgBox("Problem with Run. Error: " & ex.Message)
        End Try
    End Sub

    Public Function GetRegionColor(ByVal Val As Boolean, ByVal Flip As Boolean) As Color
        If Flip Then
            If Val Then
                Return Color.LawnGreen
            Else
                Return Color.Red
            End If
        Else
            If Val Then
                Return Color.Red
            Else
                Return Color.LawnGreen
            End If
        End If
    End Function

    Public Sub ResetUI()
        'TODO:
    End Sub

    Public Sub AddConsoleLine(ByVal Msg As String)
        MsgBox(Msg)
    End Sub

#End Region 'SHARED

#Region "IOCTL"

    Public Sub PopulateIOCTLInfo()
        Try
            Dim reg As cDVDIOCTL.DVD_REGION = DVDIOCTL.GetDVD_REGION(DVDDriveLetter)

            Dim ld As DVD_LAYER_DESCRIPTOR = DVDIOCTL.GetDVD_LAYER_DESCRIPTOR(DVDDriveLetter)

            If ld.BCAFlag = True Then
                Dim bcad As DVD_BCA_DESCRIPTOR = DVDIOCTL.GetDVD_BCA_DESCRIPTOR(DVDDriveLetter)
                Me.txtIOCTL_BCAInfo.Text = bcad.BCAInformation(0).ToString
            End If

            Dim md As DVD_MANUFACTURER_DESCRIPTOR = DVDIOCTL.GetDVD_MANUFACTURER_DESCRIPTOR(DVDDriveLetter)

            Dim cd As DVD_COPYRIGHT_DESCRIPTOR = DVDIOCTL.GetDVD_COPYRIGHT_DESCRIPTOR(DVDDriveLetter)

            Me.pnlReg_1.BackColor = GetRegionColor((reg.RegionData >> 0) And 1, False)
            Me.pnlReg_2.BackColor = GetRegionColor((reg.RegionData >> 1) And 1, False)
            Me.pnlReg_3.BackColor = GetRegionColor((reg.RegionData >> 2) And 1, False)
            Me.pnlReg_4.BackColor = GetRegionColor((reg.RegionData >> 3) And 1, False)
            Me.pnlReg_5.BackColor = GetRegionColor((reg.RegionData >> 4) And 1, False)
            Me.pnlReg_6.BackColor = GetRegionColor((reg.RegionData >> 5) And 1, False)
            Me.pnlReg_7.BackColor = GetRegionColor((reg.RegionData >> 6) And 1, False)
            Me.pnlReg_8.BackColor = GetRegionColor((reg.RegionData >> 7) And 1, False)
            Me.lblIOCTL_CopySystem.Text = DVDIOCTL.FormatString(CType(reg.CopySystem, eCopySystem).ToString)

            Me.lblIOCTL_RegManInfo.Text = cd.RegionManagementInformation

            Me.lblIOCTL_BCAFlag.Text = ld.BCAFlag
            Me.lblIOCTL_BookType.Text = ld.BookType
            Me.lblIOCTL_BookVer.Text = ld.BookVersion
            Me.lblIOCTL_DiscSize.Text = ld.DiskSize
            Me.lblIOCTL_EndDataSector.Text = ld.EndDataSector
            Me.lblIOCTL_EndLayerZeroSector.Text = ld.EndLayerZeroSector
            Me.lblIOCTL_LayerType.Text = ld.LayerType
            Me.lblIOCTL_LinearDensity.Text = ld.LinearDensity
            Me.lblIOCTL_MinRate.Text = ld.MinimumRate
            Me.lblIOCTL_NumberOfLayers.Text = ld.NumberOfLayers
            Me.lblIOCTL_StartingDataSector.Text = ld.StartingDataSector
            Me.lblIOCTL_TrackDensity.Text = ld.TrackDensity
            Me.lblIOCTL_TrackPath.Text = ld.TrackPath

            If Not md.ManufacturingInformation Is Nothing Then
                Dim sb As New StringBuilder
                For i As Short = 0 To 2047
                    sb.Append(md.ManufacturingInformation(0).ToString)
                Next
                Me.txtIOCTL_ManInfo.Text = sb.ToString
            End If
        Catch ex As Exception
            Debug.WriteLine("Problem with Populate left info. Error: " & ex.Message)
        End Try
    End Sub

#End Region 'IOCTL

#Region "IFOs"

    Public Sub PopulateVMGM()
        Try
            Dim VMGM As cVMGM = CurrentDVD.VMGM
            Me.lblVMG_ProvID.Text = VMGM.ProviderID
            Me.lblVMG_SideID.Text = VMGM.SideID
            Me.lblVMG_SpecVer.Text = VMGM.VersionNumber
            Me.lblVMG_VolCnt.Text = VMGM.NumberOfVolumes
            Me.lblVMG_VolID.Text = VMGM.VolumeNumber
            Me.lblVMG_VTSCnt.Text = VMGM.NumberOfTitleSets
            Me.nudCurrentVTS.Value = 1
            Me.nudCurrentVTS.Minimum = 1
            Me.nudCurrentVTS.Maximum = VMGM.NumberOfTitleSets
            Me.pnlVMG_R1.BackColor = Me.GetRegionColor(VMGM.R1, True)
            Me.pnlVMG_R2.BackColor = Me.GetRegionColor(VMGM.R2, True)
            Me.pnlVMG_R3.BackColor = Me.GetRegionColor(VMGM.R3, True)
            Me.pnlVMG_R4.BackColor = Me.GetRegionColor(VMGM.R4, True)
            Me.pnlVMG_R5.BackColor = Me.GetRegionColor(VMGM.R5, True)
            Me.pnlVMG_R6.BackColor = Me.GetRegionColor(VMGM.R6, True)
            Me.pnlVMG_R7.BackColor = Me.GetRegionColor(VMGM.R7, True)
            Me.pnlVMG_R8.BackColor = Me.GetRegionColor(VMGM.R8, True)

            'VMGM GLOBAL TITLE INFO
            Me.lblVMG_GlobalTTCount.Text = VMGM.NumberOfGlobalTitles
            Me.nudVMG_GTT.Minimum = 1
            Me.nudVMG_GTT.Maximum = VMGM.NumberOfGlobalTitles

            Me.lblVMG_GTT_AngCount.Text = VMGM.GlobalTTs(0).NumberOfAngles
            Me.lblVMG_GTT_BtnCmd.Text = VMGM.GlobalTTs(0).Type.ButtonCommand
            Me.lblVMG_GTT_CellCmd.Text = VMGM.GlobalTTs(0).Type.CellCommand
            Me.lblVMG_GTT_ParentVTS.Text = VMGM.GlobalTTs(0).VTSN
            Me.lblVMG_GTT_PMask.Text = VMGM.GlobalTTs(0).ParentalManagementMask
            Me.lblVMG_GTT_PrePostCmd.Text = VMGM.GlobalTTs(0).Type.PrePostCommand
            Me.lblVMG_GTT_PTTCnt.Text = VMGM.GlobalTTs(0).NumberOfChapters
            Me.lblVMG_GTT_PTTPlaySearch.Text = VMGM.GlobalTTs(0).Type.UOPPTTPlayOrSearch
            Me.lblVMG_GTT_Sequential.Text = VMGM.GlobalTTs(0).Type.Sequential
            Me.lblVMG_GTT_TimePlaySearch.Text = VMGM.GlobalTTs(0).Type.UOPTimePlayOrSearch
            Me.lblVMG_GTT_VTSTT.Text = VMGM.GlobalTTs(0).VTS_TTN

            'VMGM VOB Video Attributes
            Me.lblVMG_Vid_AR.Text = Replace(VMGM.VidAttsVMGM_VOBS.AspectRatio.ToString, "ar", "")
            Me.lblVMG_Vid_Bitrate.Text = VMGM.VidAttsVMGM_VOBS.Bitrate.ToString
            Me.lblVMG_Vid_CCF1.Text = VMGM.VidAttsVMGM_VOBS.Line21Field1.ToString
            Me.lblVMG_Vid_CCF2.Text = VMGM.VidAttsVMGM_VOBS.Line21Field2.ToString
            Me.lblVMG_Vid_Compression.Text = VMGM.VidAttsVMGM_VOBS.CodingMode.ToString
            Me.lblVMG_Vid_FilmMode.Text = VMGM.VidAttsVMGM_VOBS.Film.ToString

            If VMGM.VidAttsVMGM_VOBS.Letterboxed Then
                Me.lblVMG_Vid_Letterboxed.Text = "True"
            Else
                Me.lblVMG_Vid_Letterboxed.Text = "False"
            End If

            Me.lblVMG_Vid_Letterbox.Text = VMGM.VidAttsVMGM_VOBS.LetterboxAllowed.ToString
            Me.lblVMG_Vid_PanScan.Text = VMGM.VidAttsVMGM_VOBS.PanScanAllowed.ToString

            Select Case VMGM.VidAttsVMGM_VOBS.Resolution
                Case eResolution.Res352x240_352x288
                    If VMGM.VidAttsVMGM_VOBS.VideoStandard = eVideoStandard.NTSC Then
                        Me.lblVMG_Vid_Resolution.Text = "352x240"
                    Else
                        Me.lblVMG_Vid_Resolution.Text = "352x288"
                    End If
                Case eResolution.Res352x480_352x576
                    If VMGM.VidAttsVMGM_VOBS.VideoStandard = eVideoStandard.NTSC Then
                        Me.lblVMG_Vid_Resolution.Text = "352x480"
                    Else
                        Me.lblVMG_Vid_Resolution.Text = "352x576"
                    End If
                Case eResolution.Res704x480_704x576
                    If VMGM.VidAttsVMGM_VOBS.VideoStandard = eVideoStandard.NTSC Then
                        Me.lblVMG_Vid_Resolution.Text = "704x480"
                    Else
                        Me.lblVMG_Vid_Resolution.Text = "704x576"
                    End If
                Case eResolution.Res720x480_720x576
                    If VMGM.VidAttsVMGM_VOBS.VideoStandard = eVideoStandard.NTSC Then
                        Me.lblVMG_Vid_Resolution.Text = "720x480"
                    Else
                        Me.lblVMG_Vid_Resolution.Text = "720x576"
                    End If
            End Select
            Me.lblVMG_Vid_VidStd.Text = VMGM.VidAttsVMGM_VOBS.VideoStandard.ToString

            'VMGM VOB Audio Attributes
            Me.lblVMG_AudioCnt.Text = VMGM.NumberOfAudioStreamsInVMGM_VOBS
            Me.lblVMG_Aud_Compression.Text = VMGM.AudAttsVMGM_VOBS.CodingMode.ToString
            Me.lblVMG_Aud_Quan.Text = Replace(VMGM.AudAttsVMGM_VOBS.Quantization.ToString, "_", "")
            Me.lblVMG_Aud_SampRate.Text = Replace(VMGM.AudAttsVMGM_VOBS.SampleRate.ToString, "_", "")

            'VMGM SUBPICTURE STREAMS
            Me.lblVMG_SubCount.Text = VMGM.NumberOfSubpictureStreamsInVMGM_VOBS
            Me.lblVMG_Sub_Compression.Text = VMGM.SubAttsVMGM_VOBS.CodingMode.ToString
            Me.lblVMG_Sub_Lang.Text = VMGM.SubAttsVMGM_VOBS.LangCode(0).ToString & VMGM.SubAttsVMGM_VOBS.LangCode(1).ToString
            Me.lblVMG_Sub_LangCodeEx.Text = VMGM.SubAttsVMGM_VOBS.LangCodeEx.ToString
            Me.lblVMG_Sub_LangSpecified.Text = VMGM.SubAttsVMGM_VOBS.LangSpecified

        Catch ex As Exception
            Debug.WriteLine("Problem with PopulateIFOInfo. Error: " & ex.Message)
        End Try
    End Sub

    Public Sub PopulateVTS()
        Try

        Catch ex As Exception
            MsgBox("Problem with PopulateVTS. Error: " & ex.Message)
        End Try
    End Sub

    Public Sub ChangeVMGGTT(ByVal NewGTT As Byte)
        Try
            Dim VMGGTTs As colGlobalTTS = CurrentDVD.VMGM.GlobalTTs
            Me.lblVMG_GTT_AngCount.Text = VMGGTTs(NewGTT).NumberOfAngles
            Me.lblVMG_GTT_BtnCmd.Text = VMGGTTs(NewGTT).Type.ButtonCommand
            Me.lblVMG_GTT_CellCmd.Text = VMGGTTs(NewGTT).Type.CellCommand
            Me.lblVMG_GTT_ParentVTS.Text = VMGGTTs(NewGTT).VTSN
            Me.lblVMG_GTT_PMask.Text = VMGGTTs(NewGTT).ParentalManagementMask
            Me.lblVMG_GTT_PrePostCmd.Text = VMGGTTs(NewGTT).Type.PrePostCommand
            Me.lblVMG_GTT_PTTCnt.Text = VMGGTTs(NewGTT).NumberOfChapters
            Me.lblVMG_GTT_PTTPlaySearch.Text = VMGGTTs(NewGTT).Type.UOPPTTPlayOrSearch
            Me.lblVMG_GTT_Sequential.Text = VMGGTTs(NewGTT).Type.Sequential
            Me.lblVMG_GTT_TimePlaySearch.Text = VMGGTTs(NewGTT).Type.UOPTimePlayOrSearch
            Me.lblVMG_GTT_VTSTT.Text = VMGGTTs(NewGTT).VTS_TTN
        Catch ex As Exception
            MsgBox("Problem with ChangeVMGGTT. Error: " & ex.Message)
        End Try
    End Sub

    Private Sub nudVMG_GTT_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudVMG_GTT.ValueChanged
        Me.ChangeVMGGTT(Me.nudVMG_GTT.Value - 1)
    End Sub

    Public Sub ChangeVTS(ByVal NewVTS As Byte)
        Try

        Catch ex As Exception
            MsgBox("Problem with ChangeVTS. Error: " & ex.Message)
        End Try
    End Sub

    Private Sub nudCurrentVTS_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudCurrentVTS.ValueChanged
        ChangeVTS(Me.nudCurrentVTS.Value)
    End Sub

#End Region 'IFOs

#Region "JACKET PICTURES"

    Public HR As Integer

    Public JacketPicturesExist As Boolean = False

    Public Sub PopulateJacketPictures()
        Dim JPPath As String = DVDPath & ":\JACKET_P\"
        If Directory.Exists(JPPath) Then
            Me.JacketPicturesExist = True
            Dim Files() As String = Directory.GetFileSystemEntries(JPPath)
            Me.lbJacketPics.Items.Clear()
            For Each s As String In Files
                Me.lbJacketPics.Items.Add(Path.GetFileName(s))
            Next
        Else
            VW.Visible = False
            Me.JacketPicturesExist = False
        End If
    End Sub

    Private Sub lbJacketPics_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbJacketPics.SelectedIndexChanged
        DisplayProjectJP(Me.lbJacketPics.SelectedItem.ToString)
    End Sub

    Public VW As frmViewer
    Public Sub SetupViewer()
        Try
            VW = New frmViewer(Me)
            VW_HNDL = VW.Handle
            VW.Left = Me.Left + Me.Width
            VW.Top = Me.Top
            VW.Visible = False
        Catch ex As Exception
            AddConsoleLine("Problem setting up viewer. Error: " & ex.Message)
        End Try
    End Sub

#Region "Filter Graph"

    Public CurrentGraphVideoStandard As eVideoStandard = eVideoStandard.NTSC
    Public JPGraphIsBuilt As Boolean = False
    Public Function DisplayProjectJP(ByVal JPName As String) As Boolean
        Try
            'Valid values for JPName
            'For NTSC:
            'J00___5L.MP2 720 x 480
            'J00___5M.MP2 176 x 112
            'J00___5S.MP2 96 x 64

            'For PAL:
            'J00___6L.MP2 720 x 576
            'J00___6M.MP2 176 x 144
            'J00___6S.MP2 96 x 80

            Me.pnlJP_OneMoment.BringToFront()
            Me.pnlJP_OneMoment.Show()
            Me.Refresh()

            If Not JPGraphIsBuilt Then
                If Not Me.SetupGraphStub Then Return False
                If Not Me.AddKeystone(GraphBuilder) Then Return False
                If Not Me.AddVMR9(GraphBuilder, 1) Then Return False
                If Not Me.AddNVidiaVideoDecoder(GraphBuilder) Then Return False

                HR = GraphBuilder.Connect(Me.VidDec_Vid_Out, Me.Key_In)
                If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

                HR = GraphBuilder.Connect(Me.Key_Out, Me.VMR9_In_1)
                If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

                VideoWin.put_Owner(VW_HNDL)
                VideoWin.put_WindowStyle(WS_CHILD Or WS_CLIPSIBLINGS Or WS_CLIPCHILDREN)
                VideoWin.put_MessageDrain(VW_HNDL)

                'SetVidWinSize(JPName)

                HR = MediaCtrl.Run()
                If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
                JPGraphIsBuilt = True

            End If

            SetVidWinSize(JPName)

            VW.Text = JPName

            JPName = DVDPath & ":\JACKET_P\" & JPName

            'TODO: IMPORTANT - w,h must be automated
            HR = Me.iKeystone.ShowJacketPicture(JPName, 0, 0, 720, 480)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            VW.Visible = True

            Me.pnlJP_OneMoment.Hide()

        Catch ex As Exception
            Me.AddConsoleLine("Problem with DisplayProjectJP. Error: " & ex.Message)
        End Try
    End Function

    Public Sub SetVidWinSize(ByVal JPName As String)
        Try
            Dim W, H As Short
            Select Case JPName.ToLower
                Case "j00___5l.mp2"
                    W = 720
                    H = 480
                Case "j00___5m.mp2"
                    W = 176
                    H = 112
                Case "j00___5s.mp2"
                    W = 96
                    H = 64
                Case "j00___6l.mp2"
                    W = 720
                    H = 576
                Case "j00___6m.mp2"
                    W = 176
                    H = 144
                Case "j00___6s.mp2"
                    W = 96
                    H = 80
            End Select
            VW.Width = W + 4 + 4
            VW.Height = H + 4 + 22
            VW.Left = Me.Left + Me.Width
            VW.Top = Me.Top

            Debug.WriteLine("Client width: " & VW.ClientSize.Width)
            Debug.WriteLine("Client height: " & VW.ClientSize.Height)

            'Dim r As New VMR9NormalizedRect
            'r.top = 0
            'r.left = 0
            'r.bottom = H
            'r.left = W
            'Dim ip As IntPtr = GetPointerFromObject(r)
            'HR = Me.VMRMixerControl.SetOutputRect(0, ip.ToInt32)
            'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            VideoWin.SetWindowPosition(0, 0, VW.ClientRectangle.Width, VW.ClientRectangle.Height)
            'VideoWin.SetWindowPosition(0, 0, 200, 100)


        Catch ex As Exception
            Me.AddConsoleLine("Problem with SetVidWinSize. Error: " & ex.Message)
        End Try
    End Sub

    Public GraphBuilder As IGraphBuilder
    Public MediaCtrl As IMediaControl
    Public MediaEvt As IMediaEventEx

    Public Keystone As IBaseFilter

    Public Key_In, Key_Out As IPin
    Public iKeystone As IKeystone_SD
    Public iKeystoneMixer As IKeystoneMixer_SD
    Public iKeystoneQuality As IKeystoneQuality_SD
    Public iKeystoneProcAmp As IKeystoneProcAmp_SD
    Public Keystone_PP As ISpecifyPropertyPages

    Public VMR9 As IBaseFilter
    Public VideoWin As IVideoWindow
    Public VMRFilterConfig As IVMRFilterConfig9
    Public VMRAspectRatio As IVMRAspectRatioControl9
    Public VMRMixerBitmap As IVMRMixerBitmap9
    Public VMRMixerControl As IVMRMixerControl9
    Public VMR9_In_1 As IPin
    Public VideoRenderer_PP As ISpecifyPropertyPages

    Public Shared ReadOnly IBaseFilter_GUID As Guid = New System.Guid("56a86895-0ad4-11ce-b03a-0020af0ba770")
    Public Shared ReadOnly IGraphBuilder_GUID As Guid = New System.Guid("56a868a9-0ad4-11ce-b03a-0020af0ba770")

    Public WM_DVD_EVENT As Integer = &H8002 ' message from dvd graph
    Public VW_HNDL As IntPtr
    Public WS_CHILD As Integer = &H40000000 ' attributes for video window
    Public WS_CLIPCHILDREN As Integer = &H2000000
    Public WS_CLIPSIBLINGS As Integer = &H4000000

    Public Function SetupGraphStub() As Boolean
        Try
            If GraphBuilder Is Nothing Then
                GraphBuilder = DsBugWO.CreateDsInstance(Clsid.FilterGraphManager, IGraphBuilder_GUID)
                AddGraphToROT(GraphBuilder)
            End If
            VideoWin = CType(GraphBuilder, IVideoWindow)
            MediaCtrl = CType(GraphBuilder, IMediaControl)
            MediaEvt = CType(GraphBuilder, IMediaEvent)
            MediaEvt.SetNotifyWindow(Me.Handle, WM_DVD_EVENT, IntPtr.Zero)
            Return True
        Catch ex As Exception
            MsgBox("Problem with SetupGraphStub. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public ROTEntries() As String
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

    Public Function AddKeystone(ByRef GB As IGraphBuilder) As Boolean
        Try
            Keystone = CType(DsBugWO.CreateDsInstance(New Guid("fd501043-8ebe-11ce-8183-00aa00577da1"), IBaseFilter_GUID), IBaseFilter)
            HR = GraphBuilder.AddFilter(Keystone, "Keystone (Sequoyan LLC. © 2004-2005)")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            'Keystone_PP = CType(Keystone, ISpecifyPropertyPages)
            iKeystone = CType(Keystone, IKeystone_SD)
            iKeystoneMixer = CType(Keystone, IKeystoneMixer_SD)
            iKeystoneQuality = CType(Keystone, IKeystoneQuality_SD)
            iKeystoneProcAmp = CType(Keystone, IKeystoneProcAmp_SD)
            'SetUpProcAmp()
            iKeystone.UnlockFilter(New Guid("fd501045-8ebe-11ce-8183-00aa00577da1"))
            HR = Keystone.FindPin("Video", Key_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            HR = Keystone.FindPin("Output", Key_Out)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            'later fix this
            HR = iKeystone.ForceOutputConnectSize(720, 480)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            Return True
        Catch ex As Exception
            Me.AddConsoleLine("Problem with AddKeystone. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function AddVMR9(ByRef GB As IGraphBuilder, ByVal NumberOfPins As Short) As Boolean
        Try
            VMR9 = CType(DsBugWO.CreateDsInstance(New Guid("51B4ABF3-748F-4E3B-A276-C828330E926A"), IBaseFilter_GUID), IBaseFilter)
            HR = GraphBuilder.AddFilter(VMR9, "Video Mixing Renderer 9")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            VMRFilterConfig = CType(VMR9, IVMRFilterConfig9)
            VMRAspectRatio = CType(VMR9, IVMRAspectRatioControl9)
            'VideoRenderer_PP = CType(VMR9, ISpecifyPropertyPages)

            HR = VMR9.FindPin("VMR Input0", Me.VMR9_In_1)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            'VMR9 Setup
            '1) Add pins
            HR = VMRFilterConfig.SetNumberOfStreams(Convert.ToUInt32(NumberOfPins))
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            '2)windowed or windowless?
            'use windowed, windowless is buggy, or so says Yaron/InMatrix
            HR = VMRFilterConfig.SetRenderingMode(VMR9Mode.VMR9Mode_Windowed)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            '3) Aspect ratio
            HR = VMRAspectRatio.SetAspectRatioMode(VMR9AspectRatioMode.VMR9ARMode_None)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

            '4) Get Mixer Control
            VMRMixerControl = CType(VMR9, IVMRMixerControl9)

            Return True
        Catch ex As Exception
            Me.AddConsoleLine("Problem with AddVMR9. Error: " & ex.Message)
            Return False
        End Try
    End Function

#Region "nVidia Video Decoder"

    Public VSDecoder As IBaseFilter
    Public nvVideoAtts As NvSharedLib.INvAttributes
    Public VideoDecoder_PP As ISpecifyPropertyPages
    Public VidDec_Vid_In As IPin
    Public VidDec_Vid_Out As IPin

    Public Function AddNVidiaVideoDecoder(ByRef GB As IGraphBuilder) As Boolean
        Try
            VSDecoder = CType(DsBugWO.CreateDsInstance(New Guid("71E4616A-DB5E-452B-8CA5-71D9CC7805E9"), IBaseFilter_GUID), IBaseFilter)
            HR = GraphBuilder.AddFilter(VSDecoder, "NVIDIA Video Decoder")
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            nvVideoAtts = CType(VSDecoder, NvSharedLib.INvAttributes)
            InitializeVideoDecoder()
            'VideoDecoder_PP = CType(VSDecoder, ISpecifyPropertyPages)
            HR = VSDecoder.FindPin("Video Input", VidDec_Vid_In)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            HR = VSDecoder.FindPin("Video Output", VidDec_Vid_Out)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            Return True
        Catch ex As Exception
            Me.AddConsoleLine("Problem with AddNVVideoDecoder. Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Sub InitializeVideoDecoder()
        Try
            If nvVideoAtts Is Nothing Then Exit Sub
            nvVideoAtts.SetLong(nvcommon.ENvVideoDecoderProps.NVVIDDEC_CONFIG, nvcommon.ENvidiaVideoDecoderProps_ConfigTypes.NVVIDDEC_CONFIG_DEINTERLACE_CONTROL, nvcommon.ENVVIDDEC_CONFIG_DEINTERLACE_MODE_CTRL.NVVIDDEC_CONFIG_DEINTERLACE_CTRL_FILM)
            nvVideoAtts.SetLong(nvcommon.ENvVideoDecoderProps.NVVIDDEC_CONFIG, nvcommon.ENvidiaVideoDecoderProps_ConfigTypes.NVVIDDEC_CONFIG_DEINTERLACE_MODE, nvcommon.ENVVIDDEC_CONFIG_DEINTERLACE_MODE.NVVIDDEC_CONFIG_DEINTERLACE_FILTERED_WEAVE)
            nvVideoAtts.SetLong(nvcommon.ENvVideoDecoderProps.NVVIDDEC_CONFIG, nvcommon.ENvidiaVideoDecoderProps_ConfigTypes.NVVIDDEC_CONFIG_DISABLE_TRAY_ICON, 1)
            nvVideoAtts.SetLong(nvcommon.ENvVideoDecoderProps.NVVIDDEC_CONFIG, nvcommon.ENvidiaVideoDecoderProps_ConfigTypes.NVVIDDEC_CONFIG_SET_GOPTC_AS_MEDIA_TIME, 1)
            'SetVideoStandardViaInterface(True)
        Catch ex As Exception
            AddConsoleLine("Problem initializing video decoder. Error: " & ex.Message)
        End Try
    End Sub

#End Region 'nVidia Video Decoder

#End Region 'Filter Graph

#End Region 'JACKET PICTURES

#Region "LAYERBREAK"

    Public Sub PopulateLayerbreak()
        SetupNonSeamlessCells(DVDPath)
    End Sub

    Private Sub nudLBMulti_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudLBMulti.ValueChanged
        Try
            Dim cnt As Short = 0
            If Me.nudLBMulti.Value = 0 Then
                Me.lblLB_Multi_CH.Text = "0"
                Me.lblLB_Multi_RT.Text = "0"
                Me.lblLB_Multi_ST.Text = "TODO"
                Me.lblLB_Multi_TT.Text = "0"
            Else
                For Each nsc As cNonSeamlessCell In NSCs
                    If nsc.CandidateLayerbreak Then
                        cnt += 1
                        If Me.nudLBMulti.Value = cnt Then
                            Me.lblLB_Multi_CH.Text = nsc.PTT
                            Me.lblLB_Multi_RT.Text = Replace(nsc.LBTC, "/ 30fps", "", 1, -1, CompareMethod.Text)
                            Me.lblLB_Multi_ST.Text = "TODO"
                            Me.lblLB_Multi_TT.Text = nsc.GTTn
                            Exit Sub
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            Me.AddConsoleLine("Problem with multiLB select. Error: " & ex.Message)
        End Try
    End Sub

    Public NSCs As colNonSeamlessCells

    Private _Layerbreak As cNonSeamlessCell
    Public Property Layerbreak() As cNonSeamlessCell
        Get
            Return _Layerbreak
        End Get
        Set(ByVal Value As cNonSeamlessCell)
            _Layerbreak = Value
            Me.lblLB_CH.Text = Value.PTT
            Me.lblLB_TT.Text = Value.GTTn
            Me.lblLB_RT.Text = Replace(Value.LBTC, "/ 30fps", "", 1, -1, CompareMethod.Text)
            Me.lblLB_SourceTime.Text = "TODO"
        End Set
    End Property

    Public Function SetupNonSeamlessCells(ByVal Dir As String) As Boolean
        Try
            If IsProjectDualLayer(Dir) Then
                NSCs = CurrentDVD.GetNonSeamlessCells()

                If NSCs.CandidateLayerbreaks = 1 Then
                    Layerbreak = NSCs.ConfirmedLayerbreak
                    Me.pnlLikelyLayerbreak.Show()
                    Me.pnlLBsMulti.Hide()
                    Me.pnlNoCandidateLBs.Hide()
                ElseIf NSCs.CandidateLayerbreaks = 0 Then
                    Me.pnlLikelyLayerbreak.Hide()
                    Me.pnlLBsMulti.Hide()
                    Me.pnlNoCandidateLBs.Show()
                Else
                    Me.pnlLikelyLayerbreak.Hide()
                    Me.pnlLBsMulti.Show()
                    Me.pnlNoCandidateLBs.Hide()
                    Me.lblLB_Multi_cnt.Text = NSCs.CandidateLayerbreaks
                    Me.nudLBMulti.Maximum = NSCs.CandidateLayerbreaks
                    Me.nudLBMulti.Minimum = 0
                End If
            Else
                Me.pnlLikelyLayerbreak.Hide()
                Me.pnlLBsMulti.Hide()
                Me.pnlNoCandidateLBs.Show()
            End If
            Return True
        Catch ex As Exception
            AddConsoleLine("Problem with SetupNonSeamlessCells. Error: " & ex.Message)
            Return False
        End Try
    End Function

#End Region 'LAYERBREAK

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Debug.WriteLine(CurrentDVD.HasCallSSRSM127)
            Debug.WriteLine(CurrentDVD.CallSSRSM127_Location(0))
        Catch ex As Exception
            Debug.WriteLine("Problem: " & ex.Message)
        End Try
    End Sub

End Class
