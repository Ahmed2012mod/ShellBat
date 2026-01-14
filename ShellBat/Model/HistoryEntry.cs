namespace ShellBat.Model;

[System.Runtime.InteropServices.Marshalling.GeneratedComClass]
public partial class HistoryEntry : PersistentEntry
{
    public override int CompareTo(PersistentEntry? other)
    {
        ArgumentNullException.ThrowIfNull(other);
        var cmp = LastVisitedTime.CompareTo(other.LastVisitedTime);
        if (cmp != 0)
            return -cmp;

        return string.Compare(ParsingName, other.ParsingName, StringComparison.OrdinalIgnoreCase);
    }
}
