namespace ShellBat.Model.Viewers;

[System.Runtime.InteropServices.Marshalling.GeneratedComClass]
public partial class CodeViewer(Entry entry) : Viewer(entry)
{
    private LinesStream? _stream;
    private int _currentLine = 0;

    public override int Priority => FileExtensionMatchPriority - 2; // favor svg as image over code viewer

    public virtual int ChunkSize { get; set; } = 1000;
    public virtual string? GetOptions()
    {
        var options = new EditorControlObjectOptions
        {
            Language = Language,
            Theme = Theme.GetThemeName(),
            Minimap = Minimap
        };
        return JsonSerializer.Serialize(options, JsonSourceGenerationContext.Default.EditorControlObjectOptions);
    }

    public override string? Icon => "fa-regular fa-file-code";
    public override bool IsSupported => MonacoExtensions.LanguagesLoaded && MonacoExtensions.GetLanguagesByExtension().ContainsKey(Entry.Extension.Name);

    public bool Minimap { get; set; } = true;
    public string? Language { get; set; } = MonacoExtensions.GetLanguageByExtension(entry.Extension.Name);
    public EditorTheme Theme { get; set; }

    public virtual string? LoadChunk()
    {
        if (_stream == null)
        {
            var stream = Entry.OpenRead();
            if (stream == null)
                return null;

            _stream ??= new LinesStream(stream);
            _stream.Load();
        }
        if (_stream == null)
            return null;

        var leftLines = _stream.Lines.Count - _currentLine;
        if (leftLines <= 0)
            return null;

        var text = string.Join(Environment.NewLine, _stream.GetTexts(_currentLine, leftLines));
        _currentLine += leftLines;
        //Application.TraceInfo($"Loaded {_currentLine}/{_stream.Lines.Count} lines for Entry '{Entry.ParsingName}': {text.Length}");
        return text;
    }

    public virtual void OnEditorReady()
    {
    }

    public override Task<WebPropertyGrid?> GetProperties()
    {
        var grid = new WebPropertyGrid();

        grid.Properties.Add(new WebPropertyGridProperty()
        {
            Key = nameof(Theme),
            DisplayName = Res.Theme,
            Editor = "Enum",
            EnumValues = Enum.GetValues<EditorTheme>().ToDictionary(t => Conversions.Decamelize(t.ToString(), DecamelizeOptions.ForceRestLower) ?? t.ToString(), t => (object?)t.GetThemeName()),
        });

        grid.Properties.Add(new WebPropertyGridProperty()
        {
            Key = nameof(Minimap),
            DisplayName = Res.Minimap,
            Editor = "Boolean",
        });

        grid.Properties.Add(new WebPropertyGridProperty()
        {
            Key = nameof(Language),
            DisplayName = Res.Language,
            Editor = "Enum",
            EnumValues = MonacoExtensions.GetLanguages()?.OrderBy(k => k.Key).Select(kv => kv.Key).ToDictionary(lang => lang, lang => (object?)lang) ?? [],
        });

        grid.Instance.PropertyChanged += (s, e) =>
        {
            switch (e.PropertyName)
            {
                case nameof(Theme):
                    Theme = grid.Instance.GetTypedValue<EditorTheme>(nameof(Theme));
                    break;

                case nameof(Minimap):
                    Minimap = grid.Instance.GetTypedValue<bool>(nameof(Minimap));
                    break;

                case nameof(Language):
                    Language = grid.Instance.GetNullifiedString(nameof(Language));
                    break;
            }
        };

        grid.Instance.SetValue(nameof(Theme), Theme);
        grid.Instance.SetValue(nameof(Minimap), Minimap);
        grid.Instance.SetValue(nameof(Language), Language);

        grid.Options.GroupByCategory = false;
        grid.Options.PropertyNamePostfix = ":";
        grid.Options.BaseClassName = "viewer-Code-pg";
        return Task.FromResult<WebPropertyGrid?>(grid);
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            Interlocked.Exchange(ref _stream, null)?.Dispose();
        }
        base.Dispose(disposing);
    }
}
