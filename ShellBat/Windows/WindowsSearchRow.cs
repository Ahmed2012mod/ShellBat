namespace ShellBat.Windows;

public sealed partial class WindowsSearchRow(int index, PropertyStore store) : InterlockedDisposable<PropertyStore>(store)
{
    public int Index { get; } = index;
    public PropertyStore Store { get; } = store ?? throw new ArgumentNullException(nameof(store));

    public override string ToString() => $"{Index}";
}
