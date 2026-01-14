#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("6e3194bb-ab82-4d22-93f5-fabda40e7b16")]
public partial interface IPackageDebugSettings2 : IPackageDebugSettings
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumerateApps(PWSTR packageFullName, out uint appCount, out nint appUserModelIds, out nint appDisplayNames);
}
