namespace ShellBat.Windows.Effects;

[Guid(DirectN.Constants.CLSID_D2D1CompositeString)]
public partial class CompositeStepEffect : EffectWithTwoSources
{
    [EffectProperty]
    public D2D1_COMPOSITE_MODE Mode { get; set; }

    public IGraphicsEffectSource? Destination { get => GetSource(0); set => SetSource(0, value); }
    public IGraphicsEffectSource? Source { get => GetSource(1); set => SetSource(1, value); }
}