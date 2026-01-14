namespace ShellN.Extensions.Utilities;

public class FileSaveDialog(nint site = 0)
    : FileDialog(DirectN.Extensions.Com.ComObject.CoCreate<IFileSaveDialog>(Constants.FileSaveDialog)!, site)
{
    public static FILEOPENDIALOGOPTIONS DefaultOptions { get; } = FILEOPENDIALOGOPTIONS.FOS_NOREADONLYRETURN | FILEOPENDIALOGOPTIONS.FOS_OVERWRITEPROMPT | FILEOPENDIALOGOPTIONS.FOS_PATHMUSTEXIST;
}
