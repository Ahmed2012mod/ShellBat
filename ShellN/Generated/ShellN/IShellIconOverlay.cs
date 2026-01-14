#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/nn-shlobj_core-ishelliconoverlay
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("7d688a70-c613-11d0-999b-00c04fd655e1")]
public partial interface IShellIconOverlay
{
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishelliconoverlay-getoverlayindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOverlayIndex(nint pidl, ref int pIndex);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishelliconoverlay-getoverlayiconindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOverlayIconIndex(nint pidl, ref int pIconIndex);
}
