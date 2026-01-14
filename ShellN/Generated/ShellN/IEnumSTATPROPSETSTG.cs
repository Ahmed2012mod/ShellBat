#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/propidlbase/nn-propidlbase-ienumstatpropsetstg
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("0000013b-0000-0000-c000-000000000046")]
public partial interface IEnumSTATPROPSETSTG
{
    // https://learn.microsoft.com/windows/win32/api/propidlbase/nf-propidlbase-ienumstatpropsetstg-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Next(uint celt, [In][Out][MarshalUsing(CountElementName = nameof(celt))] STATPROPSETSTG[] rgelt, nint /* optional uint* */ pceltFetched);
    
    // https://learn.microsoft.com/windows/win32/api/propidlbase/nf-propidlbase-ienumstatpropsetstg-skip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Skip(uint celt);
    
    // https://learn.microsoft.com/windows/win32/api/propidlbase/nf-propidlbase-ienumstatpropsetstg-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/propidlbase/nf-propidlbase-ienumstatpropsetstg-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumSTATPROPSETSTG>))] out IEnumSTATPROPSETSTG ppenum);
}
