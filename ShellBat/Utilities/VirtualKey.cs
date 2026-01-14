namespace ShellBat.Utilities;

public struct VirtualKey(VIRTUAL_KEY key) : IEquatable<VirtualKey>
{
    public VIRTUAL_KEY Key = key;

    public readonly byte ScanCode => (byte)DirectN.Functions.MapVirtualKeyW((uint)Key, MAP_VIRTUAL_KEY_TYPE.MAPVK_VK_TO_VSC_EX);
    public readonly bool IsScanCodeExtended => (DirectN.Functions.MapVirtualKeyW((uint)Key, MAP_VIRTUAL_KEY_TYPE.MAPVK_VK_TO_VSC_EX) & 0xe000) != 0;
    public readonly string SimplifiedName => Key.ToString().Replace("VK_", string.Empty).Replace('_', '.');
    public readonly string DisplayOrSimplifiedName => DisplayName ?? SimplifiedName;
    public readonly string? DisplayName
    {
        get
        {
            // https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-getkeynametextw
            var scanCode = DirectN.Functions.MapVirtualKeyW((uint)Key, MAP_VIRTUAL_KEY_TYPE.MAPVK_VK_TO_VSC_EX);
            var lParam = (scanCode & 0xFF) << 16;
            if ((scanCode & 0xe000) != 0)
            {
                lParam |= 0x1000000;
            }

            using var p = new AllocPwstr(256);
            if (DirectN.Functions.GetKeyNameTextW((int)lParam, p, (int)p.SizeInChars) == 0)
                return null;

            return p.ToString();
        }
    }

    public readonly unsafe string? GetName(HOT_KEY_MODIFIERS flags)
    {
        var scanCode = DirectN.Functions.MapVirtualKeyW((uint)Key, MAP_VIRTUAL_KEY_TYPE.MAPVK_VK_TO_VSC_EX);
        using var p = new AllocPwstr(256);
        var bytes = new byte[256];

        if (flags.HasFlag(HOT_KEY_MODIFIERS.MOD_SHIFT))
        {
            bytes[(int)VIRTUAL_KEY.VK_SHIFT] = 0x80;
            bytes[(int)VIRTUAL_KEY.VK_LSHIFT] = 0x80;
        }

        if (flags.HasFlag(HOT_KEY_MODIFIERS.MOD_CONTROL))
        {
            bytes[(int)VIRTUAL_KEY.VK_CONTROL] = 0x80;
            bytes[(int)VIRTUAL_KEY.VK_LCONTROL] = 0x80;
        }

        if (flags.HasFlag(HOT_KEY_MODIFIERS.MOD_ALT))
        {
            bytes[(int)VIRTUAL_KEY.VK_MENU] = 0x80;
            bytes[(int)VIRTUAL_KEY.VK_LMENU] = 0x80;
        }

        fixed (byte* pBytes = bytes)
        {
            if (DirectN.Functions.ToUnicode((uint)Key, scanCode, (nint)pBytes, p, (int)p.SizeInChars, 4) <= 0)
                return null;
        }
        return p.ToString();
    }

    public override readonly string ToString()
    {
        var dn = DisplayName;
        if (dn == null)
            return Key.ToString();

        return $"{Key} '{dn}'";
    }

    public override readonly bool Equals([NotNullWhen(true)] object? obj) => obj is VirtualKey other && other.Key == Key;
    public override readonly int GetHashCode() => Key.GetHashCode();
    public readonly bool Equals(VirtualKey other) => other.Key == Key;
    public static bool operator ==(VirtualKey left, VirtualKey right) => left.Equals(right);
    public static bool operator !=(VirtualKey left, VirtualKey right) => !(left == right);
    public static implicit operator VirtualKey(VIRTUAL_KEY result) => new(result);
    public static implicit operator VIRTUAL_KEY(VirtualKey b) => b.Key;

    public static IReadOnlyDictionary<string, IReadOnlyList<VIRTUAL_KEY>> AllByNames => _allByNames.Value;
    private static readonly Lazy<IReadOnlyDictionary<string, IReadOnlyList<VIRTUAL_KEY>>> _allByNames = new(() =>
    {
        var dict = new ConcurrentDictionary<string, IReadOnlyList<VIRTUAL_KEY>>(StringComparer.OrdinalIgnoreCase);
        foreach (var vk in Enum.GetValues<VIRTUAL_KEY>())
        {
            var vkey = new VirtualKey(vk);
            var displayName = vkey.DisplayOrSimplifiedName;
            if (!dict.TryGetValue(displayName, out var list))
            {
                var array = new VIRTUAL_KEY[1];
                dict[displayName] = array;
                array[0] = vk;
            }
            else
            {
                var array = (VIRTUAL_KEY[])list;
                if (array.Contains(vk))
                    continue;

                var newArray = new VIRTUAL_KEY[list.Count + 1];
                ((VIRTUAL_KEY[])list).CopyTo(newArray, 0);
                newArray[list.Count] = vk;
                dict[displayName] = newArray;
            }
        }
        return dict.AsReadOnly();
    });
}
