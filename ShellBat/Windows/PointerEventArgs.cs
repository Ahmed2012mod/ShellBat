namespace ShellBat.Windows;

public abstract class PointerEventArgs(uint pointerId)
    : HandledEventArgs
{
    public uint PointerId { get; } = pointerId;

    public POINTER_INPUT_TYPE PointerType { get { DirectN.Functions.GetPointerType(PointerId, out var type); return type; } }
    public POINTER_INFO PointerInfo { get { DirectN.Functions.GetPointerInfo(PointerId, out var info); return info; } }
    public POINTER_PEN_INFO PointerPenInfo { get { DirectN.Functions.GetPointerPenInfo(PointerId, out var info); return info; } }
    public POINTER_TOUCH_INFO PointerTouchInfo { get { DirectN.Functions.GetPointerTouchInfo(PointerId, out var info); return info; } }

    public int Pressure => PointerType switch
    {
        POINTER_INPUT_TYPE.PT_PEN => (int)PointerPenInfo.pressure,
        POINTER_INPUT_TYPE.PT_TOUCH => (int)PointerTouchInfo.pressure,
        _ => 0,
    };

    public MouseButton? MouseButton
    {
        get
        {
            var info = PointerInfo;
            if (info.pointerFlags.HasFlag(POINTER_FLAGS.POINTER_FLAG_FIRSTBUTTON) ||
                info.ButtonChangeType == POINTER_BUTTON_CHANGE_TYPE.POINTER_CHANGE_FIRSTBUTTON_UP ||
                info.ButtonChangeType == POINTER_BUTTON_CHANGE_TYPE.POINTER_CHANGE_FIRSTBUTTON_DOWN)
                return Windows.MouseButton.Left;

            if (info.pointerFlags.HasFlag(POINTER_FLAGS.POINTER_FLAG_SECONDBUTTON) ||
                info.ButtonChangeType == POINTER_BUTTON_CHANGE_TYPE.POINTER_CHANGE_SECONDBUTTON_UP ||
                info.ButtonChangeType == POINTER_BUTTON_CHANGE_TYPE.POINTER_CHANGE_SECONDBUTTON_DOWN)
                return Windows.MouseButton.Right;

            if (info.pointerFlags.HasFlag(POINTER_FLAGS.POINTER_FLAG_THIRDBUTTON) ||
                info.ButtonChangeType == POINTER_BUTTON_CHANGE_TYPE.POINTER_CHANGE_THIRDBUTTON_UP ||
                info.ButtonChangeType == POINTER_BUTTON_CHANGE_TYPE.POINTER_CHANGE_THIRDBUTTON_DOWN)
                return Windows.MouseButton.Middle;

            if (info.pointerFlags.HasFlag(POINTER_FLAGS.POINTER_FLAG_FOURTHBUTTON) ||
                info.ButtonChangeType == POINTER_BUTTON_CHANGE_TYPE.POINTER_CHANGE_FOURTHBUTTON_UP ||
                info.ButtonChangeType == POINTER_BUTTON_CHANGE_TYPE.POINTER_CHANGE_FOURTHBUTTON_DOWN)
                return Windows.MouseButton.X1;

            if (info.pointerFlags.HasFlag(POINTER_FLAGS.POINTER_FLAG_FIFTHBUTTON) ||
                info.ButtonChangeType == POINTER_BUTTON_CHANGE_TYPE.POINTER_CHANGE_FIFTHBUTTON_UP ||
                info.ButtonChangeType == POINTER_BUTTON_CHANGE_TYPE.POINTER_CHANGE_FIFTHBUTTON_DOWN)
                return Windows.MouseButton.X2;

            return null;
        }
    }

    public override string ToString() => "Id=" + PointerId;
}
