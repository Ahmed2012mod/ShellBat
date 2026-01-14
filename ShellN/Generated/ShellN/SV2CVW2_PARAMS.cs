#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ns-shobjidl_core-sv2cvw2_params
public partial struct SV2CVW2_PARAMS
{
    public uint cbSize;
    public nint psvPrev;
    public nint pfs;
    public nint psbOwner;
    public nint prcView;
    public nint pvid;
    public HWND hwndView;
}
