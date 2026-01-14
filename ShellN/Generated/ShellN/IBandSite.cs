#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ibandsite
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("4cf504b0-de96-11d0-8b3f-00a0c911e8e5")]
public partial interface IBandSite
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ibandsite-addband
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddBand(nint punk);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ibandsite-enumbands
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumBands(uint uBand, out uint pdwBandID);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ibandsite-queryband
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryBand(uint dwBandID, nint /* optional IDeskBand* */ ppstb, nint /* optional uint* */ pdwState, [MarshalUsing(CountElementName = nameof(cchName))] PWSTR pszName, int cchName);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ibandsite-setbandstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBandState(uint dwBandID, uint dwMask, uint dwState);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ibandsite-removeband
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveBand(uint dwBandID);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ibandsite-getbandobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBandObject(uint dwBandID, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ibandsite-setbandsiteinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBandSiteInfo(in BANDSITEINFO pbsinfo);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ibandsite-getbandsiteinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBandSiteInfo(ref BANDSITEINFO pbsinfo);
}
