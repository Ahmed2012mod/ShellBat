#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iassochandler
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("f04061ac-1659-4a3f-a954-775aa57fc083")]
public partial interface IAssocHandler
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iassochandler-getname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetName(out PWSTR ppsz);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iassochandler-getuiname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUIName(out PWSTR ppsz);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iassochandler-geticonlocation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIconLocation(out PWSTR ppszPath, out int pIndex);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iassochandler-isrecommended
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsRecommended();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iassochandler-makedefault
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MakeDefault(PWSTR pszDescription);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iassochandler-invoke
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDataObject>))] IDataObject pdo);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iassochandler-createinvoker
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateInvoker([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDataObject>))] IDataObject pdo, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAssocHandlerInvoker>))] out IAssocHandlerInvoker ppInvoker);
}
