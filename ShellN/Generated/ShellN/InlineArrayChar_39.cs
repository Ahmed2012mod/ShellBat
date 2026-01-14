#nullable enable
namespace ShellN;

[InlineArray(InlineArrayChar_39.Length)]
public partial struct InlineArrayChar_39
{
    public const int Length = 39;
    
    public char Data;
    
    public override readonly string ToString() => ((ReadOnlySpan<char>)this).ToString().TrimEnd('\0');
    public void CopyFrom(string? str) => DirectNExtensions.CopyFrom<InlineArrayChar_39>(str, this, Length);
    public static implicit operator InlineArrayChar_39(string? str) { var n = new InlineArrayChar_39(); n.CopyFrom(str); return n; }
}
