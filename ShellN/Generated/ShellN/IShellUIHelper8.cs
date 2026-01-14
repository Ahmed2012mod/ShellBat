#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("66debcf2-05b0-4f07-b49b-b96241a65db2")]
public partial interface IShellUIHelper8 : IShellUIHelper7
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCVListData(out BSTR pbstrResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCVListLocalData(out BSTR pbstrResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEMIEListData(out BSTR pbstrResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEMIEListLocalData(out BSTR pbstrResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenFavoritesPane();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenFavoritesSettings();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LaunchInHVSI(BSTR bstrUrl);
}
