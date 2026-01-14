#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("31cca04c-04d3-4ea9-90de-97b15e87a532")]
public partial interface IHandlerInfo2 : IHandlerInfo
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetApplicationId(out PWSTR value);
}
