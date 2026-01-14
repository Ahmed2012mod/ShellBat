#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-ienumerableview
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("8c8bf236-1aec-495f-9894-91d57c3c686f")]
public partial interface IEnumerableView
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ienumerableview-setenumreadycallback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEnumReadyCallback([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumReadyCallback>))] IEnumReadyCallback percb);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-ienumerableview-createenumidlistfromcontents
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateEnumIDListFromContents(nint pidlFolder, uint dwEnumFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumIDList>))] out IEnumIDList ppEnumIDList);
}
