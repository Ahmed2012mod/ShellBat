namespace ShellBat;

// update WebWindowShowOptions if you change this class
public class ShellBatChildWindow : IEquatable<ShellBatChildWindow>
{
    public string? Id { get; set; }
    public string? Parameters { get; set; }
    public float Left { get; set; }
    public float Top { get; set; }
    public float Right { get; set; }
    public float Bottom { get; set; }
    public BorderSnap BorderSnap { get; set; }

    // properties window
    public string? ViewerId { get; set; }
    public string? PinnedViewerId { get; set; }
    public IDictionary<string, object?>? ViewerOptions { get; set; }

    // terminal window
    public string? CommandLine { get; set; }

    public override string ToString() => $"{Id} ({Left},{Top})-({Right},{Bottom}) [{ViewerId}]";
    public override int GetHashCode() => string.IsNullOrWhiteSpace(Id) ? 0 : Id.GetHashCode(StringComparison.OrdinalIgnoreCase);
    public override bool Equals(object? obj) => Equals(obj as ShellBatChildWindow);
    public bool Equals(ShellBatChildWindow? other) => other is not null &&
        Id.EqualsIgnoreCase(other.Id) &&
        Parameters.EqualsIgnoreCase(other.Parameters) &&
        CommandLine.EqualsIgnoreCase(other.CommandLine) &&
        Left == other.Left &&
        Top == other.Top &&
        Right == other.Right &&
        Bottom == other.Bottom &&
        BorderSnap == other.BorderSnap &&
        PinnedViewerId.EqualsIgnoreCase(other.PinnedViewerId) &&
        ViewerId.EqualsIgnoreCase(other.ViewerId) &&
        ((ViewerOptions == null && other.ViewerOptions == null) || (ViewerOptions != null && other.ViewerOptions != null && ViewerOptions.Count == other.ViewerOptions.Count && !ViewerOptions.Except(other.ViewerOptions).Any()));
}
