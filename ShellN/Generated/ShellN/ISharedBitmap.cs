#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/thumbcache/nn-thumbcache-isharedbitmap
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("091162a4-bc96-411f-aae8-c5122cd03363")]
public partial interface ISharedBitmap
{
    // https://learn.microsoft.com/windows/win32/api/thumbcache/nf-thumbcache-isharedbitmap-getsharedbitmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSharedBitmap(out HBITMAP phbm);
    
    // https://learn.microsoft.com/windows/win32/api/thumbcache/nf-thumbcache-isharedbitmap-getsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSize(out SIZE pSize);
    
    // https://learn.microsoft.com/windows/win32/api/thumbcache/nf-thumbcache-isharedbitmap-getformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFormat(out WTS_ALPHATYPE pat);
    
    // https://learn.microsoft.com/windows/win32/api/thumbcache/nf-thumbcache-isharedbitmap-initializebitmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializeBitmap(HBITMAP hbm, WTS_ALPHATYPE wtsAT);
    
    // https://learn.microsoft.com/windows/win32/api/thumbcache/nf-thumbcache-isharedbitmap-detach
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Detach(out HBITMAP phbm);
}
