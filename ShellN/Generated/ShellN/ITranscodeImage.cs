#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/imagetranscode/nn-imagetranscode-itranscodeimage
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("bae86ddd-dc11-421c-b7ab-cc55d1d65c44")]
public partial interface ITranscodeImage
{
    // https://learn.microsoft.com/windows/win32/api/imagetranscode/nf-imagetranscode-itranscodeimage-transcodeimage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TranscodeImage([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItem?>))] IShellItem? pShellItem, uint uiMaxWidth, uint uiMaxHeight, uint flags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream?>))] IStream? pvImage, out uint puiWidth, out uint puiHeight);
}
