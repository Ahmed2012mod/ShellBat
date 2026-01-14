#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ienumassochandlers
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("973810ae-9599-4b88-9e4d-6ee98c9552da")]
public partial interface IEnumAssocHandlers
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ienumassochandlers-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint celt, [In][Out][MarshalUsing(CountElementName = nameof(celt))] nint[] rgelt, nint /* optional uint* */ pceltFetched);
}
