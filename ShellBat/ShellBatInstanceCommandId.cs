namespace ShellBat;

public enum ShellBatInstanceCommandId
{
    Unknown,
    Ping,
    Quit,
    HttpServerUrl,
    ConnectedToHttpServerUrl,
    GetMainWindowRect,
    SetMainWindowRect,
    SwitchTo,
    GetCurrentParsingName,
    GetOptions,
    ShowProperties, // 1st time
    ContinueShowProperties,
    Update,
}
