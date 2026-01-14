#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("fbf23b80-e3f0-101b-8488-00aa003e56f8")]
public partial interface IUniformResourceLocatorA
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetURL(PSTR pcszURL, uint dwInFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetURL(out PSTR ppszURL);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InvokeCommand(ref URLINVOKECOMMANDINFOA purlici);
}
