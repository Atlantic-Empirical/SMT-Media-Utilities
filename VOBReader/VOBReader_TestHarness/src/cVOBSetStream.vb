Imports System.IO
Imports System.Runtime.InteropServices

Public Class cVOBSetStream
    Inherits System.IO.Stream

#Region "PROPERTIES"

    Private VR As Object
    Public IVR As IVOBReader

    Private VIDEO_TS As String
    Private VTSNumber As Byte = 1
    Private VOBNumber As Byte = 1

    Public ReadOnly Property VOBPath() As String
        Get
            Return VIDEO_TS & "\VTS_0" & VTSNumber & "_" & VOBNumber & ".vob"
        End Get
    End Property

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

#Region "CONSTRUCTOR/DESTRUCTOR"

    Public Sub New(ByVal nVOBPath As String, Optional ByVal OutputFolder As String = "")
        InitializeVOBReader(nVOBPath)
    End Sub

    Public Shadows Sub Dispose()
        DisposeVOBReader()
    End Sub

#End Region 'CONSTRUCTOR/DESTRUCTOR

#Region "STREAM IMPLEMENTATION"

    ''' <summary>
    ''' Provides the total size of all VOBs in the selected VOB Set.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides ReadOnly Property Length() As Long
        Get

        End Get
    End Property

    Public Overrides Property Position() As Long
        Get

        End Get
        Set(ByVal value As Long)

        End Set
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="buffer"></param>
    ''' <param name="offset">Ignored. Method always will write to the buffer from the beginning.</param>
    ''' <param name="count"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Read(ByVal buffer() As Byte, ByVal offset As Integer, ByVal count As Integer) As Integer

    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="offset"></param>
    ''' <param name="origin"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function Seek(ByVal offset As Long, ByVal origin As System.IO.SeekOrigin) As Long

    End Function

    Public Overrides ReadOnly Property CanRead() As Boolean
        Get
            Return IVR IsNot Nothing
        End Get
    End Property

    Public Overrides ReadOnly Property CanSeek() As Boolean
        Get
            Return IVR IsNot Nothing
        End Get
    End Property

    Public Overrides ReadOnly Property CanWrite() As Boolean
        Get
            Return False
        End Get
    End Property

    Public Overrides Sub Flush()
        Throw New Exception("Flush not supported.")
    End Sub

    Public Overrides Sub SetLength(ByVal value As Long)
        Throw New Exception("SetLength() not supported.")
    End Sub

    Public Overrides Sub Write(ByVal buffer() As Byte, ByVal offset As Integer, ByVal count As Integer)
        Throw New Exception("Write not supported.")
    End Sub

#End Region 'STREAM IMPLEMENTATION

#Region "READER"



#End Region 'READER

#Region "PRIVATE METHODS"

    Private Sub InitializeVOBReader(ByVal nVIDEO_TS As String)
        Try
            VIDEO_TS = nVIDEO_TS
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
            IVR = Nothing
            VR = Nothing
        Catch ex As Exception
            'Throw New Exception("Problem with DisposeVOBReader(). Error: " & ex.Message, ex)
        End Try
    End Sub

#End Region 'PRIVATE METHODS

End Class
