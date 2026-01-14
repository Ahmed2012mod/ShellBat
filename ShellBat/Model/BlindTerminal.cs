namespace ShellBat.Model;

public class BlindTerminal
{
    private readonly StringBuilder _sb = new();

    public int CursorPosition { get; private set; }
    public bool HasHistory { get; private set; }
    public string TextToCursor => _sb.ToString(0, CursorPosition);

    public virtual BlindTerminalResult Add(WebKeyEvent evt)
    {
        ArgumentNullException.ThrowIfNull(evt);
        var result = new BlindTerminalResult();

        var wk = new WebKey(evt.Code);
        switch (evt.Type)
        {
            case "keydown":
                switch (wk.VirtualKeyCode)
                {
                    case WebVirtualKeyCode.Backspace:
                        if (_sb.Length > 0 && CursorPosition > 0)
                        {
                            _sb.Remove(CursorPosition - 1, 1);
                            CursorPosition--;
                        }
                        break;

                    case WebVirtualKeyCode.Enter:
                        result.Command = BlindTerminalCommand.Parse(_sb.ToString());
                        _sb.Clear();
                        CursorPosition = 0;
                        result.EnterPressed = true;
                        HasHistory = true;
                        break;

                    case WebVirtualKeyCode.ArrowLeft:
                        if (CursorPosition > 0)
                        {
                            CursorPosition--;
                        }
                        break;

                    case WebVirtualKeyCode.ArrowRight:
                        if (CursorPosition < _sb.Length)
                        {
                            CursorPosition++;
                        }
                        break;

                    case WebVirtualKeyCode.Delete:
                        if (CursorPosition < _sb.Length)
                        {
                            _sb.Remove(CursorPosition, 1);
                        }
                        break;

                    case WebVirtualKeyCode.Escape:
                        _sb.Clear();
                        CursorPosition = 0;
                        break;

                    case WebVirtualKeyCode.ArrowUp:
                    case WebVirtualKeyCode.ArrowDown:
                        if (HasHistory)
                        {
                            _sb.Clear();
                            CursorPosition = 0;
                        }
                        break;

                    default:
                        if (IsPrintableChar(evt))
                        {
                            _sb.Insert(CursorPosition, evt.Key);
                            CursorPosition++;
                        }
                        break;
                }
                break;

            case "keypress":
            case "keyup":
                switch (wk.VirtualKeyCode)
                {
                    case WebVirtualKeyCode.Enter:
                        result.EnterPressed = true;
                        break;
                }
                break;
        }

        //Application.TraceVerbose("keyEvent: " + evt);
        //Application.TraceVerbose(this);
        return result;
    }

    public override string ToString() => _sb.ToString();

    private static bool IsPrintableChar(WebKeyEvent evt)
    {
        if (string.IsNullOrEmpty(evt.Key) || evt.Key.Length != 1)
            return false;

        var ch = evt.Key[0];
        if (char.IsControl(ch))
            return false;

        if (evt.Ctrl || evt.Alt || evt.Meta)
            return false;

        return true;
    }
}
