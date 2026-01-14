#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ishelltaskscheduler
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("6ccb7be0-6807-11d0-b810-00c04fd706ec")]
public partial interface IShellTaskScheduler
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelltaskscheduler-addtask
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddTask([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IRunnableTask>))] IRunnableTask prt, in Guid rtoid, nuint lParam, uint dwPriority);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelltaskscheduler-removetasks
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveTasks(in Guid rtoid, nuint lParam, BOOL bWaitIfRunning);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelltaskscheduler-counttasks
    [PreserveSig]
    uint CountTasks(in Guid rtoid);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishelltaskscheduler-status
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Status(uint dwReleaseStatus, uint dwThreadTimeout);
}
