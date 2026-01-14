#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-icdburnext
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("2271dcca-74fc-4414-8fb7-c56b05ace2d7")]
public partial interface ICDBurnExt
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-icdburnext-getsupportedactiontypes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSupportedActionTypes(out uint pdwActions);
}
