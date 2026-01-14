#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ifolderfiltersite
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("c0a651f5-b48b-11d2-b5ed-006097c686f6")]
public partial interface IFolderFilterSite
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ifolderfiltersite-setfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFilter(nint punk);
}
