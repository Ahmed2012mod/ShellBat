#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shdeprecated/ns-shdeprecated-basebrowserdataxp
public partial struct BASEBROWSERDATAXP
{
    public HWND _hwnd;
    public nint _ptl;
    public nint _phlf;
    public nint _pautoWB2;
    public nint _pautoEDS;
    public nint _pautoSS;
    public int _eSecureLockIcon;
    public uint _bitfield;
    public uint _uActivateState;
    public nint _pidlViewState;
    public nint _pctView;
    public nint _pidlCur;
    public nint _psv;
    public nint _psf;
    public HWND _hwndView;
    public PWSTR _pszTitleCur;
    public nint _pidlPending;
    public nint _psvPending;
    public nint _psfPending;
    public HWND _hwndViewPending;
    public PWSTR _pszTitlePending;
    public BOOL _fIsViewMSHTML;
    public BOOL _fPrivacyImpacted;
    public Guid _clsidView;
    public Guid _clsidViewPending;
    public HWND _hwndFrame;
}
