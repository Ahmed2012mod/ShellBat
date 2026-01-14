namespace ShellBat.Windows;

public class PointerLeaveEventArgs(uint pointerId, POINT pt, POINTER_MESSAGE_FLAGS flags)
    : PointerUpdateEventArgs(pointerId, pt, flags)
{
}
