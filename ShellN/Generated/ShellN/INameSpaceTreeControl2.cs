#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl/nn-shobjidl-inamespacetreecontrol2
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("7cc7aed8-290e-49bc-8945-c1401cc9306c")]
public partial interface INameSpaceTreeControl2 : INameSpaceTreeControl
{
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-inamespacetreecontrol2-setcontrolstyle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetControlStyle(uint nstcsMask, uint nstcsStyle);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-inamespacetreecontrol2-getcontrolstyle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetControlStyle(uint nstcsMask, out uint pnstcsStyle);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-inamespacetreecontrol2-setcontrolstyle2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetControlStyle2(NSTCSTYLE2 nstcsMask, NSTCSTYLE2 nstcsStyle);
    
    // https://learn.microsoft.com/windows/win32/api/shobjidl/nf-shobjidl-inamespacetreecontrol2-getcontrolstyle2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetControlStyle2(NSTCSTYLE2 nstcsMask, out NSTCSTYLE2 pnstcsStyle);
}
