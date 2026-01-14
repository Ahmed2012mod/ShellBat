namespace ShellBat;

public interface IShellBatInstance
{
    string Name { get; }
    int ProcessId { get; }
    ShellBatInstanceOptions Options { get; }
    string? CurrentParsingName { get; }

    bool IsUnspecified => Name == Res.UnspecifiedInstanceName;
    bool IsThis => ProcessId == Environment.ProcessId;
    bool IsLocalHttpServer => Options.HasFlag(ShellBatInstanceOptions.IsLocalHttpServer);
    bool IsInHttpServerOnlyMode => Options.HasFlag(ShellBatInstanceOptions.IsInHttpServerOnlyMode);

    string DisplayName => IsUnspecified ? Res.AppName : Res.AppName + $" ({Name})";

    string OtherDisplayName
    {
        get
        {
            var parsingName = CurrentParsingName;
            if (parsingName == null)
#if DEBUG
                return $"{ProcessId} - {Name}";
#else
                return Name;
#endif

            var displayName = CurrentEntry?.FullDisplayName ?? parsingName;
            if (IsUnspecified)
#if DEBUG
                return $"{ProcessId} - {displayName}";
#else
                return displayName;
#endif

#if DEBUG
            return $"{ProcessId} - ({Name}) - {displayName}";
#else
            return $"({Name}) - {displayName}";
#endif
        }
    }

    Entry? CurrentEntry
    {
        get
        {
            var parsingName = CurrentParsingName;
            if (parsingName == null)
                return null;

            return Entry.Get(null, parsingName, ShellItemParsingOptions.DontThrowOnError);
        }
    }

    ShellItem? CurrentShellItem
    {
        get
        {
            var parsingName = CurrentParsingName;
            if (parsingName == null)
                return null;

            return ShellItem.FromParsingName(parsingName, throwOnError: false);
        }
    }

    HRESULT SetWindowRect(RECT rc, Guid? desktopId = null);
}
