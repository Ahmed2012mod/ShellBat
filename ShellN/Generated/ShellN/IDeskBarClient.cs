#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("eb0fe175-1a3a-11d0-89b3-00a0c90a90ac")]
public partial interface IDeskBarClient : IOleWindow
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDeskBarSite(nint punkSite);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetModeDBC(uint dwMode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UIActivateDBC(uint dwState);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSize(uint dwWhich, out RECT prc);
}
