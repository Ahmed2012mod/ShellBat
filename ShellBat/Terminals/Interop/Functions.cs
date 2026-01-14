namespace ShellBat.Terminals.Interop;

public static partial class Functions
{
    public const uint PROC_THREAD_ATTRIBUTE_PSEUDOCONSOLE = 0x00020016;

    [LibraryImport("kernel32")]
    [PreserveSig]
    public static partial HRESULT CreatePseudoConsole(COORD size, HANDLE hInput, HANDLE hOutput, PSEUDOCONSOLE dwFlags, out HPCON phPC);

    [LibraryImport("kernel32")]
    [PreserveSig]
    public static partial HRESULT ResizePseudoConsole(HPCON hPC, COORD size);

    [LibraryImport("kernel32")]
    [PreserveSig]
    public static partial HRESULT ReleasePseudoConsole(HPCON hPC);

    [LibraryImport("kernel32")]
    [PreserveSig]
    public static partial void ClosePseudoConsole(HPCON hPC);

    [LibraryImport("kernel32", SetLastError = true)]
    [PreserveSig]
    public static partial BOOL CreatePipe(out HANDLE hReadPipe, out HANDLE hWritePipe, nint lpPipeAttributes, uint nSize);

    [LibraryImport("kernel32", SetLastError = true)]
    [PreserveSig]
    public static partial BOOL CreateProcessW(
        PWSTR lpApplicationName,
        PWSTR lpCommandLine,
        in SECURITY_ATTRIBUTES lpProcessAttributes,
        in SECURITY_ATTRIBUTES lpThreadAttributes,
        BOOL bInheritHandles,
        uint dwCreationFlags,
        nint lpEnvironment,
        PWSTR lpCurrentDirectory,
        in STARTUPINFOEX lpStartupInfo,
        out PROCESS_INFORMATION lpProcessInformation);

    [LibraryImport("kernel32", SetLastError = true)]
    [PreserveSig]
    public static partial BOOL InitializeProcThreadAttributeList(nint lpAttributeList, uint dwAttributeCount, uint dwFlags, ref nint lpSize);

    [LibraryImport("kernel32", SetLastError = true)]
    [PreserveSig]
    public static partial BOOL UpdateProcThreadAttribute(nint lpAttributeList, uint dwFlags, nint attribute, nint lpValue, nint cbSize, nint lpPreviousValue, nint lpReturnSize);

    [LibraryImport("kernel32", SetLastError = true)]
    [PreserveSig]
    public static partial void DeleteProcThreadAttributeList(nint lpAttributeList);

    [LibraryImport("kernel32", SetLastError = true)]
    [PreserveSig]
    public static partial BOOL SetConsoleCtrlHandler(ConsoleEventDelegate callback, BOOL add);

    public delegate bool ConsoleEventDelegate(CTRL_TYPE ctrlType);
}
