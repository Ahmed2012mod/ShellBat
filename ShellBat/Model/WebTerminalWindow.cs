namespace ShellBat.Model;

[System.Runtime.InteropServices.Marshalling.GeneratedComClass]
public partial class WebTerminalWindow : WebWindow
{
    public const string WindowId = "Terminal";

    public WebTerminalWindow(ShellBatWindow window, string id, Entry? entry, TerminalEntry terminal)
        : base(window, id, terminal?.Key)
    {
        ArgumentNullException.ThrowIfNull(terminal);
        Entry = entry;
        Command = terminal;
        Options.Title = terminal.DisplayName.Nullify() ?? Res.ResourceManager.GetString(terminal.Key).Nullify() ?? terminal.Key;
        Options.Icon = terminal.Icon.Nullify() ?? $"icon-{terminal.Key}";
        Options.ClassName = terminal.WindowClassName.Nullify() ?? "fld-terminal-window";
    }

    public Entry? Entry { get; }
    public string TerminalKey => Command.Key;
    public string? ParsingName => Entry?.ParsingName;
    public TerminalEntry Command { get; }
}


