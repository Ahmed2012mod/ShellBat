namespace ShellN.Extensions.Utilities;

public sealed class UpdateProgressEventArgs(uint workTotal, uint workSoFar) : EventArgs
{
    public uint WorkTotal { get; } = workTotal;
    public uint WorkSoFar { get; } = workSoFar;
}
