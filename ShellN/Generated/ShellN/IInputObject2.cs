#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iinputobject2
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("6915c085-510b-44cd-94af-28dfa56cf92b")]
public partial interface IInputObject2 : IInputObject
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iinputobject2-translateacceleratorglobal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TranslateAcceleratorGlobal(in MSG pMsg);
}
