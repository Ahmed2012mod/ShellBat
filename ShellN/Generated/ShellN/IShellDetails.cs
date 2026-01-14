#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/nn-shlobj_core-ishelldetails
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("000214ec-0000-0000-c000-000000000046")]
public partial interface IShellDetails
{
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishelldetails-getdetailsof
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDetailsOf(nint /* optional nint* */ pidl, uint iColumn, out SHELLDETAILS pDetails);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-ishelldetails-columnclick
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ColumnClick(uint iColumn);
}
