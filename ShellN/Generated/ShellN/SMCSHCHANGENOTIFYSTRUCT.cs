#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shobjidl_core/ns-shobjidl_core-smcshchangenotifystruct
public partial struct SMCSHCHANGENOTIFYSTRUCT
{
    public int lEvent;
    public nint pidl1;
    public nint pidl2;
}
