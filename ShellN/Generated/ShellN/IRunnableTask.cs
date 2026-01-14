#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-irunnabletask
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("85788d00-6807-11d0-b810-00c04fd706ec")]
public partial interface IRunnableTask
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-irunnabletask-run
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Run();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-irunnabletask-kill
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Kill(BOOL bWait);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-irunnabletask-suspend
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Suspend();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-irunnabletask-resume
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Resume();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-irunnabletask-isrunning
    [PreserveSig]
    uint IsRunning();
}
