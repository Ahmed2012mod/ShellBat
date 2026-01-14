namespace ShellBat.Utilities;

public sealed class ErrorTrace
{
    public required TraceLevel Level { get; set; }
    public required DateTimeOffset Timestamp { get; set; }
    public string? Category { get; set; }
    public string? Message { get; set; }
    public string? Id { get; set; }
    public IDictionary<string, object?> Values { get; set; } = new Dictionary<string, object?>(StringComparer.OrdinalIgnoreCase);
}
