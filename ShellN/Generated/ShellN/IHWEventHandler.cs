#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-ihweventhandler
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("c1fb73d0-ec3a-4ba2-b512-8cdb9187b6d1")]
public partial interface IHWEventHandler
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ihweventhandler-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(PWSTR pszParams);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ihweventhandler-handleevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HandleEvent(PWSTR pszDeviceID, PWSTR pszAltDeviceID, PWSTR pszEventType);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ihweventhandler-handleeventwithcontent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HandleEventWithContent(PWSTR pszDeviceID, PWSTR pszAltDeviceID, PWSTR pszEventType, PWSTR pszContentTypeHandler, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDataObject>))] IDataObject pdataobject);
}
