#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/nn-shlobj_core-iprogressdialog
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("ebbc7c04-315e-11d2-b62f-006097df5bd4")]
public partial interface IProgressDialog
{
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-iprogressdialog-startprogressdialog
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartProgressDialog(HWND hwndParent, nint punkEnableModless, uint dwFlags, nint /* optional void* */ pvResevered);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-iprogressdialog-stopprogressdialog
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StopProgressDialog();
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-iprogressdialog-settitle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTitle(PWSTR pwzTitle);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-iprogressdialog-setanimation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAnimation(HINSTANCE hInstAnimation, uint idAnimation);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-iprogressdialog-hasusercancelled
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL HasUserCancelled();
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-iprogressdialog-setprogress
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProgress(uint dwCompleted, uint dwTotal);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-iprogressdialog-setprogress64
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProgress64(ulong ullCompleted, ulong ullTotal);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-iprogressdialog-setline
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLine(uint dwLineNum, PWSTR pwzString, BOOL fCompactPath, nint /* optional void* */ pvResevered);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-iprogressdialog-setcancelmsg
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCancelMsg(PWSTR pwzCancelMsg, nint /* optional void* */ pvResevered);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-iprogressdialog-timer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Timer(uint dwTimerAction, nint /* optional void* */ pvResevered);
}
