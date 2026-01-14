namespace ShellBat.Windows.Effects;

[Guid(DirectN.Constants.CLSID_D2D1GaussianBlurString)]
public partial class GaussianBlurEffect : EffectWithSource
{
    [EffectProperty]
    public float StandardDeviation { get; set; } = 3;

    [EffectProperty(Index = 1)]
    public D2D1_GAUSSIANBLUR_OPTIMIZATION Optimization { get; set; } = D2D1_GAUSSIANBLUR_OPTIMIZATION.D2D1_GAUSSIANBLUR_OPTIMIZATION_BALANCED;

    [EffectProperty(Index = 2)]
    public D2D1_BORDER_MODE BorderMode { get; set; }
}
