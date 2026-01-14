#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/shell/ishelldispatch
[GeneratedComInterface, Guid("d8f015c0-c278-11ce-a49e-444553540000")]
public partial interface IShellDispatch : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Application([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch ppid);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Parent([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch ppid);
    
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch-namespace
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NameSpace(VARIANT vDir, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<Folder>))] out Folder ppsdf);
    
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch-browseforfolder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BrowseForFolder(int Hwnd, BSTR Title, int Options, VARIANT RootFolder, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<Folder>))] out Folder ppsdf);
    
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch-windows
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Windows([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch ppid);
    
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch-open
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Open(VARIANT vDir);
    
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch-explore
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Explore(VARIANT vDir);
    
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch-minimizeall
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MinimizeAll();
    
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch-undominimizeall
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UndoMinimizeALL();
    
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch-filerun
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FileRun();
    
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch-cascadewindows
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CascadeWindows();
    
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch-tilevertically
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TileVertically();
    
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch-tilehorizontally
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TileHorizontally();
    
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch-shutdownwindows
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShutdownWindows();
    
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch-suspend
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Suspend();
    
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch-ejectpc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EjectPC();
    
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch-settime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTime();
    
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch-trayproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TrayProperties();
    
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch-help
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Help();
    
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch-findfiles
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindFiles();
    
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch-findcomputer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindComputer();
    
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch-refreshmenu
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RefreshMenu();
    
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch-controlpanelitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ControlPanelItem(BSTR bstrDir);
}
