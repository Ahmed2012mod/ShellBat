namespace ShellBat.Windows;

public class MouseWheelEventArgs(POINT pt, MODIFIERKEYS_FLAGS vk, int delta, Orientation orientation)
    : MouseEventArgs(pt, vk)
{
    public int Delta { get; } = delta / DirectN.Constants.WHEEL_DELTA;
    public Orientation Orientation { get; } = orientation;

    public override string ToString() => base.ToString() + ",DE=" + Delta + ",O=" + Orientation;
}
