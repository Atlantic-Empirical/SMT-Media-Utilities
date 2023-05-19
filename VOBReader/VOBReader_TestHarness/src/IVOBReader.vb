Imports System.Text
Imports System.Runtime.InteropServices

<ComVisible(True), ComImport(), Guid("C2134A04-839F-44E6-A5D6-A1ABBA62CB1E"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)> _
Public Interface IVOBReader

    <PreserveSig()> _
    Function ReadSector( _
        <[In]()> ByVal SectorNumber As Integer, _
        ByRef SectorData As IntPtr) As Integer

    <PreserveSig()> _
    Function Initialize( _
        <[In](), MarshalAs(UnmanagedType.LPWStr)> ByVal inVOBPath As String) As Integer

    <PreserveSig()> _
    Function Test_A(ByRef SectorData As IntPtr, ByVal Test As Integer) As Integer

    <PreserveSig()> _
    Function DeInit( ) As Integer

    <PreserveSig()> _
    Function UnlockDrive( _
    <[In](), MarshalAs(UnmanagedType.LPWStr)> ByVal inDrivePath As String) As Integer

End Interface
