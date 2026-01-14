namespace ShellBat.Windows.Effects;

[Guid(DirectN.Constants.CLSID_D2D1SaturationString)]
public partial class SaturationEffect : EffectWithSource
{
    [EffectProperty]
    public float Saturation { get; set; } = 0.5f;
}
