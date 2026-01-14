#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-iaccessibilitydockingservicecallback
[GeneratedComInterface, Guid("157733fd-a592-42e5-b594-248468c5a81b")]
public partial interface IAccessibilityDockingServiceCallback
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-iaccessibilitydockingservicecallback-undocked
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Undocked(UNDOCK_REASON undockReason);
}
