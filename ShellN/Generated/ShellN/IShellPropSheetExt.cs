#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ishellpropsheetext
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("000214e9-0000-0000-c000-000000000046")]
public partial interface IShellPropSheetExt
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellpropsheetext-addpages
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddPages(LPFNSVADDPROPSHEETPAGE pfnAddPage, LPARAM lParam);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ishellpropsheetext-replacepage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReplacePage(uint uPageID, LPFNSVADDPROPSHEETPAGE pfnReplaceWith, LPARAM lParam);
}
