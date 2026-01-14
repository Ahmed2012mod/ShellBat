namespace ShellN.Extensions;

public sealed class ItemId : IDisposable, IEquatable<ItemId>, IItemWithId
{
    public static bool IsEmpty(nint pidl) => GetSize(pidl) == 0;
    public static ushort GetSize(nint pidl)
    {
        if (pidl == 0)
            return 0;

        return (ushort)Marshal.ReadInt16(pidl);
    }

    private readonly IntPtrBuffer _buffer;
    private readonly Lazy<int> _hashcode;

    public ItemId(nint pointer, uint size, bool owned)
    {
        if (pointer == 0)
            throw new ArgumentException(null, nameof(pointer));

        _buffer = new IntPtrBuffer(pointer, size, owned);
        _hashcode = new Lazy<int>(ComputeHashCode);
    }

    ItemId IItemWithId.Id => this;
    public IntPtrBuffer Buffer => _buffer;
    public nint Pointer => _buffer.DangerousGetHandle();
    public uint Size => (uint)_buffer.ByteLength;
    public bool IsTerminator => Pointer != 0 && GetSize(Pointer) == 0;

#if DEBUG
    public string? HexaDump => IsTerminator ? null : Conversions.ToHexaDump(Pointer, (int)Size);
#endif

#if DEBUG
    public override string ToString()
    {
        if (Pointer == 0)
            return "<null>";

        if (IsTerminator)
            return "<term>";

        return "<pidl0x" + Pointer.ToHex() + ">";
    }
#else
    public override string ToString() => Pointer == IntPtr.Zero ? "<null>" : IsTerminator ? "<term>" : Pointer.ToHex();
#endif

    public byte[] ToByteArray() => _buffer.ToByteArray();
    public bool Equals(ItemId? other) => other is not null && _buffer.MemoryEqualsTo(other._buffer);
    public void Dispose() => _buffer.Dispose();
    public override int GetHashCode() => _hashcode.Value;
    public override bool Equals(object? obj) => Equals(obj as ItemId);
    public static bool operator ==(ItemId item1, ItemId item2) { if (item1 is null) return item2 is null; return item1.Equals(item2); }
    public static bool operator !=(ItemId item1, ItemId item2) { if (item1 is null) return item2 is not null; return !item1.Equals(item2); }

    private unsafe int ComputeHashCode()
    {
        var pointer = _buffer.DangerousGetHandle();
        if (pointer == 0 || _buffer.ByteLength == 0)
            return 0;

        return (int)Crc32.HashToUInt32(_buffer.GetSpan(17));
    }
}
