#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iobjectwithappusermodelid
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("36db0196-9665-46d1-9ba7-d3709eecf9ed")]
public partial interface IObjectWithAppUserModelID
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iobjectwithappusermodelid-setappid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAppID(PWSTR pszAppID);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iobjectwithappusermodelid-getappid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAppID(out PWSTR ppszAppID);
}
