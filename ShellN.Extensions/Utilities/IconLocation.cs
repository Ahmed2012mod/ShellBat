namespace ShellN.Extensions.Utilities;

public sealed class IconLocation(string path, int index)
{
    public string Path { get; } = path;
    public int Index { get; } = index;
    public bool IsPathIndirect => Path.Length > 0 && Path[0] == '@';
    public string ResolvedPath => SystemUtilities.LoadIndirectString(Path);

    public override string ToString() => $"{Path}, {Index}";

    public int GetImageListIndex() => Functions.Shell_GetCachedImageIndexW(PWSTR.From(Path), Index, 0);
    public HICON GetIconHandle(SHIL shil, IMAGE_LIST_DRAW_STYLE flags = IMAGE_LIST_DRAW_STYLE.ILD_NORMAL, bool throwOnError = true) => ImageList.GetIconHandleFromSystemImageList(GetImageListIndex(), shil, flags, throwOnError);
}
