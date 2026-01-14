namespace ShellBat.Windows;

public class DispatchEventArgs(int dispId, DISPATCH_FLAGS flags, params object?[] arguments) : EventArgs
{
    public int DispId { get; } = dispId;
    public DISPATCH_FLAGS Flags { get; } = flags;
    public object?[] Arguments { get; } = arguments;
    public virtual object? Result { get; set; }
    public virtual HRESULT Return { get; set; }

    public override string ToString()
    {
        var str = DispId.ToString();
        if (Arguments != null && Arguments.Length != 0)
        {
            str += " " + string.Join(" | ", Arguments);
        }
        return str;
    }
}
