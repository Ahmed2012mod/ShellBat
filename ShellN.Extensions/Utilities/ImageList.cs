namespace ShellN.Extensions.Utilities;

public static class ImageList
{
    public static IComObject<IImageList>? GetImageList(SHIL shil, bool throwOnError = true)
    {
        Functions.SHGetImageList((int)shil, typeof(IImageList).GUID, out var unk).ThrowOnError(throwOnError);
        return ComObject.FromPointer<IImageList>(unk);
    }

    public static HICON GetIconHandleFromSystemImageList(int index, SHIL shil, IMAGE_LIST_DRAW_STYLE flags = IMAGE_LIST_DRAW_STYLE.ILD_NORMAL, bool throwOnError = true)
    {
        using var list = GetImageList(shil, throwOnError);
        if (list == null)
            return 0;

        list.Object.GetIcon(index, (uint)flags, out var hicon);
        return hicon;
    }
}
