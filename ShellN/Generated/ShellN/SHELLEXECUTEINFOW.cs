#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shellapi/ns-shellapi-shellexecuteinfow
public partial struct SHELLEXECUTEINFOW
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public HANDLE hIcon;
        
        [FieldOffset(0)]
        public HANDLE hMonitor;
    }
    
    public uint cbSize;
    public uint fMask;
    public HWND hwnd;
    public PWSTR lpVerb;
    public PWSTR lpFile;
    public PWSTR lpParameters;
    public PWSTR lpDirectory;
    public int nShow;
    public HINSTANCE hInstApp;
    public nint lpIDList;
    public PWSTR lpClass;
    public HKEY hkeyClass;
    public uint dwHotKey;
    public _Anonymous_e__Union Anonymous;
    public HANDLE hProcess;
}
