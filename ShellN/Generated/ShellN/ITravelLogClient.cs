#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("241c033e-e659-43da-aa4d-4086dbc4758d")]
public partial interface ITravelLogClient
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindWindowByIndex(uint dwID, out nint ppunk);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWindowData([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream pStream, out WINDOWDATA pWinData);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadHistoryPosition(PWSTR pszUrlLocation, uint dwPosition);
}
