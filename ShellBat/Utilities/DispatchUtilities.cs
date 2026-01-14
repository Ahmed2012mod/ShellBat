namespace ShellBat.Utilities;

public static class DispatchUtilities
{
    public static RECT AsDOMRect(this DirectN.IDispatch? disp)
    {
        if (disp == null)
            return RECT.Zero;

        var x = disp.GetProperty("x", 0);
        var y = disp.GetProperty("y", 0);
        var width = disp.GetProperty("width", 0);
        var height = disp.GetProperty("height", 0);
        return RECT.Sized(x, y, width, height);
    }

    public static KeyEventArgs? AsKeyEventArgs(this DirectN.IDispatch? disp)
    {
        if (disp == null)
            return null;

        var type = disp.GetNullifiedProperty("type");
        if (type == null)
            return null;

        var code = disp.GetNullifiedProperty("code");
        var wk = new WebKey(code);

        uint states = 0;
        if (type == "keyup")
        {
            states |= 0x80000000; // bit 31
        }

        var key = disp.GetProperty<string>("key");
        return new KeyEventArgs(wk.VirtualKey, states, key)
        {
            WithShift = disp.GetProperty("shift", false),
            WithControl = disp.GetProperty("ctrl", false),
            WithMenu = disp.GetProperty("alt", false),
            WebCode = code,
        };
    }

    public static WebKeyEvent? AsWebKeyEvent(this DirectN.IDispatch? disp)
    {
        if (disp == null)
            return null;

        var type = disp.GetNullifiedProperty("type");
        if (type == null)
            return null;

        var code = disp.GetNullifiedProperty("code");
        if (code == null)
            return null;

        return new WebKeyEvent
        {
            Type = type,
            Code = code,
            Key = disp.GetNullifiedProperty("key"),
            Alt = disp.GetProperty("alt", false),
            Shift = disp.GetProperty("shift", false),
            Ctrl = disp.GetProperty("ctrl", false),
            Meta = disp.GetProperty("meta", false),
        };
    }
}
