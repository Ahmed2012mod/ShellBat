namespace ShellBat.Windows.Effects;

public abstract partial class EffectWithTwoSources : Effect
{
    protected EffectWithTwoSources() : base(2)
    {
    }

    public IGraphicsEffectSource? Source1 { get => GetSource(0); set => SetSource(0, value); }
    public IGraphicsEffectSource? Source2 { get => GetSource(1); set => SetSource(1, value); }
}
