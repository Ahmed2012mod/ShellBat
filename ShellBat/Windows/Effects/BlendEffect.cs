namespace ShellBat.Windows.Effects;

[Guid(DirectN.Constants.CLSID_D2D1BlendString)]
public partial class BlendEffect : Effect
{
    public BlendEffect()
        : base(2)
    {
    }

    [EffectProperty]
    public D2D1_BLEND_MODE Mode { get; set; }

    public IGraphicsEffectSource? Background { get => GetSource(0); set => SetSource(0, value); }
    public IGraphicsEffectSource? Foreground { get => GetSource(1); set => SetSource(1, value); }
}
