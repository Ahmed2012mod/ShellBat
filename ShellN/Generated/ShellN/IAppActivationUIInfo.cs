#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("abad189d-9fa3-4278-b3ca-8ca448a88dcb")]
public partial interface IAppActivationUIInfo
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMonitor(out HMONITOR value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInvokePoint(out POINT value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetShowCommand(out int value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetShowUI(out BOOL value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetKeyState(out uint value);
}
