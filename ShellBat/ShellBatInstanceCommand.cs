namespace ShellBat;

public sealed class ShellBatInstanceCommand
{
    private const int _wellKnownArgs = 5;

    public required ShellBatInstanceCommandId Id { get; init; }
    public required int ProcessId { get; init; }
    public required string CurrentDirectory { get; init; }
    public required string UserDomainName { get; init; }
    public required string UserName { get; init; }
    public required Guid DesktopId { get; init; }
    public required object[] Arguments { get; init; }

    public static ShellBatInstanceCommand? Parse(CommandTargetEventArgs e)
    {
        if (e.Input is not object[] args || args.Length < _wellKnownArgs)
            return null;

        if (!int.TryParse(string.Format("{0}", args[0]), out var processId))
            return null;

        if (args[1] is not string currentDirectory)
            return null;

        if (args[2] is not string userDomainName)
            return null;

        if (args[3] is not string userName)
            return null;

        if (args[4] is not string did || !Guid.TryParse(did, out var desktopId))
            return null;

        args = [.. args.Skip(_wellKnownArgs)];
        return new ShellBatInstanceCommand
        {
            Id = (ShellBatInstanceCommandId)e.Id,
            ProcessId = processId,
            CurrentDirectory = currentDirectory,
            UserDomainName = userDomainName,
            UserName = userName,
            DesktopId = desktopId,
            Arguments = args
        };
    }

    internal static void AddWellKnownArguments(Guid? desktopId, IList<object?> list)
    {
        list.Add(SystemUtilities.CurrentProcess.Id);
        list.Add(Environment.CurrentDirectory);
        list.Add(Environment.UserDomainName);
        list.Add(Environment.UserName);
        list.Add((desktopId ?? Guid.Empty).ToString("N"));
        if (list.Count != _wellKnownArgs)
            throw new ShellBatException($"0003: Internal error.");
    }
}
