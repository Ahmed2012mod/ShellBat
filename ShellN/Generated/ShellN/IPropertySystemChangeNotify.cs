#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("fa955fd9-38be-4879-a6ce-824cf52d609f")]
public partial interface IPropertySystemChangeNotify
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SchemaRefreshed();
}
