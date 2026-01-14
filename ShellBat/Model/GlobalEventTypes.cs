namespace ShellBat.Model;

public static class GlobalEventTypes
{
    public const string WindowClose = nameof(WindowClose);
    public const string WindowMove = nameof(WindowMove);
    public const string WindowResize = nameof(WindowResize);
    public const string NewWindowReady = nameof(NewWindowReady);
    public const string WindowUpdate = nameof(WindowUpdate);
    public const string ContextMenuShown = nameof(ContextMenuShown);
    public const string ContextMenuNavigation = nameof(ContextMenuNavigation);
    public const string ContextMenusDismissed = nameof(ContextMenusDismissed);
}
