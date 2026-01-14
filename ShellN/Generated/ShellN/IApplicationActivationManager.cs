#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iapplicationactivationmanager
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("2e941141-7f97-4756-ba1d-9decde894a3d")]
public partial interface IApplicationActivationManager
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationactivationmanager-activateapplication
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ActivateApplication(PWSTR appUserModelId, PWSTR arguments, ACTIVATEOPTIONS options, out uint processId);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationactivationmanager-activateforfile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ActivateForFile(PWSTR appUserModelId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItemArray>))] IShellItemArray itemArray, PWSTR verb, out uint processId);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationactivationmanager-activateforprotocol
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ActivateForProtocol(PWSTR appUserModelId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItemArray>))] IShellItemArray itemArray, out uint processId);
}
