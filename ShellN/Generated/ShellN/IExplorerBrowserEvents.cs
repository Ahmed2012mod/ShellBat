#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iexplorerbrowserevents
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("361bbdc7-e6ee-4e13-be58-58e2240c810f")]
public partial interface IExplorerBrowserEvents
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexplorerbrowserevents-onnavigationpending
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnNavigationPending(nint pidlFolder);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexplorerbrowserevents-onviewcreated
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnViewCreated([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellView>))] IShellView psv);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexplorerbrowserevents-onnavigationcomplete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnNavigationComplete(nint pidlFolder);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexplorerbrowserevents-onnavigationfailed
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnNavigationFailed(nint pidlFolder);
}
