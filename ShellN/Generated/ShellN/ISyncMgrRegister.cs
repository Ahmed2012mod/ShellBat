#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/mobsync/nn-mobsync-isyncmgrregister
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("6295df42-35ee-11d1-8707-00c04fd93327")]
public partial interface ISyncMgrRegister
{
    // https://learn.microsoft.com/windows/win32/api/mobsync/nf-mobsync-isyncmgrregister-registersyncmgrhandler
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterSyncMgrHandler(in Guid clsidHandler, PWSTR pwszDescription, uint dwSyncMgrRegisterFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mobsync/nf-mobsync-isyncmgrregister-unregistersyncmgrhandler
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterSyncMgrHandler(in Guid clsidHandler, uint dwReserved);
    
    // https://learn.microsoft.com/windows/win32/api/mobsync/nf-mobsync-isyncmgrregister-gethandlerregistrationinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHandlerRegistrationInfo(in Guid clsidHandler, ref uint pdwSyncMgrRegisterFlags);
}
