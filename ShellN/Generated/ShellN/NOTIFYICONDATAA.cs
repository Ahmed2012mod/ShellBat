#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shellapi/ns-shellapi-notifyicondataa
public partial struct NOTIFYICONDATAA
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public uint uTimeout;
        
        [FieldOffset(0)]
        public uint uVersion;
    }
    
    public uint cbSize;
    public HWND hWnd;
    public uint uID;
    public NOTIFY_ICON_DATA_FLAGS uFlags;
    public uint uCallbackMessage;
    public HICON hIcon;
    public InlineArrayFoundationCHAR_128 szTip;
    public NOTIFY_ICON_STATE dwState;
    public NOTIFY_ICON_STATE dwStateMask;
    public InlineArrayFoundationCHAR_256 szInfo;
    public _Anonymous_e__Union Anonymous;
    public InlineArrayFoundationCHAR_64 szInfoTitle;
    public NOTIFY_ICON_INFOTIP_FLAGS dwInfoFlags;
    public Guid guidItem;
    public HICON hBalloonIcon;
}
