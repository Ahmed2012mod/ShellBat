#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-iimagerecompress
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("505f1513-6b3e-4892-a272-59f8889a4d3e")]
public partial interface IImageRecompress
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iimagerecompress-recompressimage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RecompressImage([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psi, int cx, int cy, int iQuality, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStorage>))] IStorage pstg, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] out IStream ppstrmOut);
}
