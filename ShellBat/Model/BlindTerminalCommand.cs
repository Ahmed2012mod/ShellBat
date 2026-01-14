namespace ShellBat.Model;

public class BlindTerminalCommand
{
    private BlindTerminalCommand() { }

    public BlindTerminalCommandType Type { get; private set; }

    public override string ToString() => $"{Type}";

    public virtual bool Run(WebTerminal terminal)
    {
        ArgumentNullException.ThrowIfNull(terminal);
        switch (Type)
        {
            case BlindTerminalCommandType.Sync:
                if (!terminal.ProcessName.EqualsIgnoreCase("cmd"))
                    return false;

                if (terminal.CurrentWorkingDirectory != null && terminal.Window != null)
                {
                    terminal.Window.RunTaskOnUIThread(() => terminal.Window.Navigate(terminal.CurrentWorkingDirectory, false));
                }
                return true;

            case BlindTerminalCommandType.Quit:
                terminal.Window?.Close();
                return true;
        }

        return false;
    }

    // command format is
    // !<command> <arg1> <arg2> ...
    public static BlindTerminalCommand? Parse(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return null;

        if (text[0] != '!')
            return null;

        var spacePos = text.IndexOf(' ', 1);
        var commandText = spacePos == -1 ? text[1..] : text[1..spacePos];
        var type = GetType(commandText);
        if (type == null)
            return null;

        var argsText = spacePos == -1 ? string.Empty : text[(spacePos + 1)..];
        var args = argsText.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        var command = new BlindTerminalCommand();
        command.Type = type.Value;
        return command;
    }

    private static BlindTerminalCommandType? GetType(string commandText)
    {
        if (int.TryParse(commandText, out var commandNumber))
        {
            if (Enum.IsDefined(typeof(BlindTerminalCommandType), commandNumber))
                return (BlindTerminalCommandType)commandNumber;

            return null;
        }

        commandText = commandText.ToLowerInvariant();
        return commandText.ToLowerInvariant() switch
        {
            "sf" or "sync" => (BlindTerminalCommandType?)BlindTerminalCommandType.Sync,
            "q" or "quit" => (BlindTerminalCommandType?)BlindTerminalCommandType.Quit,
            _ => null,
        };
    }
}
