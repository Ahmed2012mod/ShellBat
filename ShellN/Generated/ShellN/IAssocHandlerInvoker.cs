#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iassochandlerinvoker
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("92218cab-ecaa-4335-8133-807fd234c2ee")]
public partial interface IAssocHandlerInvoker
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iassochandlerinvoker-supportsselection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SupportsSelection();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iassochandlerinvoker-invoke
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke();
}
