namespace ShellBat.Model;

public class WebWindowsSearchResult
{
    public required string QueryId { get; init; }
    public required string ParsingName { get; init; }
    public required int Index { get; init; } // -1 => last
    public string? FilePath { get; internal set; }
    public IDictionary<string, object?> Properties { get; } = new Dictionary<string, object?>();
}
