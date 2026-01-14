#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/structuredquerycondition/nn-structuredquerycondition-icondition
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("0fc988d4-c935-4b97-a973-46282ea175c8")]
public partial interface ICondition : IPersistStream
{
    // https://learn.microsoft.com/windows/win32/api/structuredquerycondition/nf-structuredquerycondition-icondition-getconditiontype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetConditionType(out CONDITION_TYPE pNodeType);
    
    // https://learn.microsoft.com/windows/win32/api/structuredquerycondition/nf-structuredquerycondition-icondition-getsubconditions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSubConditions(in Guid riid, out nint /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/structuredquerycondition/nf-structuredquerycondition-icondition-getcomparisoninfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetComparisonInfo(nint /* optional PWSTR* */ ppszPropertyName, nint /* optional CONDITION_OPERATION* */ pcop, nint /* optional PROPVARIANT* */ ppropvar);
    
    // https://learn.microsoft.com/windows/win32/api/structuredquerycondition/nf-structuredquerycondition-icondition-getvaluetype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValueType(out PWSTR ppszValueTypeName);
    
    // https://learn.microsoft.com/windows/win32/api/structuredquerycondition/nf-structuredquerycondition-icondition-getvaluenormalization
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValueNormalization(out PWSTR ppszNormalization);
    
    // https://learn.microsoft.com/windows/win32/api/structuredquerycondition/nf-structuredquerycondition-icondition-getinputterms
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInputTerms(nint /* optional IRichChunk* */ ppPropertyTerm, nint /* optional IRichChunk* */ ppOperationTerm, nint /* optional IRichChunk* */ ppValueTerm);
    
    // https://learn.microsoft.com/windows/win32/api/structuredquerycondition/nf-structuredquerycondition-icondition-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ICondition>))] out ICondition ppc);
}
