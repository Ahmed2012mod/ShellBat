namespace ShellBat.Windows.Effects;

[Guid(DirectN.Constants.CLSID_D2D1FloodString)]
public partial class FloodEffect : Effect
{
    [EffectProperty(Mapping = GRAPHICS_EFFECT_PROPERTY_MAPPING.GRAPHICS_EFFECT_PROPERTY_MAPPING_COLOR_TO_VECTOR4)]
    public D2D_VECTOR_4F Color { get; set; } = new(0, 0, 0, 1);
}
