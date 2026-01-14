namespace ShellBat.Utilities;

[SupportedOSPlatform("windows5.1.2600")]
public static partial class ProcessUtilities
{
    [SupportedOSPlatform("windows6.0.6000")]
    public static bool IsWow64(this Process? process)
    {
        process ??= SystemUtilities.CurrentProcess;
        var handle = process.Handle;
        DirectN.Functions.IsWow64Process(handle, out var isWow64);
        return isWow64;
    }

    public static bool RestartAsAdmin(bool force)
    {
        if (!force && SystemUtilities.GetTokenElevationType() == TokenElevationType.Full)
            return false;

        var info = new ProcessStartInfo
        {
            FileName = Environment.ProcessPath,
            UseShellExecute = true,
            Verb = "runas" // Provides Run as Administrator
        };
        try
        {
            var proc = Process.Start(info);
            if (proc != null)
            {
                DirectN.Functions.AllowSetForegroundWindow((uint)proc.Id);
            }
            return proc != null;
        }
        catch (Win32Exception ex) when (ex.NativeErrorCode == (int)WIN32_ERROR.ERROR_CANCELLED)
        {
            return false;
        }
    }

    public static bool RestartAsNonAdmin()
    {
        var view = ShellView.Desktop;
        if (view == null)
            return false;

        var hr = view.NativeObject.GetItemObject((uint)_SVGIO.SVGIO_BACKGROUND, typeof(DirectN.IDispatch).GUID, out var obj);
        if (hr.IsError)
            return false;

        using var dispatch = ComObject.FromPointer<DirectN.IDispatch>(obj);
        var shellFolderView = dispatch.As<IShellFolderViewDual>();
        if (shellFolderView == null)
            return false;

        if (shellFolderView.Object.get_Application(out var appObj).IsError)
            return false;

        using var shellDisp = new ComObject<IShellDispatch2>(appObj);
        using var bstr = new Bstr(Environment.ProcessPath);
        using var parameters = new Variant(string.Empty);
        using var directory = new Variant(string.Empty);
        using var operation = new Variant(string.Empty);
        using var show = new Variant((int)SHOW_WINDOW_CMD.SW_SHOWNORMAL);
        return shellDisp.Object.ShellExecute(bstr, parameters.Detached, directory.Detached, operation.Detached, show.Detached).IsSuccess;
    }

    [SupportedOSPlatform("windows6.0.6000")]
    public static string? GetCurrentDirectory(int processId, bool throwOnError = true) => GetProcessParametersString(processId, 0x38, 0x24, throwOnError);

    [SupportedOSPlatform("windows6.0.6000")]
    public static string? GetCurrentDirectory(this Process process, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(process);
        return GetCurrentDirectory(process.Id, throwOnError);
    }

    [SupportedOSPlatform("windows6.0.6000")]
    public static string? GetCommandLine(int processId, bool throwOnError = true) => GetProcessParametersString(processId, 0x70, 0x40, throwOnError);

    [SupportedOSPlatform("windows6.0.6000")]
    public static string? GetCommandLine(this Process process, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(process);
        return GetCommandLine(process.Id, throwOnError);
    }

    // https://stackoverflow.com/questions/7446887/get-command-line-string-of-64-bit-process-from-32-bit-process
    // https://stackoverflow.com/questions/16110936/read-other-process-current-directory-in-c-sharp/
    // note here we don't support x86 => x64 and the reverse process reading
    [SupportedOSPlatform("windows6.0.6000")]
    private static unsafe string? GetProcessParametersString(int processId, int offset64, int offset86, bool throwOnError = true)
    {
        if (processId <= 0)
            return null;

        var handle = DirectN.Functions.OpenProcess(PROCESS_ACCESS_RIGHTS.PROCESS_QUERY_INFORMATION | PROCESS_ACCESS_RIGHTS.PROCESS_VM_READ, false, (uint)processId);
        if (handle == 0)
        {
            if (throwOnError)
                throw new Win32Exception(Marshal.GetLastWin32Error());

            return null;
        }

        DirectN.Functions.GetNativeSystemInfo(out var info);
        DirectN.Functions.IsWow64Process(handle, out var wow);

        // offset values below have been tested from Windows 7 to 11
        // use WinDbg "dt ntdll!_PEB" command and search for ProcessParameters offset to find the truth, depending on the OS version
        var processParametersOffset = info.Anonymous.Anonymous.wProcessorArchitecture == PROCESSOR_ARCHITECTURE.PROCESSOR_ARCHITECTURE_AMD64 ? 0x20 : 0x10;
        var offset = (info.Anonymous.Anonymous.wProcessorArchitecture == PROCESSOR_ARCHITECTURE.PROCESSOR_ARCHITECTURE_AMD64 && !wow) ? offset64 : offset86;
        try
        {
            var pbi = new PROCESS_BASIC_INFORMATION();
            var hr = NtQueryInformationProcess(handle, 0, ref pbi, sizeof(PROCESS_BASIC_INFORMATION), out _);
            if (hr != 0)
            {
                if (throwOnError)
                    throw new Win32Exception(hr);

                return null;
            }

            if (!ReadProcessMemory(handle, pbi.PebBaseAddress + processParametersOffset, out var buffer, sizeof(nint), out _))
            {
                if (throwOnError)
                    throw new Win32Exception(Marshal.GetLastWin32Error());

                return null;
            }

            var us = new UNICODE_STRING();
            if (!ReadProcessMemory(handle, buffer + offset, ref us, sizeof(UNICODE_STRING), 0))
            {
                if (throwOnError)
                    throw new Win32Exception(Marshal.GetLastWin32Error());

                return null;
            }

            if (us.Buffer == 0 || us.Length == 0)
                return null;

            var s = new string('\0', us.Length / 2);
            if (!ReadProcessMemory(handle, us.Buffer, s, new nint(us.Length), 0))
            {
                if (throwOnError)
                    throw new Win32Exception(Marshal.GetLastWin32Error());

                return null;
            }

            return s;
        }
        finally
        {
            DirectN.Functions.CloseHandle(handle);
        }
    }

    private struct PROCESS_BASIC_INFORMATION
    {
        public nint Reserved1;
        public nint PebBaseAddress;
        public nint Reserved2_0;
        public nint Reserved2_1;
        public nint UniqueProcessId;
        public nint Reserved3;
    }

    private struct UNICODE_STRING
    {
        public short Length;
        public short MaximumLength;
        public nint Buffer;
    }

    private enum PROCESSINFOCLASS
    {
        ProcessBasicInformation = 0,
    }

    [LibraryImport("ntdll")]
    private static partial int NtQueryInformationProcess(HANDLE ProcessHandle, PROCESSINFOCLASS ProcessInformationClass, ref PROCESS_BASIC_INFORMATION ProcessInformation, int ProcessInformationLength, out uint ReturnLength);

    [LibraryImport("kernel32", SetLastError = true)]
    private static partial BOOL ReadProcessMemory(HANDLE ProcessHandle, nint lpBaseAddress, out nint lpBuffer, nint dwSize, out nint lpNumberOfBytesRead);

    [LibraryImport("kernel32", SetLastError = true)]
    private static partial BOOL ReadProcessMemory(HANDLE ProcessHandle, nint lpBaseAddress, ref UNICODE_STRING lpBuffer, nint dwSize, nint lpNumberOfBytesRead);

    [LibraryImport("kernel32", SetLastError = true)]
    private static partial BOOL ReadProcessMemory(HANDLE ProcessHandle, nint lpBaseAddress, [MarshalAs(UnmanagedType.LPWStr)] string lpBuffer, nint dwSize, nint lpNumberOfBytesRead);
}