#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("70aa1c9e-f2b4-4c61-86d3-6b9fb75fd1a2")]
public partial interface IRadioInstance
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRadioManagerSignature(out Guid pguidSignature);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInstanceSignature(out BSTR pbstrId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFriendlyName(uint lcid, out BSTR pbstrName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRadioState(out DEVICE_RADIO_STATE pRadioState);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRadioState(DEVICE_RADIO_STATE radioState, uint uTimeoutSec);
    
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL IsMultiComm();
    
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL IsAssociatingDevice();
}
