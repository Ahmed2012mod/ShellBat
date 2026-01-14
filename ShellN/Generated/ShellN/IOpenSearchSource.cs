#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iopensearchsource
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("f0ee7333-e6fc-479b-9f25-a860c234a38e")]
public partial interface IOpenSearchSource
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iopensearchsource-getresults
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetResults(HWND hwnd, PWSTR pszQuery, uint dwStartIndex, uint dwCount, in Guid riid, out nint /* void */ ppv);
}
