#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iexplorercommandstate
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("bddacb60-7657-47ae-8445-d23e1acf82ae")]
public partial interface IExplorerCommandState
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iexplorercommandstate-getstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetState([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IShellItemArray>))] IShellItemArray psiItemArray, BOOL fOkToBeSlow, out uint pCmdState);
}
