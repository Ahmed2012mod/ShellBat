namespace ShellBat;

public class ShellBatRemoteInstanceEventArgs(ShellBatInstanceRemoteEventType type, object?[]? arguments) : EventArgs
{
    public ShellBatInstanceRemoteEventType Type { get; } = type;
    public object?[]? Arguments { get; } = arguments;

    public override string ToString() => $"{Type}:{string.Join(", ", Arguments ?? [])}";
}
