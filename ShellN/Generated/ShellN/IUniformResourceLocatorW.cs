#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("cabb0da0-da57-11cf-9974-0020afd79762")]
public partial interface IUniformResourceLocatorW
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetURL(PWSTR pcszURL, uint dwInFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetURL(out PWSTR ppszURL);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InvokeCommand(ref URLINVOKECOMMANDINFOW purlici);
}
