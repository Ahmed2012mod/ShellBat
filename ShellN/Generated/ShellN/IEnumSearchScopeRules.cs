#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/searchapi/nn-searchapi-ienumsearchscoperules
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("ab310581-ac80-11d1-8df3-00c04fb6ef54")]
public partial interface IEnumSearchScopeRules
{
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-ienumsearchscoperules-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint celt, [In][Out][MarshalUsing(CountElementName = nameof(celt))] nint[] pprgelt, ref uint pceltFetched);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-ienumsearchscoperules-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint celt);
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-ienumsearchscoperules-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/searchapi/nf-searchapi-ienumsearchscoperules-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumSearchScopeRules>))] out IEnumSearchScopeRules ppenum);
}
