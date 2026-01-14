namespace ShellBat.Model;

public class WebEventArgs(WebEventType type, DirectN.IDispatch? value) : EventArgs
{
    public WebEventType Type { get; } = type;
    public DirectN.IDispatch? Value { get; } = value;
    public virtual object? Output { get; set; }
}
