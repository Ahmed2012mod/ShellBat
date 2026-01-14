#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ifilesystembinddata2
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("3acf075f-71db-4afa-81f0-3fc4fdf2a5b8")]
public partial interface IFileSystemBindData2 : IFileSystemBindData
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifilesystembinddata2-setfileid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFileID(long liFileID);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifilesystembinddata2-getfileid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFileID(out long pliFileID);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifilesystembinddata2-setjunctionclsid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetJunctionCLSID(in Guid clsid);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifilesystembinddata2-getjunctionclsid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetJunctionCLSID(out Guid pclsid);
}
