#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iobjectwithselection
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("1c9cd5bb-98e9-4491-a60f-31aacc72b83c")]
public partial interface IObjectWithSelection
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iobjectwithselection-setselection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSelection([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItemArray>))] IShellItemArray psia);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iobjectwithselection-getselection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSelection(in Guid riid, out nint /* void */ ppv);
}
