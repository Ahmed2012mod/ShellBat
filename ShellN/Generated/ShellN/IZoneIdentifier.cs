#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("cd45f185-1b21-48e2-967b-ead743a8914e")]
public partial interface IZoneIdentifier
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetId(out uint pdwZone);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetId(uint dwZone);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Remove();
}
