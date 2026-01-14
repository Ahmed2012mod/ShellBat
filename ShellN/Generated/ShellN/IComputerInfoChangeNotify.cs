#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-icomputerinfochangenotify
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("0df60d92-6818-46d6-b358-d66170dde466")]
public partial interface IComputerInfoChangeNotify
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-icomputerinfochangenotify-computerinfochanged
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ComputerInfoChanged();
}
