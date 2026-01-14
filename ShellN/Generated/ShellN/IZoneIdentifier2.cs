#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("eb5e760c-09ef-45c0-b510-70830ce31e6a")]
public partial interface IZoneIdentifier2 : IZoneIdentifier
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLastWriterPackageFamilyName(out PWSTR packageFamilyName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLastWriterPackageFamilyName(PWSTR packageFamilyName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveLastWriterPackageFamilyName();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAppZoneId(out uint zone);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAppZoneId(uint zone);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveAppZoneId();
}
