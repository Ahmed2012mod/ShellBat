#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iobjectwithfolderenummode
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("6a9d9026-0e6e-464c-b000-42ecc07de673")]
public partial interface IObjectWithFolderEnumMode
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iobjectwithfolderenummode-setmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMode(FOLDER_ENUM_MODE feMode);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iobjectwithfolderenummode-getmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMode(out FOLDER_ENUM_MODE pfeMode);
}
