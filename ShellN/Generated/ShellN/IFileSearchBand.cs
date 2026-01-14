#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("2d91eea1-9932-11d2-be86-00a0c9a83da1")]
public partial interface IFileSearchBand : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFocus();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSearchParameters(in BSTR pbstrSearchID, VARIANT_BOOL bNavToResults, in VARIANT pvarScope, in VARIANT pvarQueryFile);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SearchID(out BSTR pbstrSearchID);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Scope(out VARIANT pvarScope);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_QueryFile(out VARIANT pvarFile);
}
