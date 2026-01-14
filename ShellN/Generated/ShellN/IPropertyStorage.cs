#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/propidlbase/nn-propidlbase-ipropertystorage
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00000138-0000-0000-c000-000000000046")]
public partial interface IPropertyStorage
{
    // https://learn.microsoft.com/windows/win32/api/propidlbase/nf-propidlbase-ipropertystorage-readmultiple
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReadMultiple(uint cpspec, [In][MarshalUsing(CountElementName = nameof(cpspec))] PROPSPEC[] rgpspec, [In][Out][MarshalUsing(CountElementName = nameof(cpspec))] PROPVARIANT[] rgpropvar);
    
    // https://learn.microsoft.com/windows/win32/api/propidlbase/nf-propidlbase-ipropertystorage-writemultiple
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WriteMultiple(uint cpspec, [In][MarshalUsing(CountElementName = nameof(cpspec))] PROPSPEC[] rgpspec, [In][MarshalUsing(CountElementName = nameof(cpspec))] PROPVARIANT[] rgpropvar, uint propidNameFirst);
    
    // https://learn.microsoft.com/windows/win32/api/propidlbase/nf-propidlbase-ipropertystorage-deletemultiple
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteMultiple(uint cpspec, [In][MarshalUsing(CountElementName = nameof(cpspec))] PROPSPEC[] rgpspec);
    
    // https://learn.microsoft.com/windows/win32/api/propidlbase/nf-propidlbase-ipropertystorage-readpropertynames
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReadPropertyNames(uint cpropid, [In][MarshalUsing(CountElementName = nameof(cpropid))] uint[] rgpropid, [In][Out][MarshalUsing(CountElementName = nameof(cpropid))] PWSTR[] rglpwstrName);
    
    // https://learn.microsoft.com/windows/win32/api/propidlbase/nf-propidlbase-ipropertystorage-writepropertynames
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WritePropertyNames(uint cpropid, [In][MarshalUsing(CountElementName = nameof(cpropid))] uint[] rgpropid, [In][MarshalUsing(CountElementName = nameof(cpropid))] PWSTR[] rglpwstrName);
    
    // https://learn.microsoft.com/windows/win32/api/propidlbase/nf-propidlbase-ipropertystorage-deletepropertynames
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeletePropertyNames(uint cpropid, [In][MarshalUsing(CountElementName = nameof(cpropid))] uint[] rgpropid);
    
    // https://learn.microsoft.com/windows/win32/api/propidlbase/nf-propidlbase-ipropertystorage-commit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Commit(uint grfCommitFlags);
    
    // https://learn.microsoft.com/windows/win32/api/propidlbase/nf-propidlbase-ipropertystorage-revert
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Revert();
    
    // https://learn.microsoft.com/windows/win32/api/propidlbase/nf-propidlbase-ipropertystorage-enum
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Enum([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumSTATPROPSTG>))] out IEnumSTATPROPSTG ppenum);
    
    // https://learn.microsoft.com/windows/win32/api/propidlbase/nf-propidlbase-ipropertystorage-settimes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTimes(in FILETIME pctime, in FILETIME patime, in FILETIME pmtime);
    
    // https://learn.microsoft.com/windows/win32/api/propidlbase/nf-propidlbase-ipropertystorage-setclass
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetClass(in Guid clsid);
    
    // https://learn.microsoft.com/windows/win32/api/propidlbase/nf-propidlbase-ipropertystorage-stat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stat(out STATPROPSETSTG pstatpsstg);
}
