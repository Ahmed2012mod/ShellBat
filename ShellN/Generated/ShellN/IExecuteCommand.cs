#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iexecutecommand
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("7f9185b0-cb92-43c5-80a9-92277a4f7b54")]
public partial interface IExecuteCommand
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexecutecommand-setkeystate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetKeyState(uint grfKeyState);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexecutecommand-setparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetParameters(PWSTR pszParameters);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexecutecommand-setposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPosition(POINT pt);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexecutecommand-setshowwindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetShowWindow(int nShow);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexecutecommand-setnoshowui
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNoShowUI(BOOL fNoShowUI);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexecutecommand-setdirectory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDirectory(PWSTR pszDirectory);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexecutecommand-execute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Execute();
}
