#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-inamespacewalk
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("57ced8a7-3f4a-432c-9350-30f24483f74f")]
public partial interface INamespaceWalk
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-inamespacewalk-walk
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Walk(nint punkToWalk, uint dwFlags, int cDepth, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<INamespaceWalkCB>))] INamespaceWalkCB pnswcb);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-inamespacewalk-getidarrayresult
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIDArrayResult(out uint pcItems, [MarshalUsing(CountElementName = nameof(pcItems))] out nint[] prgpidl);
}
