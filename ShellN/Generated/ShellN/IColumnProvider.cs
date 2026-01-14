#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj/nn-shlobj-icolumnprovider
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("e8025004-1c42-11d2-be2c-00a0c9a83da1")]
public partial interface IColumnProvider
{
    // https://learn.microsoft.com/windows/win32/api/shlobj/nf-shlobj-icolumnprovider-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(in SHCOLUMNINIT psci);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj/nf-shlobj-icolumnprovider-getcolumninfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetColumnInfo(uint dwIndex, out SHCOLUMNINFO psci);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj/nf-shlobj-icolumnprovider-getitemdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItemData(in PROPERTYKEY pscid, in SHCOLUMNDATA pscd, out VARIANT pvarData);
}
