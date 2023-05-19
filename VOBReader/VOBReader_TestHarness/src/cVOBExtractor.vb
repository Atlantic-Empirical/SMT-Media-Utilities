Imports System.IO
Imports System.Runtime.InteropServices

''' <summary>
''' ONE USE ONLY
''' </summary>
''' <remarks></remarks>
Public Class cVOBExtractor

#Region "PROPERTIES"

    Public IVR As IVOBReader
    Public VOBPath As String
    Private VR As Object

    Private OUTPUT_FOLDER As String = "C:\Temp\VOBReader\"

    Public ReadOnly Property SectorCount() As UInt64
        Get
            If _SectorCount = 0 Then
                Dim VOBSize As Long = New FileInfo(VOBPath).Length
                _SectorCount = VOBSize / 2048
            End If
            Return _SectorCount
        End Get
    End Property
    Private _SectorCount As UInt64 = 0

#End Region 'PROPERTIES

#Region "EVENTS"

    Public Event evStart()
    Public Event evComplete(ByVal DurationTicks As Long)
    Public Event evSectorRead(ByVal SectorNumber As UInt64)

#End Region 'EVENTS

#Region "CONSTRUCTOR/DESTRUCTOR"

    Public Sub New(ByVal nVOBPath As String, Optional ByVal OutputFolder As String = "")
        InitializeVOBReader(nVOBPath)
        If OutputFolder <> "" Then OUTPUT_FOLDER = OutputFolder
        If Not Directory.Exists(OUTPUT_FOLDER) Then Directory.CreateDirectory(OUTPUT_FOLDER)
    End Sub

    Public Sub Dispose()
        DisposeVOBReader()
    End Sub

#End Region 'CONSTRUCTOR/DESTRUCTOR

#Region "PUBLIC METHODS"

    Public Sub Start()
        Me.ExtractEntireFile()
    End Sub

    Public Function WriteSectorToStream(ByRef ST As Stream, ByVal SectorNumber As Integer) As eSectorAccessResult
        Try
            Dim p As IntPtr
            Dim HR As Integer = IVR.ReadSector(SectorNumber, p)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
            'Debug.WriteLine(vbNewLine & "managed pointer = 0x" & Hex(p.ToInt32).PadLeft(8, "0"))
            Dim b(2047) As Byte
            Marshal.Copy(p, b, 0, 2048)
            ST.Write(b, 0, 2048)
            Marshal.FreeCoTaskMem(p)
            Return HR
        Catch ex As Exception
            Throw New Exception("Problem with WriteSectorToStream(). Error: " & ex.Message, ex)
        End Try
    End Function

    Public Shared Function UnlockDrive(ByVal DriveLetter As Char) As Boolean
        Dim VR As Object = Activator.CreateInstance(Type.GetTypeFromCLSID(New Guid("707DBF60-B624-4ADF-B89C-6A9B438B2395")))
        Dim IVR As IVOBReader = CType(VR, IVOBReader)
        Return 0 = IVR.UnlockDrive(DriveLetter & ":\\")
    End Function

#End Region 'PUBLIC METHODS

#Region "PRIVATE METHODS"

    Private Sub InitializeVOBReader(ByVal nVOBPath As String)
        Try
            VOBPath = nVOBPath
            VR = Activator.CreateInstance(Type.GetTypeFromCLSID(New Guid("707DBF60-B624-4ADF-B89C-6A9B438B2395")))
            IVR = CType(VR, IVOBReader)
            Dim HR As Integer = IVR.Initialize(VOBPath)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
        Catch ex As Exception
            Throw New Exception("Problem with SetupVOBReader(). Error: " & ex.Message, ex)
        End Try
    End Sub

    Private Sub DisposeVOBReader()
        Try
            Dim HR As Integer = IVR.DeInit()
            Marshal.ReleaseComObject(IVR)
            Marshal.ReleaseComObject(VR)
            If HR < 0 Then Marshal.ThrowExceptionForHR(HR)
        Catch ex As Exception
            'Throw New Exception("Problem with DisposeVOBReader(). Error: " & ex.Message, ex)
        End Try
    End Sub

    Private Sub ExtractEntireFile()
        Try
            Dim fp As String = OUTPUT_FOLDER & Path.GetFileName(VOBPath)
            If File.Exists(fp) Then File.Delete(fp)
            Dim FS As New FileStream(fp, FileMode.OpenOrCreate, FileAccess.Write)

            ' DEBUGGING - to limit output file length
            Dim fi As New FileInfo(VOBPath)
            Dim BytesToExtract As Long = Math.Min(104857600 * 2, fi.Length) '104857600 '10485760 20971520
            _SectorCount = BytesToExtract / 2048
            ' DEBUGGING

            RaiseEvent evStart()
            Dim ProcessStartTicks As Long = DateTime.Now.Ticks
            For Sector As Integer = 0 To SectorCount - 1
                WriteSectorToStream(FS, Sector)
                'RaiseEvent evSectorRead(Sector)
            Next
            RaiseEvent evComplete(DateTime.Now.Ticks - ProcessStartTicks)
            FS.Close()
        Catch ex As Exception
            Throw New Exception("Problem with ReadEntireFile(). Error: " & ex.Message, ex)
        End Try
    End Sub

#End Region 'PRIVATE METHODS

#Region "STRUCTURES"

    Public Enum eSectorAccessResult
        Generic_Failure = -1
        Not_Indicated = 0
        Success_NotEncrypted = 1
        Success_Encrypted = 2
    End Enum

#End Region 'STRUCTURES

#Region "PERFORMANCE"

    Private SectorsProcessed As Integer = 0
    Private AverageTimeMS As Integer = 0
    Private TotalTimeMS As Integer = 0

    Public Event evAvgTime(ByVal Current As Integer)

    Private Sub Perf_Reset()
        SectorsProcessed = 0
        AverageTimeMS = 0
        TotalTimeMS = 0
    End Sub

    Private Sub AddPerfMark(ByVal ProcessingTime As Integer)
        SectorsProcessed += 1
        TotalTimeMS += ProcessingTime
        AverageTimeMS = TotalTimeMS / SectorsProcessed
        RaiseEvent evAvgTime(AverageTimeMS)
    End Sub

#End Region 'PERFORMANCE

End Class
