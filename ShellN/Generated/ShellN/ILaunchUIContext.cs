#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("1791e8f6-21c7-4340-882a-a6a93e3fd73b")]
public partial interface ILaunchUIContext
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAssociatedWindow(HWND value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTabGroupingPreference(uint value);
}
