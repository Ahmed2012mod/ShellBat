#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/searchapi/nn-searchapi-ienumsearchroots
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("ab310581-ac80-11d1-8df3-00c04fb6ef52")]
public partial interface IEnumSearchRoots
{
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-ienumsearchroots-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint celt, [In][Out][MarshalUsing(CountElementName = nameof(celt))] nint[] rgelt, ref uint pceltFetched);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-ienumsearchroots-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint celt);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-ienumsearchroots-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-ienumsearchroots-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumSearchRoots>))] out IEnumSearchRoots ppenum);
}
