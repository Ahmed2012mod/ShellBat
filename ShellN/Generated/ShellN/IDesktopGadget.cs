#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-idesktopgadget
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("c1646bc4-f298-4f91-a204-eb2dd1709d1a")]
public partial interface IDesktopGadget
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-idesktopgadget-rungadget
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RunGadget(PWSTR gadgetPath);
}
