namespace ShellN.Extensions.Utilities;

public sealed class RecycledItem(DELETEDITEM item)
{
    public ulong Size => item.cbItemSize;
    public DateTime RecycledTime => item.ftRecycled.ToDateTime();
    public string? RestorePath => Marshal.PtrToStringUni(item.pszRestorePath.Value);
    public string? FileName => Marshal.PtrToStringUni(item.pszFilename.Value);

    public override string ToString() => RestorePath ?? string.Empty;
}
