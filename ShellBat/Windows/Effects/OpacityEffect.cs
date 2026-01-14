namespace ShellBat.Windows.Effects;

[Guid(DirectN.Constants.CLSID_D2D1OpacityString)]
public partial class OpacityEffect : EffectWithSource
{
    [EffectProperty]
    public float Opacity { get; set; } = 1;
}
