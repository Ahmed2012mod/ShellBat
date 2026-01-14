#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iextractimage2
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("953bb1ee-93b4-11d1-98a3-00c04fb687da")]
public partial interface IExtractImage2 : IExtractImage
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iextractimage2-getdatestamp
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDateStamp(out FILETIME pDateStamp);
}
