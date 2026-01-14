#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("89d81f5f-c147-49ed-a11c-77b20c31e7c9")]
public partial interface IMediaRadioManagerNotifySink
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnInstanceAdd([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IRadioInstance>))] IRadioInstance pRadioInstance);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnInstanceRemove(BSTR bstrRadioInstanceId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnInstanceRadioChange(BSTR bstrRadioInstanceId, DEVICE_RADIO_STATE radioState);
}
