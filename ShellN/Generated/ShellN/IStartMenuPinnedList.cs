#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-istartmenupinnedlist
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("4cd19ada-25a5-4a32-b3b7-347bee5be36b")]
public partial interface IStartMenuPinnedList
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-istartmenupinnedlist-removefromlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveFromList([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem pitem);
}
