namespace ShellBat.Monaco;

[System.Runtime.InteropServices.Marshalling.GeneratedComClass]
public partial class EditorControlObject : DispatchObject
{
    public event EventHandler<EditorControlLoadingEventArgs>? Loading;
    public event EventHandler<EditorControlEventArgs>? Event;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CA1822 // Mark members as static

    private enum DispIds
    {
        value = 0, // this is the default value for a COM object, so we can use it to return the object itself
        getOptions = 100,
        load,
        onEvent,
    }

    [DispId((int)DispIds.getOptions)]
    public string GetOptions()
    {
        var options = new EditorControlObjectOptions();
        return JsonSerializer.Serialize(options, JsonSourceGenerationContext.Default.EditorControlObjectOptions);
    }

    [DispId((int)DispIds.load)]
    public string? Load()
    {
        var e = new EditorControlLoadingEventArgs();
        Loading?.Invoke(this, e);
        return e.DocumentText;
    }

    [DispId((int)DispIds.onEvent)]
    public void OnEvent(EditorControlEventType type, string? json = null)
    {
        var handler = Event;
        if (handler == null)
            return;

        EditorControlEventArgs e = type switch
        {
            EditorControlEventType.KeyDown or EditorControlEventType.KeyUp => new EditorControlKeyEventArgs(type, json),
            EditorControlEventType.ConfigurationChanged => new EditorControlConfigurationChangedEventArgs(json),
            _ => new EditorControlEventArgs(type, json),
        };
        handler?.Invoke(this, e);
    }
}