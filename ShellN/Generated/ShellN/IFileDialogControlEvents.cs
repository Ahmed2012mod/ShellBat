#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-ifiledialogcontrolevents
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("36116642-d713-4b97-9b83-7484a9d00433")]
public partial interface IFileDialogControlEvents
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ifiledialogcontrolevents-onitemselected
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnItemSelected([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IFileDialogCustomize>))] IFileDialogCustomize pfdc, uint dwIDCtl, uint dwIDItem);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ifiledialogcontrolevents-onbuttonclicked
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnButtonClicked([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IFileDialogCustomize>))] IFileDialogCustomize pfdc, uint dwIDCtl);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ifiledialogcontrolevents-oncheckbuttontoggled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnCheckButtonToggled([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IFileDialogCustomize>))] IFileDialogCustomize pfdc, uint dwIDCtl, BOOL bChecked);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ifiledialogcontrolevents-oncontrolactivating
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnControlActivating([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IFileDialogCustomize>))] IFileDialogCustomize pfdc, uint dwIDCtl);
}
