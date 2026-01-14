namespace ShellBat.Model;

public class NavigateEventArgs(Entry? entry, bool fromHistory) : EventArgs
{
    public Entry? Entry { get; } = entry;
    public bool FromHistory { get; } = fromHistory;
}
