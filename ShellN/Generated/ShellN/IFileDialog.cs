#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ifiledialog
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("42f85136-db7e-439c-85f1-e4075d135fc8")]
public partial interface IFileDialog : IModalWindow
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialog-setfiletypes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFileTypes(uint cFileTypes, [In][MarshalUsing(CountElementName = nameof(cFileTypes))] COMDLG_FILTERSPEC[] rgFilterSpec);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialog-setfiletypeindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFileTypeIndex(uint iFileType);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialog-getfiletypeindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFileTypeIndex(out uint piFileType);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialog-advise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Advise([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IFileDialogEvents>))] IFileDialogEvents pfde, out uint pdwCookie);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialog-unadvise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unadvise(uint dwCookie);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialog-setoptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOptions(FILEOPENDIALOGOPTIONS fos);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialog-getoptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOptions(out FILEOPENDIALOGOPTIONS pfos);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialog-setdefaultfolder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDefaultFolder([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psi);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialog-setfolder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFolder([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psi);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialog-getfolder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFolder([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] out IShellItem ppsi);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialog-getcurrentselection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentSelection([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] out IShellItem ppsi);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialog-setfilename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFileName(PWSTR pszName);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialog-getfilename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFileName(out PWSTR pszName);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialog-settitle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTitle(PWSTR pszTitle);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialog-setokbuttonlabel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOkButtonLabel(PWSTR pszText);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialog-setfilenamelabel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFileNameLabel(PWSTR pszLabel);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialog-getresult
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetResult([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] out IShellItem ppsi);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialog-addplace
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddPlace([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psi, FDAP fdap);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialog-setdefaultextension
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDefaultExtension(PWSTR pszDefaultExtension);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialog-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close(HRESULT hr);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialog-setclientguid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetClientGuid(in Guid guid);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialog-clearclientdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ClearClientData();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifiledialog-setfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFilter([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItemFilter>))] IShellItemFilter pFilter);
}
