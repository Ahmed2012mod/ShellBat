#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/shell/ishelldispatch3
[GeneratedComInterface, Guid("177160ca-bb5a-411c-841d-bd38facdeaa0")]
public partial interface IShellDispatch3 : IShellDispatch2
{
    // https://learn.microsoft.com/windows/win32/shell/ishelldispatch3-addtorecent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddToRecent(VARIANT varFile, BSTR bstrCategory);
}
