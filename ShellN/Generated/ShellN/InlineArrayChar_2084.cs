#nullable enable
namespace ShellN;

[InlineArray(InlineArrayChar_2084.Length)]
public partial struct InlineArrayChar_2084
{
    public const int Length = 2084;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArrayChar_2084>(str, this, Length);
    public static implicit operator InlineArrayChar_2084(string? str) { var n = new InlineArrayChar_2084(); n.CopyFrom(str); return n; }
}
