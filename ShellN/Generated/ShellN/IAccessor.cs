#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("0c733a8c-2a1c-11ce-ade5-00aa0044773d")]
public partial interface IAccessor
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddRefAccessor(HACCESSOR hAccessor, nint /* optional uint* */ pcRefCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateAccessor(uint dwAccessorFlags, nuint cBindings, [In][MarshalUsing(CountElementName = nameof(cBindings))] DBBINDING[] rgBindings, nuint cbRowSize, out HACCESSOR phAccessor, nint /* optional uint* */ rgStatus);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBindings(HACCESSOR hAccessor, out uint pdwAccessorFlags, nint /* optional nuint* */ pcBindings, out nint prgBindings);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseAccessor(HACCESSOR hAccessor, nint /* optional uint* */ pcRefCount);
}
