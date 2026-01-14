#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/propidlbase/nn-propidlbase-ienumstatpropstg
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00000139-0000-0000-c000-000000000046")]
public partial interface IEnumSTATPROPSTG
{
    // https://learn.microsoft.com/windows/win32/api/propidlbase/nf-propidlbase-ienumstatpropstg-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint celt, [In][Out][MarshalUsing(CountElementName = nameof(celt))] STATPROPSTG[] rgelt, nint /* optional uint* */ pceltFetched);
    
    // https://learn.microsoft.com/windows/win32/api/propidlbase/nf-propidlbase-ienumstatpropstg-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint celt);
    
    // https://learn.microsoft.com/windows/win32/api/propidlbase/nf-propidlbase-ienumstatpropstg-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/propidlbase/nf-propidlbase-ienumstatpropstg-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumSTATPROPSTG>))] out IEnumSTATPROPSTG ppenum);
}
