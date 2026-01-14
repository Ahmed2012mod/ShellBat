#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-icreatingprocess
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("c2b937a9-3110-4398-8a56-f34c6342d244")]
public partial interface ICreatingProcess
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-icreatingprocess-oncreating
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnCreating([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICreateProcessInputs>))] ICreateProcessInputs pcpi);
}
