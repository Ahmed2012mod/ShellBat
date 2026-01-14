namespace ShellBat.Model;

[Serializable]
public class JavascriptException(string? message, string? sourceFile, int line, int column, string? stackTrace) : Exception(message)
{
    public string? SourceFile { get; } = sourceFile;
    public int Line { get; } = line;
    public int Column { get; } = column;
    public string? StackTraceString { get; } = stackTrace;

    public override string ToString() => $"{typeof(JavascriptException)}: {Message} (source: {SourceFile}, line: {Line}, col: {Column}, stack: {StackTraceString})";
}
