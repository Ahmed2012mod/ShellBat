namespace ShellBat.Windows.Effects;

[Guid(DirectN.Constants.CLSID_D2D1BorderString)]
public partial class BorderEffect : EffectWithSource
{
    [EffectProperty]
    public D2D1_BORDER_EDGE_MODE EdgeModeX { get; set; }

    [EffectProperty(Index = 1)]
    public D2D1_BORDER_EDGE_MODE EdgeModeY { get; set; }
}
