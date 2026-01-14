#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/nn-shobjidl_core-iobjectwithbackreferences
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("321a6a6a-d61f-4bf3-97ae-14be2986bb36")]
public partial interface IObjectWithBackReferences
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl_core/nf-shobjidl_core-iobjectwithbackreferences-removebackreferences
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveBackReferences();
}
