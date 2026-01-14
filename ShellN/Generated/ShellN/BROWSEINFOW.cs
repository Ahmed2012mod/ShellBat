#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-browseinfow
public partial struct BROWSEINFOW
{
    public HWND hwndOwner;
    public nint pidlRoot;
    public PWSTR pszDisplayName;
    public PWSTR lpszTitle;
    public uint ulFlags;
    public nint lpfn;
    public LPARAM lParam;
    public int iImage;
}
