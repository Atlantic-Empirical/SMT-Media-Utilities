Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Diagnostics
Imports System.IO
Imports System.IO.Pipes
Imports System.Threading
Imports System.Windows

Namespace ConsoleClassLibrary

    ''' <summary> 
    ''' 
    ''' --- begin MSDN --- 
    ''' http://msdn.microsoft.com/en-us/library/ms682073(VS.85).aspx 
    ''' Console Functions 
    ''' The following functions are used to access a console. 
    ''' --- end MSDN --- 
    ''' 
    ''' </summary> 
    Class ConsoleFunctions

        ' http://pinvoke.net/default.aspx/kernel32/AddConsoleAlias.html 
        <DllImport("kernel32", SetLastError:=True)> _
        Public Shared Function AddConsoleAlias(ByVal Source As String, ByVal Target As String, ByVal ExeName As String) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/AllocConsole.html 
        <DllImport("kernel32", SetLastError:=True)> _
        Public Shared Function AllocConsole() As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/AttachConsole.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function AttachConsole(ByVal dwProcessId As UInteger) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/CreateConsoleScreenBuffer.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function CreateConsoleScreenBuffer(ByVal dwDesiredAccess As UInteger, ByVal dwShareMode As UInteger, ByVal lpSecurityAttributes As IntPtr, ByVal dwFlags As UInteger, ByVal lpScreenBufferData As IntPtr) As IntPtr
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/FillConsoleOutputAttribute.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function FillConsoleOutputAttribute(ByVal hConsoleOutput As IntPtr, ByVal wAttribute As UShort, ByVal nLength As UInteger, ByVal dwWriteCoord As COORD, ByRef lpNumberOfAttrsWritten As UInteger) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/FillConsoleOutputCharacter.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function FillConsoleOutputCharacter(ByVal hConsoleOutput As IntPtr, ByVal cCharacter As Char, ByVal nLength As UInteger, ByVal dwWriteCoord As COORD, ByRef lpNumberOfCharsWritten As UInteger) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/FlushConsoleInputBuffer.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function FlushConsoleInputBuffer(ByVal hConsoleInput As IntPtr) As Boolean
        End Function
        Public Declare Auto Function FreeConsole Lib "kernel32.dll" () As Boolean

        ' http://pinvoke.net/default.aspx/kernel32/FreeConsole.html 

        ' http://pinvoke.net/default.aspx/kernel32/GenerateConsoleCtrlEvent.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function GenerateConsoleCtrlEvent(ByVal dwCtrlEvent As UInteger, ByVal dwProcessGroupId As UInteger) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/GetConsoleAlias.html 
        <DllImport("kernel32", SetLastError:=True)> _
        Public Shared Function GetConsoleAlias(ByVal Source As String, ByRef TargetBuffer As StringBuilder, ByVal TargetBufferLength As UInteger, ByVal ExeName As String) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/GetConsoleAliases.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function GetConsoleAliases(ByVal lpTargetBuffer As StringBuilder(), ByVal targetBufferLength As UInteger, ByVal lpExeName As String) As UInteger
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/GetConsoleAliasesLength.html 
        <DllImport("kernel32", SetLastError:=True)> _
        Public Shared Function GetConsoleAliasesLength(ByVal ExeName As String) As UInteger
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/GetConsoleAliasExes.html 
        <DllImport("kernel32", SetLastError:=True)> _
        Public Shared Function GetConsoleAliasExes(ByRef ExeNameBuffer As StringBuilder, ByVal ExeNameBufferLength As UInteger) As UInteger
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/GetConsoleAliasExesLength.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function GetConsoleAliasExesLength() As UInteger
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/GetConsoleCP.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function GetConsoleCP() As UInteger
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/GetConsoleCursorInfo.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function GetConsoleCursorInfo(ByVal hConsoleOutput As IntPtr, ByRef lpConsoleCursorInfo As CONSOLE_CURSOR_INFO) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/GetConsoleDisplayMode.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function GetConsoleDisplayMode(ByRef ModeFlags As UInteger) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/GetConsoleFontSize.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function GetConsoleFontSize(ByVal hConsoleOutput As IntPtr, ByVal nFont As Int32) As COORD
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/GetConsoleHistoryInfo.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function GetConsoleHistoryInfo(ByRef ConsoleHistoryInfo As CONSOLE_HISTORY_INFO) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/GetConsoleMode.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function GetConsoleMode(ByVal hConsoleHandle As IntPtr, ByRef lpMode As UInteger) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/GetConsoleOriginalTitle.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function GetConsoleOriginalTitle(ByRef ConsoleTitle As StringBuilder, ByVal Size As UInteger) As UInteger
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/GetConsoleOutputCP.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function GetConsoleOutputCP() As UInteger
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/GetConsoleProcessList.html 
        ' TODO: Test - what's an out uint[] during interop? This probably isn't quite right, but provides a starting point: 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function GetConsoleProcessList(ByRef ProcessList As UInteger(), ByVal ProcessCount As UInteger) As UInteger
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/GetConsoleScreenBufferInfo.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function GetConsoleScreenBufferInfo(ByVal hConsoleOutput As IntPtr, ByRef lpConsoleScreenBufferInfo As CONSOLE_SCREEN_BUFFER_INFO) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/GetConsoleScreenBufferInfoEx.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function GetConsoleScreenBufferInfoEx(ByVal hConsoleOutput As IntPtr, ByRef ConsoleScreenBufferInfo As CONSOLE_SCREEN_BUFFER_INFO_EX) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/GetConsoleSelectionInfo.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function GetConsoleSelectionInfo(ByVal ConsoleSelectionInfo As CONSOLE_SELECTION_INFO) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/GetConsoleTitle.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function GetConsoleTitle(<Out()> _
ByVal lpConsoleTitle As StringBuilder, ByVal nSize As UInteger) As UInteger
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/GetConsoleWindow.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function GetConsoleWindow() As IntPtr
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/GetCurrentConsoleFont.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function GetCurrentConsoleFont(ByVal hConsoleOutput As IntPtr, ByVal bMaximumWindow As Boolean, ByRef lpConsoleCurrentFont As CONSOLE_FONT_INFO) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/GetCurrentConsoleFontEx.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function GetCurrentConsoleFontEx(ByVal ConsoleOutput As IntPtr, ByVal MaximumWindow As Boolean, ByRef ConsoleCurrentFont As CONSOLE_FONT_INFO_EX) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/GetLargestConsoleWindowSize.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function GetLargestConsoleWindowSize(ByVal hConsoleOutput As IntPtr) As COORD
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/GetNumberOfConsoleInputEvents.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function GetNumberOfConsoleInputEvents(ByVal hConsoleInput As IntPtr, ByRef lpcNumberOfEvents As UInteger) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/GetNumberOfConsoleMouseButtons.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function GetNumberOfConsoleMouseButtons(ByRef lpNumberOfMouseButtons As UInteger) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/GetStdHandle.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function GetStdHandle(ByVal nStdHandle As Integer) As IntPtr
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/HandlerRoutine.html 
        ' Delegate type to be used as the Handler Routine for SCCH 
        Public Delegate Function ConsoleCtrlDelegate(ByVal CtrlType As CtrlTypes) As Boolean

        ' http://pinvoke.net/default.aspx/kernel32/PeekConsoleInput.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function PeekConsoleInput(ByVal hConsoleInput As IntPtr, <Out()> _
ByVal lpBuffer As INPUT_RECORD(), ByVal nLength As UInteger, ByRef lpNumberOfEventsRead As UInteger) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/ReadConsole.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function ReadConsole(ByVal hConsoleInput As IntPtr, <Out()> _
ByVal lpBuffer As StringBuilder, ByVal nNumberOfCharsToRead As UInteger, ByRef lpNumberOfCharsRead As UInteger, ByVal lpReserved As IntPtr) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/ReadConsoleInput.html 
        <DllImport("kernel32.dll", EntryPoint:="ReadConsoleInputW", CharSet:=CharSet.Unicode)> _
        Public Shared Function ReadConsoleInput(ByVal hConsoleInput As IntPtr, <Out()> _
ByVal lpBuffer As INPUT_RECORD(), ByVal nLength As UInteger, ByRef lpNumberOfEventsRead As UInteger) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/ReadConsoleOutput.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function ReadConsoleOutput(ByVal hConsoleOutput As IntPtr, <Out()> _
ByVal lpBuffer As CHAR_INFO(), ByVal dwBufferSize As COORD, ByVal dwBufferCoord As COORD, ByRef lpReadRegion As SMALL_RECT) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/ReadConsoleOutputAttribute.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function ReadConsoleOutputAttribute(ByVal hConsoleOutput As IntPtr, <Out()> _
ByVal lpAttribute As UShort(), ByVal nLength As UInteger, ByVal dwReadCoord As COORD, ByRef lpNumberOfAttrsRead As UInteger) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/ReadConsoleOutputCharacter.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function ReadConsoleOutputCharacter(ByVal hConsoleOutput As IntPtr, <Out()> _
ByVal lpCharacter As StringBuilder, ByVal nLength As UInteger, ByVal dwReadCoord As COORD, ByRef lpNumberOfCharsRead As UInteger) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/ScrollConsoleScreenBuffer.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function ScrollConsoleScreenBuffer(ByVal hConsoleOutput As IntPtr, <[In]()> _
ByRef lpScrollRectangle As SMALL_RECT, ByVal lpClipRectangle As IntPtr, ByVal dwDestinationOrigin As COORD, <[In]()> _
ByRef lpFill As CHAR_INFO) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/SetConsoleActiveScreenBuffer.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function SetConsoleActiveScreenBuffer(ByVal hConsoleOutput As IntPtr) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/SetConsoleCP.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function SetConsoleCP(ByVal wCodePageID As UInteger) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/SetConsoleCtrlHandler.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function SetConsoleCtrlHandler(ByVal HandlerRoutine As ConsoleCtrlDelegate, ByVal Add As Boolean) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/SetConsoleCursorInfo.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function SetConsoleCursorInfo(ByVal hConsoleOutput As IntPtr, <[In]()> _
ByRef lpConsoleCursorInfo As CONSOLE_CURSOR_INFO) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/SetConsoleCursorPosition.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function SetConsoleCursorPosition(ByVal hConsoleOutput As IntPtr, ByVal dwCursorPosition As COORD) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/SetConsoleDisplayMode.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function SetConsoleDisplayMode(ByVal ConsoleOutput As IntPtr, ByVal Flags As UInteger, ByRef NewScreenBufferDimensions As COORD) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/SetConsoleHistoryInfo.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function SetConsoleHistoryInfo(ByVal ConsoleHistoryInfo As CONSOLE_HISTORY_INFO) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/SetConsoleMode.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function SetConsoleMode(ByVal hConsoleHandle As IntPtr, ByVal dwMode As UInteger) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/SetConsoleOutputCP.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function SetConsoleOutputCP(ByVal wCodePageID As UInteger) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/SetConsoleScreenBufferInfoEx.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function SetConsoleScreenBufferInfoEx(ByVal ConsoleOutput As IntPtr, ByVal ConsoleScreenBufferInfoEx As CONSOLE_SCREEN_BUFFER_INFO_EX) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/SetConsoleScreenBufferSize.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function SetConsoleScreenBufferSize(ByVal hConsoleOutput As IntPtr, ByVal dwSize As COORD) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/SetConsoleTextAttribute.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function SetConsoleTextAttribute(ByVal hConsoleOutput As IntPtr, ByVal wAttributes As UShort) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/SetConsoleTitle.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function SetConsoleTitle(ByVal lpConsoleTitle As String) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/SetConsoleWindowInfo.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function SetConsoleWindowInfo(ByVal hConsoleOutput As IntPtr, ByVal bAbsolute As Boolean, <[In]()> _
ByRef lpConsoleWindow As SMALL_RECT) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/SetCurrentConsoleFontEx.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function SetCurrentConsoleFontEx(ByVal ConsoleOutput As IntPtr, ByVal MaximumWindow As Boolean, ByVal ConsoleCurrentFontEx As CONSOLE_FONT_INFO_EX) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/SetStdHandle.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function SetStdHandle(ByVal nStdHandle As UInteger, ByVal hHandle As IntPtr) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/WriteConsole.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function WriteConsole(ByVal hConsoleOutput As IntPtr, ByVal lpBuffer As String, ByVal nNumberOfCharsToWrite As UInteger, ByRef lpNumberOfCharsWritten As UInteger, ByVal lpReserved As IntPtr) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/WriteConsoleInput.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function WriteConsoleInput(ByVal hConsoleInput As IntPtr, ByVal lpBuffer As INPUT_RECORD(), ByVal nLength As UInteger, ByRef lpNumberOfEventsWritten As UInteger) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/WriteConsoleOutput.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function WriteConsoleOutput(ByVal hConsoleOutput As IntPtr, ByVal lpBuffer As CHAR_INFO(), ByVal dwBufferSize As COORD, ByVal dwBufferCoord As COORD, ByRef lpWriteRegion As SMALL_RECT) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/WriteConsoleOutputAttribute.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function WriteConsoleOutputAttribute(ByVal hConsoleOutput As IntPtr, ByVal lpAttribute As UShort(), ByVal nLength As UInteger, ByVal dwWriteCoord As COORD, ByRef lpNumberOfAttrsWritten As UInteger) As Boolean
        End Function

        ' http://pinvoke.net/default.aspx/kernel32/WriteConsoleOutputCharacter.html 
        <DllImport("kernel32.dll", SetLastError:=True)> _
        Public Shared Function WriteConsoleOutputCharacter(ByVal hConsoleOutput As IntPtr, ByVal lpCharacter As String, ByVal nLength As UInteger, ByVal dwWriteCoord As COORD, ByRef lpNumberOfCharsWritten As UInteger) As Boolean
        End Function

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure COORD

            Public X As Short
            Public Y As Short

        End Structure

        Public Structure SMALL_RECT

            Public Left As Short
            Public Top As Short
            Public Right As Short
            Public Bottom As Short

        End Structure

        Public Structure CONSOLE_SCREEN_BUFFER_INFO

            Public dwSize As COORD
            Public dwCursorPosition As COORD
            Public wAttributes As Short
            Public srWindow As SMALL_RECT
            Public dwMaximumWindowSize As COORD

        End Structure

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure CONSOLE_SCREEN_BUFFER_INFO_EX
            Public cbSize As UInteger
            Public dwSize As COORD
            Public dwCursorPosition As COORD
            Public wAttributes As Short
            Public srWindow As SMALL_RECT
            Public dwMaximumWindowSize As COORD

            Public wPopupAttributes As UShort
            Public bFullscreenSupported As Boolean

            ' Hack Hack Hack 
            ' Too lazy to figure out the array at the moment... 
            'public COLORREF[16] ColorTable; 
            Public color0 As COLORREF
            Public color1 As COLORREF
            Public color2 As COLORREF
            Public color3 As COLORREF

            Public color4 As COLORREF
            Public color5 As COLORREF
            Public color6 As COLORREF
            Public color7 As COLORREF

            Public color8 As COLORREF
            Public color9 As COLORREF
            Public colorA As COLORREF
            Public colorB As COLORREF

            Public colorC As COLORREF
            Public colorD As COLORREF
            Public colorE As COLORREF
            Public colorF As COLORREF
        End Structure

        '[StructLayout(LayoutKind.Sequential)] 
        'struct COLORREF 
        '{ 
        ' public byte R; 
        ' public byte G; 
        ' public byte B; 
        '} 

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure COLORREF
            Public ColorDWORD As UInteger

            Public Sub New(ByVal color As System.Drawing.Color)
                ColorDWORD = CInt(color.R) + (CInt(color.G) << 8) + (CInt(color.B) << 16)
            End Sub

            Public Function GetColor() As System.Drawing.Color
                Return System.Drawing.Color.FromArgb(CInt((255 And ColorDWORD)), CInt((65280 And ColorDWORD)) >> 8, CInt((16711680 And ColorDWORD)) >> 16)
            End Function

            Public Sub SetColor(ByVal color As System.Drawing.Color)
                ColorDWORD = CInt(color.R) + (CInt(color.G) << 8) + (CInt(color.B) << 16)
            End Sub
        End Structure



        <StructLayout(LayoutKind.Sequential)> _
        Public Structure CONSOLE_FONT_INFO
            Public nFont As Integer
            Public dwFontSize As COORD
        End Structure

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure CONSOLE_FONT_INFO_EX
            Public cbSize As UInteger
            Public nFont As UInteger
            Public dwFontSize As COORD
            Public FontFamily As UShort
            Public FontWeight As UShort

            ' todo: this isn't right, needs fixing 
            'WCHAR FaceName[LF_FACESIZE]; 
            Public FaceName As String
        End Structure

        <StructLayout(LayoutKind.Explicit)> _
        Public Structure INPUT_RECORD
            <FieldOffset(0)> _
            Public EventType As UShort
            <FieldOffset(4)> _
            Public KeyEvent As KEY_EVENT_RECORD
            <FieldOffset(4)> _
            Public MouseEvent As MOUSE_EVENT_RECORD
            <FieldOffset(4)> _
            Public WindowBufferSizeEvent As WINDOW_BUFFER_SIZE_RECORD
            <FieldOffset(4)> _
            Public MenuEvent As MENU_EVENT_RECORD
            <FieldOffset(4)> _
            Public FocusEvent As FOCUS_EVENT_RECORD
        End Structure

        <StructLayout(LayoutKind.Explicit, CharSet:=CharSet.Unicode)> _
        Public Structure KEY_EVENT_RECORD
            <FieldOffset(0), MarshalAs(UnmanagedType.Bool)> _
            Public bKeyDown As Boolean
            <FieldOffset(4), MarshalAs(UnmanagedType.U2)> _
            Public wRepeatCount As UShort
            'public VirtualKeys wVirtualKeyCode; 
            <FieldOffset(6), MarshalAs(UnmanagedType.U2)> _
            Public wVirtualKeyCode As UShort
            <FieldOffset(8), MarshalAs(UnmanagedType.U2)> _
            Public wVirtualScanCode As UShort
            <FieldOffset(10)> _
            Public UnicodeChar As Char
            'public ControlKeyState dwControlKeyState; 
            <FieldOffset(12), MarshalAs(UnmanagedType.U4)> _
            Public dwControlKeyState As UInteger
        End Structure

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure MOUSE_EVENT_RECORD
            Public dwMousePosition As COORD
            Public dwButtonState As UInteger
            Public dwControlKeyState As UInteger
            Public dwEventFlags As UInteger
        End Structure

        Public Structure WINDOW_BUFFER_SIZE_RECORD
            Public dwSize As COORD

            Public Sub New(ByVal x As Short, ByVal y As Short)
                dwSize = New COORD()
                dwSize.X = x
                dwSize.Y = y
            End Sub
        End Structure

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure MENU_EVENT_RECORD
            Public dwCommandId As UInteger
        End Structure

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure FOCUS_EVENT_RECORD
            Public bSetFocus As Boolean
        End Structure

        'CHAR_INFO struct, which was a union in the old days 
        ' so we want to use LayoutKind.Explicit to mimic it as closely 
        ' as we can 
        <StructLayout(LayoutKind.Explicit)> _
        Public Structure CHAR_INFO
            <FieldOffset(0)> _
            Public UnicodeChar As Char
            <FieldOffset(0)> _
            Public AsciiChar As Char
            '2 bytes seems to work properly 
            <FieldOffset(2)> _
            Public Attributes As UInt16
        End Structure

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure CONSOLE_CURSOR_INFO
            Public Size As UInteger
            Public Visible As Boolean
        End Structure

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure CONSOLE_HISTORY_INFO
            Public cbSize As UShort
            Public HistoryBufferSize As UShort
            Public NumberOfHistoryBuffers As UShort
            Public dwFlags As UInteger
        End Structure

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure CONSOLE_SELECTION_INFO
            Public Flags As UInteger
            Public SelectionAnchor As COORD
            Public Selection As SMALL_RECT

            ' Flags values: 
            Const CONSOLE_MOUSE_DOWN As UInteger = 8
            ' Mouse is down 
            Const CONSOLE_MOUSE_SELECTION As UInteger = 4
            'Selecting with the mouse 
            Const CONSOLE_NO_SELECTION As UInteger = 0
            'No selection 
            Const CONSOLE_SELECTION_IN_PROGRESS As UInteger = 1
            'Selection has begun 
            Const CONSOLE_SELECTION_NOT_EMPTY As UInteger = 2
            'Selection rectangle is not empty 
        End Structure

        ' Enumerated type for the control messages sent to the handler routine 
        Public Enum CtrlTypes As UInteger
            CTRL_C_EVENT = 0
            CTRL_BREAK_EVENT
            CTRL_CLOSE_EVENT
            CTRL_LOGOFF_EVENT = 5
            CTRL_SHUTDOWN_EVENT
        End Enum
    End Class

End Namespace

Namespace TestPrintf

    Class Program

        <DllImport("kernel32.dll", SetLastError:=True)> _
        Protected Shared Function SetStdHandle(ByVal nStdHandle As Integer, ByVal hConsoleOutput As IntPtr) As Boolean
        End Function

        <DllImport("PrintDll.dll", CallingConvention:=CallingConvention.Cdecl)> _
        Protected Shared Sub PrintMsg()
        End Sub

    End Class

End Namespace
