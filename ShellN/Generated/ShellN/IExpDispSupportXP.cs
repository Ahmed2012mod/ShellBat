#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shdeprecated/nn-shdeprecated-iexpdispsupportxp
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("2f0dd58c-f789-4f14-99fb-9293b3c9c212")]
public partial interface IExpDispSupportXP
{
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-iexpdispsupportxp-findcie4connectionpoint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindCIE4ConnectionPoint(in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<CIE4ConnectionPoint>))] out CIE4ConnectionPoint ppccp);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-iexpdispsupportxp-ontranslateaccelerator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnTranslateAccelerator(in MSG pMsg, uint grfModifiers);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-iexpdispsupportxp-oninvoke
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnInvoke(int dispidMember, in Guid iid, uint lcid, ushort wFlags, in DISPPARAMS pdispparams, out VARIANT pVarResult, out EXCEPINFO pexcepinfo, out uint puArgErr);
}
