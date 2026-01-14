using Win32InteropBuilder.Model;

namespace ShellN.InteropBuilder.Cli;

public static class TypeMappings
{
    public static FullName ITEMIDLIST { get; } = new("Windows.Win32.UI.Shell.Common.ITEMIDLIST");
}
