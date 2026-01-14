#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("00000000-0000-0000-0000-000000000000")]
public partial interface CIE4ConnectionPoint : IConnectionPoint
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DoInvokeIE4(ref BOOL pf, out nint ppv, int dispid, ref DISPPARAMS pdispparams);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DoInvokePIDLIE4(int dispid, ref nint pidl, BOOL fCanCancel);
}
