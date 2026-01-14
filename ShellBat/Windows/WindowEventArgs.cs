namespace ShellBat.Windows;

public class WindowEventArgs(IComObject<IShellWindows> shellWindows, int cookie, bool registered) : EventArgs
{
    public IComObject<IShellWindows> ShellWindows { get; } = shellWindows ?? throw new ArgumentNullException(nameof(shellWindows));
    public int Cookie { get; } = cookie;
    public bool IsRegistered { get; } = registered;
    public bool IsRevoked => !IsRegistered;
}
