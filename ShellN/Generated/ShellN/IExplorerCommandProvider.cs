#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iexplorercommandprovider
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("64961751-0835-43c0-8ffe-d57686530e64")]
public partial interface IExplorerCommandProvider
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexplorercommandprovider-getcommands
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCommands(nint punkSite, in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexplorercommandprovider-getcommand
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCommand(in Guid rguidCommandId, in Guid riid, out nint /* void */ ppv);
}
