#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iiocancelinformation
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("f5b0bf81-8cb5-4b1b-9449-1a159e0c733c")]
public partial interface IIOCancelInformation
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iiocancelinformation-setcancelinformation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCancelInformation(uint dwThreadID, uint uMsgCancel);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iiocancelinformation-getcancelinformation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCancelInformation(nint /* optional uint* */ pdwThreadID, nint /* optional uint* */ puMsgCancel);
}
