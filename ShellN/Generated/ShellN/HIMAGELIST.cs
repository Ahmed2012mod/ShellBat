#nullable enable
namespace ShellN;

public partial struct HIMAGELIST : IEquatable<HIMAGELIST>, IValueGet<nint>
{
    public static readonly HIMAGELIST Null = new();
    
    public nint Value;
    
    public HIMAGELIST(nint value) => this.Value = value;
    public override readonly string ToString() => $"0x{Value:x}";
    
    public override readonly bool Equals(object? obj) => obj is HIMAGELIST value && Equals(value);
    public readonly bool Equals(HIMAGELIST other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HIMAGELIST left, HIMAGELIST right) => left.Equals(right);
    public static bool operator !=(HIMAGELIST left, HIMAGELIST right) => !left.Equals(right);
    public static implicit operator nint(HIMAGELIST value) => value.Value;
    public static implicit operator HIMAGELIST(nint value) => new(value);
    
    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
