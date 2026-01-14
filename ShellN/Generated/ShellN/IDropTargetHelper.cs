#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-idroptargethelper
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("4657278b-411b-11d2-839a-00c04fd918d0")]
public partial interface IDropTargetHelper
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idroptargethelper-dragenter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DragEnter(HWND hwndTarget, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDataObject>))] IDataObject pDataObject, in POINT ppt, DROPEFFECT dwEffect);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idroptargethelper-dragleave
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DragLeave();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idroptargethelper-dragover
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DragOver(in POINT ppt, DROPEFFECT dwEffect);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idroptargethelper-drop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Drop([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDataObject>))] IDataObject pDataObject, in POINT ppt, DROPEFFECT dwEffect);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idroptargethelper-show
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Show(BOOL fShow);
}
