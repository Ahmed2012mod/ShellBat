#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/nn-shlobj_core-iurlsearchhook2
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("5ee44da4-6d32-46e3-86bc-07540dedd0e0")]
public partial interface IURLSearchHook2 : IURLSearchHook
{
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-iurlsearchhook2-translatewithsearchcontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TranslateWithSearchContext([MarshalUsing(CountElementName = nameof(cchBufferSize))] PWSTR pwszSearchURL, uint cchBufferSize, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISearchContext?>))] ISearchContext? pSearchContext);
}
