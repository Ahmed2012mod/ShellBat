#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-ifolderviewoptions
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("3cc974d2-b302-4d36-ad3e-06d93f695d3f")]
public partial interface IFolderViewOptions
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ifolderviewoptions-setfolderviewoptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFolderViewOptions(FOLDERVIEWOPTIONS fvoMask, FOLDERVIEWOPTIONS fvoFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ifolderviewoptions-getfolderviewoptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFolderViewOptions(out FOLDERVIEWOPTIONS pfvoFlags);
}
