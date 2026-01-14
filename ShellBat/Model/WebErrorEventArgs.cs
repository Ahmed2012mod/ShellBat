namespace ShellBat.Model;

public class WebErrorEventArgs(string? message, string? source, int line, int col, string? stackTrace) : EventArgs
{
    public string? Message { get; } = message;
    public string? Source { get; } = source;
    public int Line { get; } = line;
    public int Column { get; } = col;
    public string? StackTrace { get; } = stackTrace;

    public override string ToString() => $"{Message} (source: {Source}, line: {Line}, column: {Column}, stack: {StackTrace})";

    public JavascriptException BuildException() => new(Message, Source, Line, Column, StackTrace);
}
