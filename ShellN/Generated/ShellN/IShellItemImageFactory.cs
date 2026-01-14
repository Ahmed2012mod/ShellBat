#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ishellitemimagefactory
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("bcc18b79-ba16-442f-80c4-8a59c30c463b")]
public partial interface IShellItemImageFactory
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellitemimagefactory-getimage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetImage(SIZE size, SIIGBF flags, out HBITMAP phbm);
}
