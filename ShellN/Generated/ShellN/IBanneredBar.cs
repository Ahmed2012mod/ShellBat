#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("596a9a94-013e-11d1-8d34-00a0c90f2719")]
public partial interface IBanneredBar
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIconSize(uint iIcon);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIconSize(out uint piIcon);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBitmap(HBITMAP hBitmap);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBitmap(out HBITMAP phBitmap);
}
