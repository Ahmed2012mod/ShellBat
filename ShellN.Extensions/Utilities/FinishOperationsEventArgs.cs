namespace ShellN.Extensions.Utilities;

public sealed class FinishOperationsEventArgs(HRESULT hr) : EventArgs
{
    public HRESULT HResult { get; } = hr;
}
