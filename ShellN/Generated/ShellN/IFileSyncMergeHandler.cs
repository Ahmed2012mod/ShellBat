#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ifilesyncmergehandler
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("d97b5aac-c792-433c-975d-35c4eadc7a9d")]
public partial interface IFileSyncMergeHandler
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifilesyncmergehandler-merge
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Merge(PWSTR localFilePath, PWSTR serverFilePath, out MERGE_UPDATE_STATUS updateStatus);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifilesyncmergehandler-showresolveconflictuiasync
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShowResolveConflictUIAsync(PWSTR localFilePath, HMONITOR monitorToDisplayOn);
}
