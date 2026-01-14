#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iinitializecommand
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("85075acf-231f-40ea-9610-d26b7b58f638")]
public partial interface IInitializeCommand
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iinitializecommand-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(PWSTR pszCommandName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPropertyBag>))] IPropertyBag ppb);
}
