#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("60e567c8-9573-4ab2-a264-637c6c161cb1")]
public partial interface IShellUIHelper7 : IShellUIHelper6
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetExperimentalFlag(BSTR bstrFlagString, VARIANT_BOOL vfFlag);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetExperimentalFlag(BSTR bstrFlagString, out VARIANT_BOOL vfFlag);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetExperimentalValue(BSTR bstrValueString, uint dwValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetExperimentalValue(BSTR bstrValueString, out uint pdwValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResetAllExperimentalFlagsAndValues();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNeedIEAutoLaunchFlag(BSTR bstrUrl, out VARIANT_BOOL flag);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNeedIEAutoLaunchFlag(BSTR bstrUrl, VARIANT_BOOL flag);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HasNeedIEAutoLaunchFlag(BSTR bstrUrl, out VARIANT_BOOL exists);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LaunchIE(BSTR bstrUrl, VARIANT_BOOL automated);
}
