#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-icreateprocessinputs
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("f6ef6140-e26f-4d82-bac4-e9ba5fd239a8")]
public partial interface ICreateProcessInputs
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icreateprocessinputs-getcreateflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCreateFlags(out uint pdwCreationFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icreateprocessinputs-setcreateflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCreateFlags(uint dwCreationFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icreateprocessinputs-addcreateflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddCreateFlags(uint dwCreationFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icreateprocessinputs-sethotkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetHotKey(ushort wHotKey);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icreateprocessinputs-addstartupflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddStartupFlags(uint dwStartupInfoFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icreateprocessinputs-settitle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTitle(PWSTR pszTitle);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icreateprocessinputs-setenvironmentvariable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEnvironmentVariable(PWSTR pszName, PWSTR pszValue);
}
