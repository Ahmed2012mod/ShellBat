#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iinitializewithitem
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("7f73be3f-fb79-493c-a6c7-7ee14e245841")]
public partial interface IInitializeWithItem
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iinitializewithitem-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psi, uint grfMode);
}
