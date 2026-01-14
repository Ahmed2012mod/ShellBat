#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/shell/ishelldispatch2-object
[GeneratedComInterface, Guid("a4c6892c-3ba9-11d2-9dea-00c04fb16162")]
public partial interface IShellDispatch2 : IShellDispatch
{
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch2-isrestricted
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsRestricted(BSTR Group, BSTR Restriction, out int plRestrictValue);
    
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch2-shellexecute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShellExecute(BSTR File, VARIANT vArgs, VARIANT vDir, VARIANT vOperation, VARIANT vShow);
    
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch2-findprinter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindPrinter(BSTR name, BSTR location, BSTR model);
    
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch2-getsysteminformation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSystemInformation(BSTR name, out VARIANT pv);
    
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch2-servicestart
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ServiceStart(BSTR ServiceName, VARIANT Persistent, out VARIANT pSuccess);
    
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch2-servicestop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ServiceStop(BSTR ServiceName, VARIANT Persistent, out VARIANT pSuccess);
    
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch2-isservicerunning
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsServiceRunning(BSTR ServiceName, out VARIANT pRunning);
    
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch2-canstartstopservice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CanStartStopService(BSTR ServiceName, out VARIANT pCanStartStop);
    
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch2-showbrowserbar
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShowBrowserBar(BSTR bstrClsid, VARIANT bShow, out VARIANT pSuccess);
}
