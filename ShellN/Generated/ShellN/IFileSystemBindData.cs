#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ifilesystembinddata
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("01e18d10-4d8b-11d2-855d-006008059367")]
public partial interface IFileSystemBindData
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifilesystembinddata-setfinddata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFindData(in WIN32_FIND_DATAW pfd);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifilesystembinddata-getfinddata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFindData(out WIN32_FIND_DATAW pfd);
}
