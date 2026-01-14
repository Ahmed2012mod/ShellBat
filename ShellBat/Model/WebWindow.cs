namespace ShellBat.Model;

[System.Runtime.InteropServices.Marshalling.GeneratedComClass]
public partial class WebWindow(ShellBatWindow window, string id, string? parameters) : DispatchObject
{
#pragma warning disable CA1822 // Mark members as static

    public string Id { get; } = id ?? throw new ArgumentNullException(nameof(id));
    public string? Parameters { get; } = parameters;
    public WebWindowOptions Options { get; } = new(window);
    public IList<Viewer> Viewers { get; } = [];

    public override string ToString() => Id;

    public Viewer? GetViewer(string name)
    {
        ArgumentNullException.ThrowIfNull(name);
        return Viewers.FirstOrDefault(v => v.Id.EqualsIgnoreCase(name));
    }

    public virtual bool IsInstanceEqual(object? other) => false;
#pragma warning restore CA1822 // Mark members as static
}
