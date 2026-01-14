namespace ShellBat.Model;

[System.Runtime.InteropServices.Marshalling.GeneratedComClass]
public abstract partial class PersistentEntry : DispatchObject, IEquatable<PersistentEntry>, IComparable<PersistentEntry>
{
    [AllowNull]
    public virtual string ParsingName { get; set; }

    [AllowNull]
    public virtual string DisplayName { get; set; }

    [AllowNull]
    public virtual string IconPath { get; set; }

    public virtual DateTime LastVisitedTime { get; set; } = DateTime.Now;

    [JsonIgnore]
    public string FormattedLastVisitedTime => LastVisitedTime.ToString();

    public override string ToString() => $"{ParsingName} ({LastVisitedTime:yyyy-MM-dd HH:mm:ss})";
    public override int GetHashCode() => ParsingName?.GetHashCode(StringComparison.OrdinalIgnoreCase) ?? 0;
    public override bool Equals(object? obj) => obj is PersistentEntry other && Equals(other);
    public bool Equals(PersistentEntry? other) => other is not null && ParsingName.Equals(other.ParsingName, StringComparison.OrdinalIgnoreCase);
    public virtual int CompareTo(PersistentEntry? other)
    {
        ArgumentNullException.ThrowIfNull(other);
        var cmp = LastVisitedTime.CompareTo(other.LastVisitedTime);
        if (cmp != 0)
            return cmp;

        return string.Compare(ParsingName, other.ParsingName, StringComparison.OrdinalIgnoreCase);
    }

    public virtual WebHistoryEntry ToWebHistoryEntry() => new()
    {
        ParsingName = ParsingName,
        DisplayName = DisplayName,
        IconPath = IconPath
    };
}
