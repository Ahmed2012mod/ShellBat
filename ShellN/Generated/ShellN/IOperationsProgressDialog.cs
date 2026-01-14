#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ioperationsprogressdialog
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("0c9fb851-e5c9-43eb-a370-f0677b13874c")]
public partial interface IOperationsProgressDialog
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ioperationsprogressdialog-startprogressdialog
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartProgressDialog(HWND hwndOwner, uint flags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ioperationsprogressdialog-stopprogressdialog
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StopProgressDialog();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ioperationsprogressdialog-setoperation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOperation(SPACTION action);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ioperationsprogressdialog-setmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMode(uint mode);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ioperationsprogressdialog-updateprogress
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateProgress(ulong ullPointsCurrent, ulong ullPointsTotal, ulong ullSizeCurrent, ulong ullSizeTotal, ulong ullItemsCurrent, ulong ullItemsTotal);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ioperationsprogressdialog-updatelocations
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateLocations([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiSource, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiTarget, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem>))] IShellItem psiItem);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ioperationsprogressdialog-resettimer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResetTimer();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ioperationsprogressdialog-pausetimer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PauseTimer();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ioperationsprogressdialog-resumetimer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResumeTimer();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ioperationsprogressdialog-getmilliseconds
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMilliseconds(out ulong pullElapsed, out ulong pullRemaining);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ioperationsprogressdialog-getoperationstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOperationStatus(out PDOPSTATUS popstatus);
}
