#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("eab22ac1-30c1-11cf-a7eb-0000c05bae0b")]
public partial interface IWebBrowser : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GoBack();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GoForward();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GoHome();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GoSearch();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Navigate(BSTR URL, nint /* optional VARIANT* */ Flags, nint /* optional VARIANT* */ TargetFrameName, nint /* optional VARIANT* */ PostData, nint /* optional VARIANT* */ Headers);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Refresh();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Refresh2(nint /* optional VARIANT* */ Level);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Application([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch ppDisp);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Parent([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch ppDisp);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Container([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch ppDisp);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Document([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch ppDisp);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TopLevelContainer(out VARIANT_BOOL pBool);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Type(out BSTR Type);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Left(out int pl);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Left(int Left);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Top(out int pl);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Top(int Top);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Width(out int pl);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Width(int Width);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Height(out int pl);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Height(int Height);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LocationName(out BSTR LocationName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LocationURL(out BSTR LocationURL);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Busy(out VARIANT_BOOL pBool);
}
