#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-inamespacetreeaccessible
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("71f312de-43ed-4190-8477-e9536b82350b")]
public partial interface INameSpaceTreeAccessible
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-inamespacetreeaccessible-ongetdefaultaccessibilityaction
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnGetDefaultAccessibilityAction([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psi, out BSTR pbstrDefaultAction);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-inamespacetreeaccessible-ondodefaultaccessibilityaction
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnDoDefaultAccessibilityAction([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psi);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-inamespacetreeaccessible-ongetaccessibilityrole
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnGetAccessibilityRole([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psi, out VARIANT pvarRole);
}
