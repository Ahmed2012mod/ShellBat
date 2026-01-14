namespace ShellBat.Model;

[System.Runtime.InteropServices.Marshalling.GeneratedComClass]
public partial class WebTheme(ShellBatTheme theme) : DispatchObject
{
    public string DisplayName => theme.DisplayName ?? theme.ThemeName;
    public string ThemeName => theme.ThemeName;
    public string? FilePath => theme.FilePath;
    public bool IsDefault => theme.FilePath.EqualsIgnoreCase(ShellBatTheme.DefaultThemeFilePath);
    public bool IsCurrent => theme.FilePath.EqualsIgnoreCase(ShellBatInstance.Current.Theme.FilePath);
}
