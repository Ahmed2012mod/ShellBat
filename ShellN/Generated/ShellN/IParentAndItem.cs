#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iparentanditem
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("b3a4b685-b685-4805-99d9-5dead2873236")]
public partial interface IParentAndItem
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iparentanditem-setparentanditem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetParentAndItem(nint pidlParent, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellFolder>))] IShellFolder psf, nint pidlChild);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iparentanditem-getparentanditem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetParentAndItem(nint /* optional nint** */ ppidlParent, nint /* optional IShellFolder* */ ppsf, nint /* optional nint** */ ppidlChild);
}
