#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shdeprecated/nn-shdeprecated-iexpdispsupport
[GeneratedComInterface, Guid("0d7d1d00-6fc0-11d0-a974-00c04fd705a2")]
public partial interface IExpDispSupport
{
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-iexpdispsupport-findconnectionpoint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindConnectionPoint(in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IConnectionPoint>))] out IConnectionPoint ppccp);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-iexpdispsupport-ontranslateaccelerator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnTranslateAccelerator(in MSG pMsg, uint grfModifiers);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-iexpdispsupport-oninvoke
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnInvoke(int dispidMember, in Guid iid, uint lcid, ushort wFlags, in DISPPARAMS pdispparams, out VARIANT pVarResult, out EXCEPINFO pexcepinfo, out uint puArgErr);
}
