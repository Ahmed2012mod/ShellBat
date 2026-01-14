#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-copydatastruct
public partial struct COPYDATASTRUCT
{
    public nuint dwData;
    public uint cbData;
    public nint lpData;
}
