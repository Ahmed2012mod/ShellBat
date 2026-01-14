#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/mobsync/nn-mobsync-isyncmgrenumitems
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("6295df2a-35ee-11d1-8707-00c04fd93327")]
public partial interface ISyncMgrEnumItems
{
    // https://learn.microsoft.com/windows/win32/api/mobsync/nf-mobsync-isyncmgrenumitems-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint celt, [In][Out][MarshalUsing(CountElementName = nameof(celt))] SYNCMGRITEM[] rgelt, out uint pceltFetched);
    
    // https://learn.microsoft.com/windows/win32/api/mobsync/nf-mobsync-isyncmgrenumitems-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint celt);
    
    // https://learn.microsoft.com/windows/win32/api/mobsync/nf-mobsync-isyncmgrenumitems-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/mobsync/nf-mobsync-isyncmgrenumitems-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISyncMgrEnumItems>))] out ISyncMgrEnumItems ppenum);
}
