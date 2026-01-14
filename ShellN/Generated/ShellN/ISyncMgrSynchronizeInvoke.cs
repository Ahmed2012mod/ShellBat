#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/mobsync/nn-mobsync-isyncmgrsynchronizeinvoke
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("6295df2c-35ee-11d1-8707-00c04fd93327")]
public partial interface ISyncMgrSynchronizeInvoke
{
    // https://learn.microsoft.com/windows/win32/api/mobsync/nf-mobsync-isyncmgrsynchronizeinvoke-updateitems
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateItems(uint dwInvokeFlags, in Guid clsid, uint cbCookie, nint /* byte array */ pCookie);
    
    // https://learn.microsoft.com/windows/win32/api/mobsync/nf-mobsync-isyncmgrsynchronizeinvoke-updateall
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateAll();
}
