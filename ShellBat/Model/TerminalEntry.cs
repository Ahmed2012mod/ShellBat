namespace ShellBat.Model;

public class TerminalEntry
{
    public string Key { get; set; } = null!;
    public string? CommandLine { get; set; }
    public string? ChangeDirectoryCommand { get; set; }
    public string? DisplayName { get; set; }
    public string? Icon { get; set; }
    public string? WindowClassName { get; set; }
    public bool IsWsl { get; set; }
    public bool SupportsCmdNotFound { get; set; }
    public bool SupportsShellBatSync { get; set; }
    public bool SupportsTerminalSync { get; set; } = true; // supports 'cd "blah"'

    internal string FinalIcon => Icon.Nullify() ?? $"icon-{Key}";

    public override string ToString() => $"{Key}: {CommandLine}";
}
