#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ienumshellitems
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("70629033-e363-4a28-a567-0db78006e6d7")]
public partial interface IEnumShellItems
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ienumshellitems-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint celt, [In][Out][MarshalUsing(CountElementName = nameof(celt))] nint[] rgelt, nint /* optional uint* */ pceltFetched);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ienumshellitems-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint celt);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ienumshellitems-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ienumshellitems-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumShellItems>))] out IEnumShellItems ppenum);
}
