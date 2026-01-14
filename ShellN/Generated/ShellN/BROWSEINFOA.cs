#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-browseinfoa
public partial struct BROWSEINFOA
{
    public HWND hwndOwner;
    public nint pidlRoot;
    public PSTR pszDisplayName;
    public PSTR lpszTitle;
    public uint ulFlags;
    public nint lpfn;
    public LPARAM lParam;
    public int iImage;
}
