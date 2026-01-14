namespace ShellBat.Terminals.Interop;

public partial struct HPCON(nint value) : IEquatable<HPCON>, IValueGet<nint>
{
    public static readonly HPCON Null = new();

    public nint Value = value;

    public override readonly string ToString() => $"0x{Value:x}";

    public override readonly bool Equals(object? obj) => obj is HPCON value && Equals(value);
    public readonly bool Equals(HPCON other) => other.Value == Value;
    public override readonly int GetHashCode() => Value.GetHashCode();
    public static bool operator ==(HPCON left, HPCON right) => left.Equals(right);
    public static bool operator !=(HPCON left, HPCON right) => !left.Equals(right);
    public static implicit operator nint(HPCON value) => value.Value;
    public static implicit operator HPCON(nint value) => new(value);

    readonly nint IValueGet<nint>.GetValue() => Value;
    readonly object? IValueGet.GetValue() => Value;
}
