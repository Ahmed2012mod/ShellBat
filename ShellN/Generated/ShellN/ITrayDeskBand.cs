#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-itraydeskband
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("6d67e846-5b9c-4db8-9cbc-dde12f4254f1")]
public partial interface ITrayDeskBand
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-itraydeskband-showdeskband
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShowDeskBand(in Guid clsid);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-itraydeskband-hidedeskband
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HideDeskBand(in Guid clsid);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-itraydeskband-isdeskbandshown
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsDeskBandShown(in Guid clsid);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-itraydeskband-deskbandregistrationchanged
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeskBandRegistrationChanged();
}
