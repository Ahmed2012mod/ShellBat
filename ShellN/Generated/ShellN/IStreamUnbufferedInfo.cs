#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-istreamunbufferedinfo
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("8a68fdda-1fdc-4c20-8ceb-416643b5a625")]
public partial interface IStreamUnbufferedInfo
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-istreamunbufferedinfo-getsectorsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSectorSize(out uint pcbSectorSize);
}
