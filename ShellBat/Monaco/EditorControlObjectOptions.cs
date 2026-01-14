namespace ShellBat.Monaco;

public class EditorControlObjectOptions
{
    public bool AutomaticLayout { get; set; } = false; // causes lots of ResizeObserver issues, see https://github.com/microsoft/monaco-editor/issues/4311
    public string? Language { get; set; } // = "plaintext";
    public string? FontSize { get; set; } = "13px";
    public bool DragAndDrop { get; set; } = false;
    public bool MouseWheelZoom { get; set; } = true;
    public bool Contextmenu { get; set; } = false;
    public bool Minimap { get; set; } = true;
    public string? Theme { get; set; } = "vs";
}
