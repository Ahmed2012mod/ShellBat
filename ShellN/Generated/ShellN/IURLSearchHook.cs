#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/nn-shlobj_core-iurlsearchhook
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("ac60f6a0-0fd9-11d0-99cb-00c04fd64497")]
public partial interface IURLSearchHook
{
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-iurlsearchhook-translate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Translate([MarshalUsing(CountElementName = nameof(cchBufferSize))] PWSTR pwszSearchURL, uint cchBufferSize);
}
