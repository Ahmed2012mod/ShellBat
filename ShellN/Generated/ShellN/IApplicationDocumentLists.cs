#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iapplicationdocumentlists
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("3c594f9f-9f30-47a1-979a-c9e83d3d0a06")]
public partial interface IApplicationDocumentLists
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdocumentlists-setappid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAppID(PWSTR pszAppID);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iapplicationdocumentlists-getlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetList(APPDOCLISTTYPE listtype, uint cItemsDesired, in Guid riid, out nint /* void */ ppv);
}
