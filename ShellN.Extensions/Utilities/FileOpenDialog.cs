namespace ShellN.Extensions.Utilities;

public class FileOpenDialog(nint site = 0)
    : FileDialog(DirectN.Extensions.Com.ComObject.CoCreate<IFileOpenDialog>(Constants.FileOpenDialog)!, site)
{
    public static FILEOPENDIALOGOPTIONS DefaultOptions { get; } = FILEOPENDIALOGOPTIONS.FOS_FILEMUSTEXIST | FILEOPENDIALOGOPTIONS.FOS_PATHMUSTEXIST;
}
