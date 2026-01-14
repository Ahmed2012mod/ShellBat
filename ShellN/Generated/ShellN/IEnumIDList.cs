#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ienumidlist
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("000214f2-0000-0000-c000-000000000046")]
public partial interface IEnumIDList
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ienumidlist-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint celt, [In][Out][MarshalUsing(CountElementName = nameof(celt))] nint[] rgelt, nint /* optional uint* */ pceltFetched);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ienumidlist-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint celt);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ienumidlist-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ienumidlist-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumIDList>))] out IEnumIDList ppenum);
}
