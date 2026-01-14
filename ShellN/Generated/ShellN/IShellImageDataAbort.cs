#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shimgdata/nn-shimgdata-ishellimagedataabort
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("53fb8e58-50c0-4003-b4aa-0c8df28e7f3a")]
public partial interface IShellImageDataAbort
{
    // https://learn.microsoft.com/windows/win32/api/shimgdata/nf-shimgdata-ishellimagedataabort-queryabort
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryAbort();
}
