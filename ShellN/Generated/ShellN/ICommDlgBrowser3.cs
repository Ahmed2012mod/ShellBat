#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-icommdlgbrowser3
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("c8ad25a1-3294-41ee-8165-71174bd01c57")]
public partial interface ICommDlgBrowser3 : ICommDlgBrowser2
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-icommdlgbrowser3-oncolumnclicked
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnColumnClicked([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellView>))] IShellView ppshv, int iColumn);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-icommdlgbrowser3-getcurrentfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentFilter([MarshalUsing(CountElementName = nameof(cchFileSpec))] PWSTR pszFileSpec, int cchFileSpec);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-icommdlgbrowser3-onpreviewcreated
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnPreViewCreated([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellView>))] IShellView ppshv);
}
