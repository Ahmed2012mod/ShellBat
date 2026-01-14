namespace ShellBat.Windows.Effects;

public abstract partial class EffectWithSource : Effect
{
    protected EffectWithSource() : base(1)
    {
    }

    public IGraphicsEffectSource? Source { get => GetSource(0); set => SetSource(0, value); }
}
