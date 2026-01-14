namespace ShellBat.Model;

public class WebFindStringsResult
{
    public required string QueryId { get; init; }
    public required string ParsingName { get; init; }
    public required int Index { get; init; } // -1 => last, -2 => info in FilePath
    public string FilePath { get; set; } = null!;
    public required long Position { get; init; }
    public required string Text { get; init; }

    public static WebFindStringsResult From(string queryId, int index, FindStringsResult result)
    {
        ArgumentNullException.ThrowIfNull(queryId);
        ArgumentNullException.ThrowIfNull(result);
        return new WebFindStringsResult
        {
            QueryId = queryId,
            ParsingName = result.FilePath,
            Index = index,
            FilePath = result.FilePath,
            Position = Math.Max(1, result.Position), // min is 1 (for js)
            Text = result.Text
        };
    }
}
