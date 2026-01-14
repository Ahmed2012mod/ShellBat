#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("a7ae5f64-c4d7-4d7f-9307-4d24ee54b841")]
public partial interface Folder3 : Folder2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ShowWebViewBarricade(out VARIANT_BOOL pbShowWebViewBarricade);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ShowWebViewBarricade(VARIANT_BOOL bShowWebViewBarricade);
}
