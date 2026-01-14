#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("7ebfdd87-ad18-11d3-a4c5-00c04f72d6b8")]
public partial interface ITravelLogEntry
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTitle(out PWSTR ppszTitle);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetURL(out PWSTR ppszURL);
}
