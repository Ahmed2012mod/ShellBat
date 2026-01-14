namespace ShellBat.Terminals.Interop;

public struct STARTUPINFO
{
    public uint cb;
    public PWSTR lpReserved;
    public PWSTR lpDesktop;
    public PWSTR lpTitle;
    public uint dwX;
    public uint dwY;
    public uint dwXSize;
    public uint dwYSize;
    public uint dwXCountChars;
    public uint dwYCountChars;
    public uint dwFillAttribute;
    public uint dwFlags;
    public ushort wShowWindow;
    public ushort cbReserved2;
    public nint lpReserved2;
    public HANDLE hStdInput;
    public HANDLE hStdOutput;
    public HANDLE hStdError;
}
