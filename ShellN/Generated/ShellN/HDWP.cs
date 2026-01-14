#nullable enable
namespace ShellN;

public partial struct HDWP : IEquatable<HDWP>, IValueGet<nint>
{
    public static readonly HDWP Null = new();
    
    public nint Value;
    
    public HDWP(nint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HDWP value && Equals(value);
    public readonly bool Equals(HDWP other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HDWP left, HDWP right) => left.Equals(right);
    public static bool operator !=(HDWP left, HDWP right) => !left.Equals(right);
    public static implicit operator nint(HDWP value) => value.Value;
    public static implicit operator HDWP(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
