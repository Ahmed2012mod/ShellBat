namespace ShellBat.Utilities;

public class EntryWatcherEventArgs(EntryWatcherEventType type, Entry? entry, Entry? oldEntry = null) : EventArgs
{
    public EntryWatcherEventType Type { get; } = type;
    public Entry? Entry { get; } = entry;
    public Entry? OldEntry { get; } = oldEntry;

    public string ToLocalizedString() => Type switch
    {
        EntryWatcherEventType.Created => string.Format(Res.EventCreated, Entry?.DisplayName),
        EntryWatcherEventType.Deleted => string.Format(Res.EventDeleted, Entry?.DisplayName),
        EntryWatcherEventType.Renamed => string.Format(Res.EventRenamed, OldEntry?.DisplayName, Entry?.DisplayName),
        EntryWatcherEventType.Changed => string.Format(Res.EventChanged, Entry?.DisplayName),
        _ => string.Empty,
    };

    public override string ToString() => $"{Type} - {Entry?.ParsingName}" + (OldEntry is not null ? $" (Old: {OldEntry.ParsingName})" : null);
}
