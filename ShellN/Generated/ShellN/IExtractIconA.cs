#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shlobj_core/nn-shlobj_core-iextracticona
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("000214eb-0000-0000-c000-000000000046")]
public partial interface IExtractIconA
{
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-iextracticona-geticonlocation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIconLocation(uint uFlags, [MarshalUsing(CountElementName = nameof(cchMax))] PSTR pszIconFile, uint cchMax, out int piIndex, out uint pwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/shlobj_core/nf-shlobj_core-iextracticona-extract
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Extract(PSTR pszFile, uint nIconIndex, nint /* optional HICON* */ phiconLarge, nint /* optional HICON* */ phiconSmall, uint nIconSize);
}
