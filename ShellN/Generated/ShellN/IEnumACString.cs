#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("8e74c210-cf9d-4eaf-a403-7356428f0a5a")]
public partial interface IEnumACString : IEnumString
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NextItem([MarshalUsing(CountElementName = nameof(cchMax))] PWSTR pszUrl, uint cchMax, out uint pulSortIndex);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEnumOptions(uint dwOptions);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEnumOptions(out uint pdwOptions);
}
