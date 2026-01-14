namespace ShellBat.Windows.Effects;

[AttributeUsage(AttributeTargets.Property)]
public class EffectPropertyAttribute : Attribute
{
    public int Index { get; set; }
    public GRAPHICS_EFFECT_PROPERTY_MAPPING Mapping { get; set; } = GRAPHICS_EFFECT_PROPERTY_MAPPING.GRAPHICS_EFFECT_PROPERTY_MAPPING_DIRECT;
}
