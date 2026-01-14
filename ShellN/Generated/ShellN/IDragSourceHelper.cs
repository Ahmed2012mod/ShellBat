#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-idragsourcehelper
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("de5bf786-477a-11d2-839d-00c04fd918d0")]
public partial interface IDragSourceHelper
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idragsourcehelper-initializefrombitmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializeFromBitmap(in SHDRAGIMAGE pshdi, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDataObject>))] IDataObject pDataObject);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-idragsourcehelper-initializefromwindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializeFromWindow(HWND hwnd, nint /* optional POINT* */ ppt, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDataObject>))] IDataObject pDataObject);
}
