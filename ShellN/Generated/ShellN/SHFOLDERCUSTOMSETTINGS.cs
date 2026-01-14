#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/ns-shlobj_core-shfoldercustomsettings
public partial struct SHFOLDERCUSTOMSETTINGS
{
    public uint dwSize;
    public uint dwMask;
    public nint pvid;
    public PWSTR pszWebViewTemplate;
    public uint cchWebViewTemplate;
    public PWSTR pszWebViewTemplateVersion;
    public PWSTR pszInfoTip;
    public uint cchInfoTip;
    public nint pclsid;
    public uint dwFlags;
    public PWSTR pszIconFile;
    public uint cchIconFile;
    public int iIconIndex;
    public PWSTR pszLogo;
    public uint cchLogo;
}
