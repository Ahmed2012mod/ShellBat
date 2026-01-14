#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-ihandleractivationhost
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("35094a87-8bb1-4237-96c6-c417eebdb078")]
public partial interface IHandlerActivationHost
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ihandleractivationhost-beforecocreateinstance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeforeCoCreateInstance(in Guid clsidHandler, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItemArray>))] IShellItemArray itemsBeingActivated, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IHandlerInfo>))] IHandlerInfo handlerInfo);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-ihandleractivationhost-beforecreateprocess
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeforeCreateProcess(PWSTR applicationPath, PWSTR commandLine, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IHandlerInfo>))] IHandlerInfo handlerInfo);
}
