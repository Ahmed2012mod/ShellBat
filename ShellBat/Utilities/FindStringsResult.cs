namespace ShellBat.Utilities;

public sealed class FindStringsResult(string filePath, long position, string text)
{
    public string FilePath { get; } = filePath ?? throw new ArgumentNullException(nameof(filePath));
    public long Position { get; } = position;
    public string Text { get; internal set; } = text ?? throw new ArgumentNullException(nameof(text));

    public override string ToString() => $"{FilePath}:({Position}) '{Text}'";
}
