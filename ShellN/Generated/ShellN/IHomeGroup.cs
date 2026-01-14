#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ihomegroup
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("7a3bd1d9-35a9-4fb3-a467-f48cac35e2d0")]
public partial interface IHomeGroup
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ihomegroup-ismember
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsMember(out BOOL member);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ihomegroup-showsharingwizard
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShowSharingWizard(HWND owner, out HOMEGROUPSHARINGCHOICES sharingchoices);
}
