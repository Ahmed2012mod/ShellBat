namespace ShellBat.Model;

[System.Runtime.InteropServices.Marshalling.GeneratedComClass]
public partial class WebSearchWindow : WebWindow
{
    public WebSearchWindow(ShellBatWindow window, SearchType type, Entry entry)
        : base(window, type.ToString(), entry?.ParsingName)
    {
        ArgumentNullException.ThrowIfNull(entry);
        Entry = entry;
        if (type == SearchType.FindStrings)
        {
            Options.Icon = "fa-solid fa-filter";
        }
        else
        {
            Options.Icon = "fa-solid fa-magnifying-glass";
        }
        Options.Title = Res.ResourceManager.GetString(type.ToString()).Nullify() ?? type.ToString();
    }

    public Entry Entry { get; }
    public string ParsingName => Entry.ParsingName;
}


