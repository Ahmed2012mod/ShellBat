#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("4a3df050-23bd-11d2-939f-00a0c91eedba")]
public partial interface DFConstraint : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Name(out BSTR pbs);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Value(out VARIANT pv);
}
