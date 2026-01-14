#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-ifolderviewhost
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("1ea58f02-d55a-411d-b09e-9e65ac21605b")]
public partial interface IFolderViewHost
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ifolderviewhost-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(HWND hwndParent, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDataObject>))] IDataObject pdo, in RECT prc);
}
