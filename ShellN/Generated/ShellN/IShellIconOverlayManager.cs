#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/nn-shlobj_core-ishelliconoverlaymanager
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("f10b5e34-dd3b-42a7-aa7d-2f4ec54bb09b")]
public partial interface IShellIconOverlayManager
{
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishelliconoverlaymanager-getfileoverlayinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFileOverlayInfo(PWSTR pwszPath, uint dwAttrib, out int pIndex, uint dwflags);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishelliconoverlaymanager-getreservedoverlayinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetReservedOverlayInfo(PWSTR pwszPath, uint dwAttrib, out int pIndex, uint dwflags, int iReservedID);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishelliconoverlaymanager-refreshoverlayimages
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RefreshOverlayImages(uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishelliconoverlaymanager-loadnonloadedoverlayidentifiers
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadNonloadedOverlayIdentifiers();
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishelliconoverlaymanager-overlayindexfromimageindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OverlayIndexFromImageIndex(int iImage, out int piIndex, BOOL fAdd);
}
