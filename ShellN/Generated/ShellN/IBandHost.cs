#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-ibandhost
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("b9075c7c-d48e-403f-ab99-d6c77a1084ac")]
public partial interface IBandHost
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ibandhost-createband
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBand(in Guid rclsidBand, BOOL fAvailable, BOOL fVisible, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ibandhost-setbandavailability
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBandAvailability(in Guid rclsidBand, BOOL fAvailable);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ibandhost-destroyband
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DestroyBand(in Guid rclsidBand);
}
