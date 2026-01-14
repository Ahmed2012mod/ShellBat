#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ipackagedebugsettings
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("f27c3930-8029-4ad1-94e3-3dba417810c1")]
public partial interface IPackageDebugSettings
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipackagedebugsettings-enabledebugging
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnableDebugging(PWSTR packageFullName, PWSTR debuggerCommandLine, PWSTR environment);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipackagedebugsettings-disabledebugging
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DisableDebugging(PWSTR packageFullName);
    
    // https://learn.microsoft.com/windows/win32/WinRT/ipackagedebugsettings-suspend
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Suspend(PWSTR packageFullName);
    
    // https://learn.microsoft.com/windows/win32/WinRT/ipackagedebugsettings-resume
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Resume(PWSTR packageFullName);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipackagedebugsettings-terminateallprocesses
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TerminateAllProcesses(PWSTR packageFullName);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipackagedebugsettings-settargetsessionid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTargetSessionId(uint sessionId);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipackagedebugsettings-enumeratebackgroundtasks
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumerateBackgroundTasks(PWSTR packageFullName, out uint taskCount, out nint taskIds, out nint taskNames);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipackagedebugsettings-activatebackgroundtask
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ActivateBackgroundTask(in Guid taskId);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipackagedebugsettings-startservicing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartServicing(PWSTR packageFullName);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipackagedebugsettings-stopservicing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StopServicing(PWSTR packageFullName);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipackagedebugsettings-startsessionredirection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartSessionRedirection(PWSTR packageFullName, uint sessionId);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipackagedebugsettings-stopsessionredirection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StopSessionRedirection(PWSTR packageFullName);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipackagedebugsettings-getpackageexecutionstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPackageExecutionState(PWSTR packageFullName, out PACKAGE_EXECUTION_STATE packageExecutionState);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipackagedebugsettings-registerforpackagestatechanges
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterForPackageStateChanges(PWSTR packageFullName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPackageExecutionStateChangeNotification>))] IPackageExecutionStateChangeNotification pPackageExecutionStateChangeNotification, out uint pdwCookie);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ipackagedebugsettings-unregisterforpackagestatechanges
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterForPackageStateChanges(uint dwCookie);
}
