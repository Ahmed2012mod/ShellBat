namespace ShellBat.Model;

[System.Runtime.InteropServices.Marshalling.GeneratedComClass]
public partial class WebContextMenu(ShellBatWindow window, IReadOnlyList<Entry> entries) : DispatchObject, IActionExecutor
{
    public IReadOnlyList<Entry> Entries { get; } = entries;

    public bool PreventDefault { get; set; }
    public IList<WebMenuItem> MenuItems { get; internal set; } = [];

    public virtual void ExecuteAction(string id) => window.ExecuteAction(Entries, id);

    public static void RemoveSpuriousSeparators(IList<WebMenuItem> items)
    {
        ArgumentNullException.ThrowIfNull(items);
        for (var i = items.Count - 1; i >= 0; i--)
        {
            var item = items[i];
            if (item.IsSeparator)
            {
                if (i == 0 || i == items.Count - 1)
                {
                    items.RemoveAt(i);
                }
                else if (i > 0 && items[i - 1].IsSeparator)
                {
                    items.RemoveAt(i);
                }
            }
            else if (item.Items.Count > 0)
            {
                RemoveSpuriousSeparators(item.Items);
            }
        }
    }
}
