#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("79eac9cb-baf9-11ce-8c82-00aa004ba90b")]
public partial interface IExtensionServices
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAdditionalHeaders(PWSTR pwzAdditionalHeaders);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAuthenticateData(HWND phwnd, PWSTR pwzUsername, PWSTR pwzPassword);
}
