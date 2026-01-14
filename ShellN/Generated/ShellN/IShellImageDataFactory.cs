#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shimgdata/nn-shimgdata-ishellimagedatafactory
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("9be8ed5c-edab-4d75-90f3-bd5bdbb21c82")]
public partial interface IShellImageDataFactory
{
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedatafactory-createishellimagedata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateIShellImageData([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellImageData>))] out IShellImageData ppshimg);
    
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedatafactory-createimagefromfile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateImageFromFile(PWSTR pszPath, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellImageData>))] out IShellImageData ppshimg);
    
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedatafactory-createimagefromstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateImageFromStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream?>))] IStream? pStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellImageData>))] out IShellImageData ppshimg);
    
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedatafactory-getdataformatfrompath
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDataFormatFromPath(PWSTR pszPath, out Guid pDataFormat);
}
