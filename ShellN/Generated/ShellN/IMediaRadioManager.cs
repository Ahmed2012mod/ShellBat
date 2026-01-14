#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("6cfdcab5-fc47-42a5-9241-074b58830e73")]
public partial interface IMediaRadioManager
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRadioInstances([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IRadioInstanceCollection>))] out IRadioInstanceCollection ppCollection);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnSystemRadioStateChange(SYSTEM_RADIO_STATE sysRadioState, uint uTimeoutSec);
}
