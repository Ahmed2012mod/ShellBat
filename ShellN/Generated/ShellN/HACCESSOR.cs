#nullable enable
namespace ShellN;

public partial struct HACCESSOR : IEquatable<HACCESSOR>, IValueGet<nuint>
{
    public static readonly HACCESSOR Null = new();
    
    public nuint Value;
    
    public HACCESSOR(nuint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HACCESSOR value && Equals(value);
    public readonly bool Equals(HACCESSOR other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HACCESSOR left, HACCESSOR right) => left.Equals(right);
    public static bool operator !=(HACCESSOR left, HACCESSOR right) => !left.Equals(right);
    public static implicit operator nuint(HACCESSOR value) => value.Value;
    public static implicit operator HACCESSOR(nuint value) => new(value);
    
    readonly nuint IValueGet<nuint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
