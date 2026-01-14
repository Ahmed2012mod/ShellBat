#nullable enable
namespace ShellN;

[Flags]
public enum IMAGE_LIST_DRAW_STYLE : uint
{
    ILD_NORMAL = 0,
    ILD_TRANSPARENT = 1,
    ILD_BLEND25 = 2,
    ILD_FOCUS = 2,
    ILD_BLEND50 = 4,
    ILD_SELECTED = 4,
    ILD_BLEND = 4,
    ILD_MASK = 16,
    ILD_IMAGE = 32,
    ILD_ROP = 64,
    ILD_OVERLAYMASK = 3840,
    ILD_PRESERVEALPHA = 4096,
    ILD_SCALE = 8192,
    ILD_DPISCALE = 16384,
    ILD_ASYNC = 32768,
}
