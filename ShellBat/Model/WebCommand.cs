namespace ShellBat.Model;

[System.Runtime.InteropServices.Marshalling.GeneratedComClass]
public partial class WebCommand(ShellBatCommand command) : DispatchObject
{
    public ShellBatCommand Command { get; } = command;

    public string CommandName => Command.Name;
    public string DisplayName => Command.DisplayName;
    public string? CategoryName => Command.CategoryName;
    public bool IsReadOnly => Command.IsReadOnly;
    public bool IsHidden => Command.IsHidden;

    internal static IEnumerable<WebCommand> GetCommands() => ShellBatCommand.All.Select(c => new WebCommand(c)).OrderBy(c => c.CommandName);
    internal static WebPropertyGrid BuildPropertyGrid()
    {
        var grid = new WebPropertyGrid();
        foreach (var command in GetCommands())
        {
            if (command.IsHidden)
                continue;

            var prop = new WebPropertyGridProperty
            {
                Key = command.CommandName,
                DisplayName = command.DisplayName,
                CategoryName = command.CategoryName,
                IsReadOnly = command.IsReadOnly,
                Editor = "KeyBinding",
            };

            var wk = new WebCommandKey()
            {
                Key = command.Command.Key.Key,
                DefaultCommandText = ShellBatCommand.GetDefaultCommandText(command.CommandName),
                CommandText = command.Command.Key.ToString(),
                Ctrl = command.Command.Key.RequiresCtrl,
                Shift = command.Command.Key.RequiresShift,
                Alt = command.Command.Key.RequiresAlt,
                CommandName = command.CommandName,
            };
            grid.Instance.SetValue(prop.Key, JsonSerializer.Serialize(wk, JsonSourceGenerationContext.Default.WebCommandKey));
            grid.Properties.Add(prop);
        }

        grid.Instance.ChangedPropertyNames.Clear();
        return grid;
    }
}
