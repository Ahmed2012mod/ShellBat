#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("0d12c4c8-a3d9-4e24-94c1-0e20c5a956c4")]
public partial interface ILaunchUIContextProvider
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateContext([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ILaunchUIContext>))] ILaunchUIContext context);
}
