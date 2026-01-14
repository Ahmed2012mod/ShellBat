#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-isuspensiondependencymanager
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("52b83a42-2543-416a-81d9-c0de7969c8b3")]
public partial interface ISuspensionDependencyManager
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-isuspensiondependencymanager-registeraschild
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterAsChild(HANDLE processHandle);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-isuspensiondependencymanager-groupchildwithparent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GroupChildWithParent(HANDLE childProcessHandle);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-isuspensiondependencymanager-ungroupchildfromparent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UngroupChildFromParent(HANDLE childProcessHandle);
}
