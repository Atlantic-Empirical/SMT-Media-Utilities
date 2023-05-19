Module SpareCode

    '#Region "DVD Navigator Related"

    '#Region "Handle DVD Navigator Events"

    '    Public DVDIsInStill As Boolean = False

    '    Public Sub OnDvdEvent()
    '        Dim hr, p1, p2 As Integer
    '        Dim code As DsEvCode
    '        Do
    '            If MediaEvt Is Nothing Then Exit Sub
    '            hr = MediaEvt.GetEvent(code, p1, p2, 0)
    '            'Debug.WriteLine("DsEvCode: " & Convert.ToInt32(code))
    '            If hr < 0 Then Exit Do
    '            DVDEventHandler(code, p1, p2)
    '            hr = MediaEvt.FreeEventParams(code, p1, p2)
    '        Loop While hr = 0
    '    End Sub

    '    Public Sub DVDEventHandler(ByVal code As DsEvCode, ByVal p1 As Integer, ByVal p2 As Integer)
    '        Try
    '            If Not code = DsEvCode.DvdCurrentHmsfTime Then
    '                Debug.WriteLine("DVD EVT: " + code.ToString())
    '            End If
    '            Dim HR As Integer
    '            Select Case code
    '                Case DsEvCode.DvdCurrentHmsfTime
    '                    If Me.DVDStartPauseSetItNow Then
    '                        'DVDStartPauseSetItNow = False
    '                        'HR = MediaCtrl.Pause()
    '                        'If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
    '                    End If

    '                    Dim ati As Byte() = BitConverter.GetBytes(p1)
    '                    currnTime.bHours = ati(0)
    '                    currnTime.bMinutes = ati(1)
    '                    currnTime.bSeconds = ati(2)
    '                    currnTime.bFrames = ati(3)
    '                    UpdateFrameCaption()

    '                Case DsEvCode.VMRRenderDeviceSet
    '                    Select Case p1
    '                        Case 1
    '                            Debug.WriteLine("VMR RENDERER: Overlay")
    '                        Case 2
    '                            Debug.WriteLine("VMR RENDERER: Video Memory")
    '                        Case 4
    '                            Debug.WriteLine("VMR RENDERER: System Memory")
    '                    End Select

    '                Case DsEvCode.DvdChaptStart
    '                    ChapterChange(p1)
    '                    PingLB()
    '                    GetRegisters()
    '                    'SetAR("ChapterStart")

    '                Case DsEvCode.DvdTitleChange
    '                    TitleChange(p1)
    '                    SubtitleStreamChanged()
    '                    GetRegisters()
    '                    'SetAR("DVDTitleChange Event")

    '                Case DsEvCode.DvdDomChange
    '                    DomainChanged(p1)
    '                    GetRegisters()
    '                    'SetAR("DVDDomainChange Event")

    '                Case DsEvCode.DvdCmdStart
    '                    If pendingCmd Then Trace.WriteLine("DvdCmdStart with pending")

    '                Case DsEvCode.DvdCmdEnd
    '                    OnCmdComplete(p1, p2)

    '                Case DsEvCode.DvdStillOn
    '                    GetRegisters()
    '                    'SetAR("DVDStillOn Event")
    '                    If p1 = 0 Then
    '                        menuMode = menuMode.Buttons
    '                        DVDIsInStill = True
    '                    Else
    '                        menuMode = menuMode.Still
    '                    End If

    '                Case DsEvCode.DvdStillOff
    '                    If menuMode = menuMode.Still Then
    '                        menuMode = menuMode.No
    '                    End If
    '                    DVDIsInStill = False
    '                    GetRegisters()

    '                Case DsEvCode.DvdButtonChange
    '                    If p1 <= 0 Then
    '                        menuMode = menuMode.No
    '                    Else
    '                        menuMode = menuMode.Buttons
    '                    End If
    '                    'SetAR("DVDButtonChange Event")
    '                    GetRegisters()

    '                Case DsEvCode.DvdNoFpPgc
    '                    If Not (DVDCtrl Is Nothing) Then
    '                        AddConsoleLine("No First Play PGC. Playing Title 1")
    '                        HR = DVDCtrl.PlayTitle(1, DvdCmdFlags.None, Nothing)
    '                        If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
    '                    End If

    '                Case DsEvCode.DvdAudioStChange
    '                    AudioStreamChanged()
    '                    GetRegisters()

    '                Case DsEvCode.DvdSubPicStChange
    '                    SubtitleStreamChanged()
    '                    GetRegisters()

    '                Case DsEvCode.DvdAngleChange
    '                    AngleChanged()
    '                    GetRegisters()

    '                Case DsEvCode.DvdParentalLChange
    '                    HandleParentalLevelChange(code, p1, p2)
    '                    GetRegisters()

    '                Case DsEvCode.DvdValidUopsChange
    '                    HandleUOPChange(p1)
    '                    GetRegisters()

    '                Case DsEvCode.DvdError
    '                    Dim es As String = GetDVDErrorString(p1)
    '                    If InStr(es.ToLower, "incompatiblediscanddecoderregions", CompareMethod.Text) Or InStr(es.ToLower, "incompatiblesystemanddecoderregions", CompareMethod.Text) Or InStr(es, "DVD_ERROR_InvalidDiscRegion", CompareMethod.Text) Then
    '                        If MsgBox("The disc region does not match the region selected in emulator setup.") = MsgBoxResult.OK Then
    '                            Me.EjectProject(True)
    '                            CN.ClearConsole()
    '                        End If
    '                    End If
    '                    AddConsoleLine("dvd error, Ps: " & es & " | " & p2)

    '                Case DsEvCode.DvdWarning
    '                    AddConsoleLine("dvd warning, Ps: " & GetDVDWarningString(p1) & " | " & p2)

    '                Case DsEvCode.DvdPlaybStopped
    '                    'AddConsoleLine("dvd playback stopped, Ps: " & GetPlaybackStoppedString(p1) & " | " & p2)
    '                    HandleStop()
    '                    GetRegisters()
    '            End Select
    '        Catch ex As Exception
    '            Me.AddConsoleLine("Problem with DVDEventHandler. Error: " & ex.Message)
    '        End Try
    '    End Sub

    '    Public Sub DomainChanged(ByVal p1 As Integer)
    '        Try
    '            'currnDomain = CType(p1, DvdDomain)
    '            TitleChange("GetTitle")

    '            If Not playState = ePlayState.SystemJP Then
    '                Me.lblCurrentDomain.Text = currnDomain.ToString
    '            End If

    '            UpdateFrameCaption()

    '            Select Case currnDomain
    '                Case DvdDomain.FirstPlay
    '                Case DvdDomain.Stop
    '                Case DvdDomain.Title
    '                    RM.btnGoUp.Enabled = False
    '                Case DvdDomain.VideoManagerMenu
    '                    RM.btnGoUp.Enabled = True
    '                Case DvdDomain.VideoTitleSetMenu
    '                    RM.btnGoUp.Enabled = True

    '            End Select

    '        Catch ex As Exception
    '            Me.AddConsoleLine("Problem with DomainChanged. Error: " & ex.Message)
    '        End Try
    '    End Sub

    '    Public Sub HandleStop()
    '        Try
    '            'If playState = ePlayState.Init Or playState = ePlayState.Playing Then Exit Sub
    '            'If Not playState = ePlayState.Ejecting Then
    '            '    If CloseGraph("HandleStop") Then
    '            '        DisplayJP("HandleStop")
    '            '    End If
    '            'End If
    '        Catch ex As Exception
    '            AddConsoleLine("Problem handling stop. Error: " & ex.Message)
    '        End Try
    '    End Sub

    '    Public UOPVals() As Boolean
    '    Public Sub HandleUOPChange(ByVal P1 As Integer)
    '        Try
    '            If playState = ePlayState.SystemJP Then
    '                P1 = 0
    '            End If

    '            'Debug.WriteLine(P1 & vbNewLine)
    '            If Not AD.aUOPs Then Exit Sub

    '            If Len(CStr(P1)) > 8 Then
    '                MsgBox("UOP value is too big.")
    '                Exit Sub
    '            End If

    '            '1) convert p1 to binary
    '            Dim Bin As String = DecimalToBinary(P1)

    '            '2) Populate an array of the values in Bin
    '            If Bin.Length <> 25 Then
    '                Bin = PadString(Bin, 25, "0", True)
    '            End If

    '            Bin = Microsoft.VisualBasic.StrReverse(Bin)

    '            ReDim UOPVals(24)
    '            For i As Short = 0 To 24
    '                UOPVals(i) = CBool(Bin.Chars(i).ToString)
    '                If UOPVals(i) = True Then
    '                    UOPVals(i) = False
    '                Else
    '                    UOPVals(i) = True
    '                End If
    '            Next

    '            '3) Display the values
    '            Me.uop_0.BackColor = GetBoolColor(UOPVals(0))
    '            Me.uop_1.BackColor = GetBoolColor(UOPVals(1))
    '            Me.uop_2.BackColor = GetBoolColor(UOPVals(2))
    '            Me.uop_3.BackColor = GetBoolColor(UOPVals(3))
    '            Me.uop_4.BackColor = GetBoolColor(UOPVals(4))
    '            Me.uop_5.BackColor = GetBoolColor(UOPVals(5))
    '            Me.uop_6.BackColor = GetBoolColor(UOPVals(6))
    '            Me.uop_7.BackColor = GetBoolColor(UOPVals(7))
    '            Me.uop_8.BackColor = GetBoolColor(UOPVals(8))
    '            Me.uop_9.BackColor = GetBoolColor(UOPVals(9))
    '            Me.uop_10.BackColor = GetBoolColor(UOPVals(10))
    '            Me.uop_11.BackColor = GetBoolColor(UOPVals(11))
    '            Me.uop_12.BackColor = GetBoolColor(UOPVals(12))
    '            Me.uop_13.BackColor = GetBoolColor(UOPVals(13))
    '            Me.uop_14.BackColor = GetBoolColor(UOPVals(14))
    '            Me.uop_15.BackColor = GetBoolColor(UOPVals(15))
    '            Me.uop_16.BackColor = GetBoolColor(UOPVals(16))
    '            Me.uop_17.BackColor = GetBoolColor(UOPVals(17))
    '            Me.uop_18.BackColor = GetBoolColor(UOPVals(18))
    '            Me.uop_19.BackColor = GetBoolColor(UOPVals(19))
    '            Me.uop_20.BackColor = GetBoolColor(UOPVals(20))
    '            Me.uop_21.BackColor = GetBoolColor(UOPVals(21))
    '            Me.uop_22.BackColor = GetBoolColor(UOPVals(22))
    '            Me.uop_23.BackColor = GetBoolColor(UOPVals(23))
    '            Me.uop_24.BackColor = GetBoolColor(UOPVals(24))
    '            RM.SetRemoteUOPs(UOPVals)
    '        Catch ex As Exception
    '            AddConsoleLine("problem handling uop change. error: " & ex.Message)
    '        End Try
    '    End Sub

    '    Private Sub HandleParentalLevelChange(ByVal DsEv As DsEvCode, ByVal P1 As Integer, ByVal P2 As Integer)
    '        Try
    '            Dim HR As Integer
    '            Dim CurrentPlayerLevel As Integer = SU.cbParentalLevel.SelectedIndex + 1
    '            'this assumes that p1 is an integer between 1 and 8, hopefully it is but if not see ParentalManagement in the documentation
    '            If P1 > CurrentPlayerLevel Then
    '                HR = DVDCtrl.AcceptParentalLevelChange(False)
    '            Else
    '                HR = DVDCtrl.AcceptParentalLevelChange(True)
    '            End If
    '            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
    '        Catch ex As Exception
    '            AddConsoleLine("problem with handleparentallevelchange. Error: " & ex.Message)
    '        End Try
    '    End Sub

    '    Public Sub StartPlaybackEvent()
    '        Try
    '            Dim HR As Integer

    '            'Volume Info
    '            Dim NoVols As Integer
    '            Dim CurVol As Integer
    '            Dim DiscSide As DvdDiscSide
    '            Dim NoTTs As Integer
    '            HR = DVDInfo.GetDVDVolumeInfo(NoVols, CurVol, DiscSide, NoTTs)
    '            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
    '            Me.lblVolumes.Text = NoVols
    '            Me.lblCurrentVol.Text = CurVol
    '            Me.lblDiscSide.Text = DiscSide.ToString

    '            'available titles
    '            RM.cbTitles.Items.Clear()
    '            For i As Short = 1 To NoTTs
    '                RM.cbTitles.Items.Add(i)
    '            Next

    '            'available menu languages
    '            Dim Langs(99) As Integer
    '            Dim LangCount As Integer
    '            HR = DVDInfo.GetMenuLanguages(Langs, 15, LangCount)
    '            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
    '            Me.lbAvailableMenuLanguages.Items.Clear()
    '            For Each Lang As Integer In Langs
    '                If Not Lang = "0" Then Me.lbAvailableMenuLanguages.Items.Add(Me.GetLanguageByLCID(Lang))
    '            Next

    '            'disc text
    '            Me.lblDVDText.Text = GetDVDText()
    '            If Not Me.lblDVDText.Text = "Null" And Not Me.lblDVDText.Text = "" Then
    '                VW.Text = "Phoenix - " & Me.lblDVDText.Text
    '            Else
    '                If InStr(Me.DVDDirectory.ToLower, "d:\", CompareMethod.Text) Then
    '                    VW.Text = " " & Me.GetVolumeLabel("D") & " disc in DVD Drive"
    '                End If
    '            End If

    '            'Region settings
    '            Dim VMGMAtts As DvdMenuAttr
    '            HR = DVDInfo.GetVMGAttributes(VMGMAtts)
    '            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
    '            SetTitleRegion(VMGMAtts.compatibleRegion)

    '            'Emulator Setup Button
    '            RM.btnEmulatorSetup.Enabled = False

    '            'UOPs
    '            GetRegisters()

    '            'Default Languages
    '            Me.lblPlayerAudioLang.Text = Me.GetDefaultAudioLang(True)
    '            Me.lblPlayerMenuLang.Text = Me.GetDefaultMenuLang
    '            Me.lblPlayerSubLang.Text = Me.GetDefaultSubtitleLang(True)
    '        Catch ex As Exception
    '            If InStr(ex.Message.ToLower, "object reference", CompareMethod.Text) Then
    '                Exit Sub
    '            End If
    '            If Not InStr(ex.Message, "80040291", CompareMethod.Text) > 0 Then
    '                AddConsoleLine("problem with startplaybackevent. Error: " & ex.Message)
    '            End If
    '        End Try
    '    End Sub

    '    Public TitleRegion() As Boolean
    '    Public Sub SetTitleRegion(ByVal Regions() As Boolean)
    '        ReDim TitleRegion(8)
    '        For i As Short = 0 To 7
    '            If Regions(i) = "0" Then
    '                TitleRegion(i + 1) = True
    '            Else
    '                TitleRegion(i + 1) = False
    '            End If
    '        Next

    '        'first check to see if this region is ok to play with current license
    '        If TitleRegion(1) And AD.aRegion1 Then GoTo RegionIsOK
    '        If TitleRegion(2) And AD.aRegion2 Then GoTo RegionIsOK
    '        If TitleRegion(3) And AD.aRegion3 Then GoTo RegionIsOK
    '        If TitleRegion(4) And AD.aRegion4 Then GoTo RegionIsOK
    '        If TitleRegion(5) And AD.aRegion5 Then GoTo RegionIsOK
    '        If TitleRegion(6) And AD.aRegion6 Then GoTo RegionIsOK
    '        If TitleRegion(7) And AD.aRegion7 Then GoTo RegionIsOK
    '        If TitleRegion(8) And AD.aRegion8 Then GoTo RegionIsOK
    '        AddConsoleLine("Disc's region has not been licnesed for emulation.")
    '        EjectProject(True)
    'RegionIsOK:

    '        Me.Reg_1.BackColor = GetBoolColor(TitleRegion(1))
    '        Me.Reg_2.BackColor = GetBoolColor(TitleRegion(2))
    '        Me.Reg_3.BackColor = GetBoolColor(TitleRegion(3))
    '        Me.Reg_4.BackColor = GetBoolColor(TitleRegion(4))
    '        Me.Reg_5.BackColor = GetBoolColor(TitleRegion(5))
    '        Me.Reg_6.BackColor = GetBoolColor(TitleRegion(6))
    '        Me.Reg_7.BackColor = GetBoolColor(TitleRegion(7))
    '        Me.Reg_8.BackColor = GetBoolColor(TitleRegion(8))

    '        TitleRegion(0) = Nothing
    '    End Sub

    '    Public Sub ResetRegions()
    '        Me.Reg_1.BackColor = GetBoolColor(True)
    '        Me.Reg_2.BackColor = GetBoolColor(True)
    '        Me.Reg_3.BackColor = GetBoolColor(True)
    '        Me.Reg_4.BackColor = GetBoolColor(True)
    '        Me.Reg_5.BackColor = GetBoolColor(True)
    '        Me.Reg_6.BackColor = GetBoolColor(True)
    '        Me.Reg_7.BackColor = GetBoolColor(True)
    '        Me.Reg_8.BackColor = GetBoolColor(True)
    '    End Sub

    '    Public TitleAutoChange As Boolean = False
    '    Public Sub TitleChange(ByVal TTNo As String) 'or domain change
    '        Try
    '            If TTNo = "GetTitle" Then
    '                Dim L As DvdPlayLocation
    '                DVDInfo.GetCurrentLocation(L)
    '                TTNo = L.TitleNum
    '                If TTNo = 0 Then
    '                    Me.lblCurrent_TT.Text = "M"
    '                    PopulateVideoTab("TitleChange")
    '                    lblTotalTTTC.Text = "0:00:00"
    '                    Exit Sub
    '                End If
    '            End If

    '            UpdateFrameCaption()
    '            currnTitle = TTNo
    '            TitleAutoChange = True
    '            RM.cbTitles.SelectedIndex = RM.cbTitles.FindStringExact(TTNo)
    '            TitleAutoChange = False

    '            Dim HR As Integer

    '            'Chapter count for TT
    '            Dim ChCount As Integer
    '            HR = DVDInfo.GetNumberOfChapters(TTNo, ChCount)
    '            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
    '            CurrentTitleChapterCount = ChCount
    '            RM.cbChapters.Items.Clear()
    '            For i As Integer = 1 To ChCount
    '                RM.cbChapters.Items.Add(i)
    '            Next

    '            'Angles for TT
    '            Dim CurrentAngle, AngleCount As Integer
    '            HR = DVDInfo.GetCurrentAngle(AngleCount, CurrentAngle)
    '            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
    '            Me.lbAvailAngles.Items.Clear()
    '            For i As Short = 1 To AngleCount
    '                Me.lbAvailAngles.Items.Add(i)
    '            Next
    '            Me.lblCurrent_angle.Text = "1"

    '            'Subtitles
    '            Me.SetupSubtitleTab()
    '            SubtitleStreamChanged()

    '            'Audio
    '            SetupAudioTab()
    '            AudioStreamChanged()

    '            'CCs

    '            'Timecode
    '            Dim TC As DvdTimeCode
    '            Dim TC_o As Integer
    '            HR = DVDInfo.GetTotalTitleTime(TC, TC_o)
    '            If HR < 0 Then
    '                If HR = -2147220873 Then GoTo SkipError_1 'it's a white hand for trying to get duration of an infinite still, infinity is a big number
    '                Marshal.ThrowExceptionForHR(HR)
    '            End If

    'SkipError_1:
    '            Dim M, S, F As String
    '            If TC.bMinutes.ToString.Length = 1 Then
    '                M = 0 & TC.bMinutes
    '            Else
    '                M = TC.bMinutes
    '            End If

    '            If TC.bSeconds.ToString.Length = 1 Then
    '                S = 0 & TC.bSeconds
    '            Else
    '                S = TC.bSeconds
    '            End If

    '            'If TC.bFrames.ToString.Length = 1 Then
    '            '    F = 0 & TC.bFrames
    '            'Else
    '            '    F = TC.bFrames
    '            'End If

    '            Me.lblTotalTTTC.Text = TC.bHours & ":" & M & ":" & S '& ";" & F

    '            'TT #
    '            Me.lblCurrent_TT.Text = currnTitle

    '            'Title Attributes
    '            'GetTitleAttributes(TTNo)

    '            'Video Attributes
    '            Me.PopulateVideoTab("TitleChange2")

    '            'Turn on CCs if user desires
    '            'HandleCCsForTitleStart()
    '        Catch ex As Exception
    '            If StartingDVD Then Exit Sub
    '            'If CheckEx(ex, "Title Change") Then Exit Sub
    '            AddConsoleLine("problem on tt change. error: " & ex.Message)
    '        End Try
    '    End Sub

    '    Public Function GetTitleAttributes(ByVal TTNo As Short) As TitleAttributes
    '        Try
    '            Dim TA As New TitleAttributes
    '            Dim HR As Integer = DVDInfo.GetTitleAttributes(TTNo, TA.MA, TA.TA)
    '            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
    '            Return TA
    '        Catch ex As ExecutionEngineException
    '            AddConsoleLine(ex.Message)
    '        End Try
    '    End Function

    '    Public Class TitleAttributes
    '        Public MA As DvdMenuAttr
    '        Public TA As DvdTitleAttr
    '    End Class

    '    Public ChapterAutoChange As Boolean = False
    '    Public Sub ChapterChange(ByVal CHNo As String)
    '        currnChapter = CHNo
    '        UpdateFrameCaption()
    '        ChapterAutoChange = True
    '        RM.cbChapters.SelectedIndex = RM.cbChapters.FindStringExact(CHNo)
    '        ChapterAutoChange = False
    '        Me.lblCurrent_PTT.Text = currnChapter
    '    End Sub

    '    Public Sub UpdateCBChapternTitle()
    '        Try
    '            ChapterAutoChange = True
    '            TitleAutoChange = True
    '            RM.cbChapters.SelectedIndex = RM.cbChapters.FindStringExact(Me.lblCurrent_PTT.Text)
    '            RM.cbTitles.SelectedIndex = RM.cbTitles.FindStringExact(Me.lblCurrent_TT.Text)
    '            ChapterAutoChange = False
    '            TitleAutoChange = False
    '        Catch ex As Exception
    '            'AddConsoleLine("Problem updating cbchapter. Error: " & ex.Message)
    '        End Try
    '    End Sub

    '    Public Sub AudioStreamChanged()
    '        Try
    '            Dim DM As DvdDomain = GetDomain()
    '            If DM = DvdDomain.VideoManagerMenu Or DM = DvdDomain.VideoTitleSetMenu Then Exit Sub
    '            DM = Nothing
    '            Dim NumberOfStreams, CurrentStream As Integer
    '            Dim HR As Integer = DVDInfo.GetCurrentAudio(NumberOfStreams, CurrentStream)
    '            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
    '            Dim A As seqAudio = Me.GetAudio(CurrentStream)
    '            Me.lblCurrentAudio_lang.Text = A.Language
    '            Me.lblCurrentAudio_sn.Text = CurrentStream
    '            Me.lblCurrentAudio_ext.Text = A.Extension
    '            Me.lblCurrentAudio_format.Text = A.Format.ToUpper
    '            A = Nothing
    '        Catch ex As Exception
    '            If StartingDVD Then Exit Sub
    '            If InStr(ex.Message, "80040290", CompareMethod.Text) Then Exit Sub
    '            'If InStr(ex.Message, "80040276", CompareMethod.Text) Then
    '            '    RedHand("Audio stream changed")
    '            '    Exit Sub
    '            'ElseIf InStr(ex.Message, "80040277", CompareMethod.Text) Then
    '            '    'WhiteHand("Audio stream changed")
    '            '    Exit Sub
    '            'End If
    '            AddConsoleLine("problem on audio stream change. error: " & ex.Message)
    '        End Try
    '    End Sub

    '    Public Sub SubtitleStreamChanged()
    '        Try
    '            Dim DM As DvdDomain = GetDomain()
    '            If DM = DvdDomain.VideoManagerMenu Or DM = DvdDomain.VideoTitleSetMenu Then Exit Sub
    '            DM = Nothing
    '            Dim NumberOfStreams, CurrentStream As Integer
    '            Dim OnOff As Boolean
    '            Dim HR As Integer = DVDInfo.GetCurrentSubpicture(NumberOfStreams, CurrentStream, OnOff)
    '            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
    '            Dim S As seqSub = Me.GetSubtitle(CurrentStream)
    '            Me.lblCurrentSP_lang.Text = S.Language
    '            Me.lblCurrentSP_sn.Text = CurrentStream
    '            Me.lblCurrentSP_ext.Text = S.Extension
    '            If OnOff Then
    '                Me.lblCurrentSP_lang.Text = "Off"
    '                Me.lblCurrentSP_sn.Text = ""
    '                Me.lblCurrentSP_ext.Text = ""
    '            Else
    '                RM.btnToggleSubs.BackColor = SystemColors.ControlDarkDark
    '            End If
    '            S = Nothing
    '        Catch ex As Exception
    '            If StartingDVD Then Exit Sub
    '            If InStr(ex.Message, "80040290", CompareMethod.Text) Then Exit Sub
    '            'If InStr(ex.Message, "80040276", CompareMethod.Text) Then
    '            '    RedHand("Subtitle Stream Changed")
    '            '    Exit Sub
    '            'ElseIf InStr(ex.Message, "80040277", CompareMethod.Text) Then
    '            '    WhiteHand("Subtitle Stream Changed")
    '            '    Exit Sub
    '            'End If
    '            AddConsoleLine("problem on subtitle stream change. error: " & ex.Message)
    '        End Try
    '    End Sub

    '    Public Sub AngleChanged()
    '        Try
    '            PopulateVideoTab("AngleChanged")
    '        Catch ex As Exception
    '            If StartingDVD Then Exit Sub
    '            'If InStr(ex.Message, "80040276", CompareMethod.Text) Then
    '            '    RedHand("Angle Changed")
    '            '    Exit Sub
    '            'ElseIf InStr(ex.Message, "80040277", CompareMethod.Text) Then
    '            '    WhiteHand("Angle Changed")
    '            '    Exit Sub
    '            'End If
    '            AddConsoleLine("problem with angle change. error: " & ex.Message)
    '        End Try
    '    End Sub

    '    Public Sub PopulateVideoTab(ByVal Sender As String)
    '        Try
    '            If playState = ePlayState.SystemJP Then
    '                Me.lblVidAtt_aspectratio.Text = ""
    '                Me.lblVidAtt_compression.Text = ""
    '                Me.lblVidAtt_frameheight.Text = ""
    '                Me.lblVidAtt_framerate.Text = ""
    '                Me.lblVidAtt_isFilmMode.Text = ""
    '                Me.lblVidAtt_isSourceLetterboxed.Text = ""
    '                Me.lblVidAtt_lbok.Text = ""
    '                Me.lblVidAtt_line21Field1InGOP.Text = ""
    '                Me.lblVidAtt_line21Field2InGOP.Text = ""
    '                Me.lblVidAtt_psok.Text = ""
    '                Me.lblVidAtt_sourceResolution.Text = ""
    '                Exit Sub
    '            End If

    '            If currnDomain = DvdDomain.Stop Then Exit Sub
    '            Dim VA As DvdVideoAttr
    '            Dim HR As Integer = DVDInfo.GetCurrentVideoAttributes(VA)
    '            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)

    '            If VA.sourceResolutionY = 480 Then
    '                If Not AD.aNTSC Then
    '                    Me.EjectProject(True)
    '                    CN.ClearConsole()
    '                    AddConsoleLine("NTSC video standard not licensed.")
    '                End If
    '            ElseIf VA.sourceResolutionY = 576 Then
    '                If Not AD.aPAL Then
    '                    Me.EjectProject(True)
    '                    CN.ClearConsole()
    '                    AddConsoleLine("PAL video standard not licensed.")
    '                End If
    '            End If

    '            LBPermitted = VA.letterboxPermitted
    '            PSPermitted = VA.panscanPermitted
    '            SourceResolution_X = VA.sourceResolutionX
    '            SourceResolution_Y = VA.sourceResolutionY
    '            AspectRatio_X = VA.aspectX
    '            AspectRatio_Y = VA.aspectY

    '            Me.lblVidAtt_aspectratio.Text = VA.aspectX & " x " & VA.aspectY
    '            Me.lblVidAtt_compression.Text = VA.compression.ToString
    '            Me.lblVidAtt_frameheight.Text = VA.frameHeight
    '            Me.lblVidAtt_framerate.Text = VA.frameRate
    '            Me.lblVidAtt_isFilmMode.Text = VA.isFilmMode.ToString
    '            Me.lblVidAtt_isSourceLetterboxed.Text = VA.isSourceLetterboxed.ToString
    '            Me.lblVidAtt_lbok.Text = VA.letterboxPermitted.ToString
    '            Me.lblVidAtt_line21Field1InGOP.Text = VA.line21Field1InGOP.ToString
    '            Me.lblVidAtt_line21Field2InGOP.Text = VA.line21Field2InGOP.ToString
    '            Me.lblVidAtt_psok.Text = VA.panscanPermitted.ToString
    '            Me.lblVidAtt_sourceResolution.Text = VA.sourceResolutionX & " x " & VA.sourceResolutionY
    '        Catch ex As Exception
    '            AddConsoleLine("problem populating video tab. error: " & ex.Message)
    '        End Try
    '    End Sub

    '    Sub UpdateFrameCaption()
    '        Try
    '            'Current Timecode
    '            Dim M, S, F As String
    '            If currnTime.bMinutes.ToString.Length = 1 Then
    '                M = 0 & currnTime.bMinutes
    '            Else
    '                M = currnTime.bMinutes
    '            End If

    '            If currnTime.bSeconds.ToString.Length = 1 Then
    '                S = 0 & currnTime.bSeconds
    '            Else
    '                S = currnTime.bSeconds
    '            End If

    '            'If currnTime.bFrames.ToString.Length = 1 Then
    '            '    F = 0 & currnTime.bFrames
    '            'Else
    '            '    F = currnTime.bFrames
    '            'End If

    '            Dim ti As String = Microsoft.VisualBasic.Right(currnTime.bHours.ToString, 1) & ":" & M & ":" & S '& ";" & F

    '            If playState = playState.Paused Then
    '                ti = "Paused"
    '            ElseIf playState = playState.Stopped Then
    '                ti = "Stopped"
    '            End If

    '            Me.lblTimecode.Text = ti

    '            GetRegisters()

    '        Catch ex As Exception
    '            AddConsoleLine("problem updating framecaption. error: " & ex.Message)
    '        End Try
    '    End Sub

    '    Sub OnCmdComplete(ByVal p1 As Integer, ByVal hrg As Integer)
    '        'If currnDomain = DvdDomain.VideoManagerMenu Or currnDomain = DvdDomain.VideoTitleSetMenu Then
    '        '    SetAR()
    '        'End If

    '        ' Trace.WriteLine( "DVD OnCmdComplete.........." );
    '        If pendingCmd = False Or DVDInfo Is Nothing Then Return
    '        Dim cmd As IDvdCmd
    '        Dim hr As Integer = DVDInfo.GetCmdFromEvent(p1, cmd)
    '        If hr <> 0 Or cmd Is Nothing Then
    '            Debug.WriteLine("!!!DVD OnCmdComplete GetCmdFromEvent failed!!!")
    '            Return
    '        End If

    '        If Not cmd Is cmdOption.dvdCmd Then
    '            Debug.WriteLine("DVD OnCmdComplete UNKNOWN CMD!!!")
    '            Marshal.ReleaseComObject(cmd)
    '            cmd = Nothing
    '            Return
    '        End If

    '        Marshal.ReleaseComObject(cmd)
    '        cmd = Nothing
    '        Marshal.ReleaseComObject(cmdOption.dvdCmd)
    '        cmdOption.dvdCmd = Nothing
    '        pendingCmd = False
    '        ' Trace.WriteLine( "DVD OnCmdComplete OK." );
    '    End Sub

    '#Region "DVD Event Enums"

    '    Public Function GetDVDErrorString(ByVal P1 As String) As String
    '        Try
    '            Select Case P1
    '                Case 1
    '                    Return "DVD_ERROR_Unexpected"   'Something unexpected happened, perhaps content is incorrectly authored.
    '                Case 2
    '                    Return "DVD_ERROR_CopyProtectFail"  'Key exchange for DVD copy protection failed.
    '                Case 3
    '                    Return "DVD_ERROR_InvalidDVD1_0Disc"    'DVD-Video disc is incorrectly authored for v1.0 of spec.
    '                Case 4
    '                    Return "DVD_ERROR_InvalidDiscRegion"    'The Disc cannot be played because the disc is not authored to play in system region. The region mismatch may be fixable by changing the system region with dvdrgn.exe
    '                Case 5
    '                    Return "DVD_ERROR_LowParentalLevel" 'Player parental level is lower than the lowest parental level available in the DVD content.
    '                Case 6
    '                    Return "DVD_ERROR_MacrovisionFail"  'Macrovision Distribution Failed.
    '                Case 7
    '                    Return "DVD_ERROR_IncompatibleSystemAndDecoderRegions"  'No discs can be played because the system region does not match the decoder region.
    '                Case 8
    '                    Return "DVD_ERROR_IncompatibleDiscAndDecoderRegions"    'The disc cannot be played because the disc is not authored to be played in the decoder's region
    '            End Select
    '        Catch ex As Exception
    '            AddConsoleLine("problem getting dvd error string. error: " & ex.Message)
    '        End Try
    '    End Function

    '    Public Function GetDVDWarningString(ByVal P1 As String) As String
    '        Try
    '            Select Case P1
    '                Case 1
    '                    Return "DVD_WARNING_InvalidDVD1_0Disc"  'DVD-Video disc is incorrectly authored. Playback can continue, but unexpected behavior may occur.
    '                Case 2
    '                    Return "DVD_WARNING_FormatNotSupported" 'A decoder would not support the current format.  Playback of a stream (audio, video of SP) may not function. lParam2 contains the stream type (see AM_DVD_STREAM_FLAGS)
    '                Case 3
    '                    Return "DVD_WARNING_IllegalNavCommand"  'The internal DVD navigation command processor attempted to process an illegal command.
    '                Case 4
    '                    Return "DVD_WARNING_Open"   'File Open Failed
    '                Case 5
    '                    Return "DVD_WARNING_Seek"   'File Seek Failed
    '                Case 6
    '                    Return "DVD_WARNING_Read"   'File Read Failed
    '            End Select
    '        Catch ex As Exception
    '            AddConsoleLine("problem getting dvd warning string. error: " & ex.Message)
    '        End Try
    '    End Function

    '    Public Function GetPlaybackStoppedString(ByVal P1 As String) As String
    '        Try
    '            Select Case P1
    '                Case 0
    '                    Return "DVD_PB_STOPPED_Other"   'The navigator stopped the playback (no reason available).
    '                Case 1
    '                    Return "DVD_PB_STOPPED_NoBranch"    'The nav completed the current pgc and there was no more video and did not find any other branching instruction for subsequent playback.
    '                Case 2
    '                    Return "DVD_PB_STOPPED_NoFirstPlayDomain"   'The disc does not contain an initial startup program.
    '                Case 3
    '                    Return "DVD_PB_STOPPED_StopCommand" 'The app issued a stop() command or a stop command was authored on the disc.
    '                Case 4
    '                    Return "DVD_PB_STOPPED_Reset"   'The navigator was reset to the start of the disc (using ResetOnStop).
    '                Case 5
    '                    Return "DVD_PB_STOPPED_DiscEjected" 'The disc was ejected.
    '                Case 6
    '                    Return "DVD_PB_STOPPED_IllegalNavCommand"   'An illegal nav command prevented playback from continuing.
    '                Case 7
    '                    Return "DVD_PB_STOPPED_PlayPeriodAutoStop"  'PlayPeriod completed
    '                Case 8
    '                    Return "DVD_PB_STOPPED_PlayChapterAutoStop" 'PlayChapter completed
    '                Case 9
    '                    Return "DVD_PB_STOPPED_ParentalFailure" 'A parental level failure prevented playback
    '                Case 10
    '                    Return "DVD_PB_STOPPED_RegionFailure"   'A region failure prevented playback
    '                Case 11
    '                    Return "DVD_PB_STOPPED_MacrovisionFailure"  'A Macrovision failure prevented playback.
    '                Case 12
    '                    Return "DVD_PB_STOPPED_DiscReadError"   'A read error prevented playback.
    '                Case 13
    '                    Return "DVD_PB_STOPPED_CopyProtectFailure"  'Copy protection failure.
    '            End Select
    '        Catch ex As Exception
    '            AddConsoleLine("problem getting dvd playback stopped string. error: " & ex.Message)
    '        End Try
    '    End Function

    '#End Region

    '#End Region 'Handle DVD Navigator Events

    '#End Region 'DVD Navigator Related

End Module
