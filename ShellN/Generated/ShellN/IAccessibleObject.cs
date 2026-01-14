#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-iaccessibleobject
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("95a391c5-9ed4-4c28-8401-ab9e06719e11")]
public partial interface IAccessibleObject
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iaccessibleobject-setaccessiblename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAccessibleName(PWSTR pszName);
}
