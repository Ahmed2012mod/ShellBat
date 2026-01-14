#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shldisp/nn-shldisp-ishellfolderviewdual2
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("31c147b6-0ade-4a3c-b514-ddf932ef6d17")]
public partial interface IShellFolderViewDual2 : IShellFolderViewDual
{
    // https://learn.microsoft.com/windows/win32/api/shldisp/nf-shldisp-ishellfolderviewdual2-get_currentviewmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CurrentViewMode(out uint pViewMode);
    
    // https://learn.microsoft.com/windows/win32/api/shldisp/nf-shldisp-ishellfolderviewdual2-put_currentviewmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_CurrentViewMode(uint ViewMode);
    
    // https://learn.microsoft.com/windows/win32/api/shldisp/nf-shldisp-ishellfolderviewdual2-selectitemrelative
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectItemRelative(int iRelative);
}
