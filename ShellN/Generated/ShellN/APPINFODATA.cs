#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shappmgr/ns-shappmgr-appinfodata
public partial struct APPINFODATA
{
    public uint cbSize;
    public uint dwMask;
    public PWSTR pszDisplayName;
    public PWSTR pszVersion;
    public PWSTR pszPublisher;
    public PWSTR pszProductID;
    public PWSTR pszRegisteredOwner;
    public PWSTR pszRegisteredCompany;
    public PWSTR pszLanguage;
    public PWSTR pszSupportUrl;
    public PWSTR pszSupportTelephone;
    public PWSTR pszHelpLink;
    public PWSTR pszInstallLocation;
    public PWSTR pszInstallSource;
    public PWSTR pszInstallDate;
    public PWSTR pszContact;
    public PWSTR pszComments;
    public PWSTR pszImage;
    public PWSTR pszReadmeUrl;
    public PWSTR pszUpdateInfoUrl;
}
