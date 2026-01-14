#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/syncmgr/nn-syncmgr-isyncmgruioperation
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("fc7cfa47-dfe1-45b5-a049-8cfd82bec271")]
public partial interface ISyncMgrUIOperation
{
    // https://learn.microsoft.com/windows/win32/api/syncmgr/nf-syncmgr-isyncmgruioperation-run
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Run(HWND hwndOwner);
}
