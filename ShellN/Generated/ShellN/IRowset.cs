#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("0c733a7c-2a1c-11ce-ade5-00aa0044773d")]
public partial interface IRowset
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddRefRows(nuint cRows, [In][Out][MarshalUsing(CountElementName = nameof(cRows))] nuint[] rghRows, [In][Out][MarshalUsing(CountElementName = nameof(cRows))] uint[] rgRefCounts, [In][Out][MarshalUsing(CountElementName = nameof(cRows))] uint[] rgRowStatus);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetData(nuint hRow, HACCESSOR hAccessor, nint pData);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNextRows(nuint hReserved, nint lRowsOffset, nint cRows, out nuint pcRowsObtained, out nint prghRows);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseRows(nuint cRows, [In][Out][MarshalUsing(CountElementName = nameof(cRows))] nuint[] rghRows, [In][MarshalUsing(CountElementName = nameof(cRows))] uint[] rgRowOptions, [In][Out][MarshalUsing(CountElementName = nameof(cRows))] uint[] rgRefCounts, [In][Out][MarshalUsing(CountElementName = nameof(cRows))] uint[] rgRowStatus);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RestartPosition(nuint hReserved);
}
