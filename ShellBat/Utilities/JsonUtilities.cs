namespace ShellBat.Utilities;

public static class JsonUtilities
{
    public static string? GetNullifiedValue(this JsonElement element, string jsonPath) => GetValue<string>(element, jsonPath, null).Nullify();
    public static string? GetNullifiedValue(this IDictionary<string, JsonElement>? dictionary, string key, string? defaultValue = null, IFormatProvider? provider = null)
    {
        ArgumentNullException.ThrowIfNull(key);
        if (dictionary == null)
            return defaultValue.Nullify();

        if (!dictionary.TryGetValue(key, out var elementValue))
            return defaultValue;

        return Conversions.ChangeType(elementValue, defaultValue, provider).Nullify();
    }

    public static D2D_RECT_F GetDOMRect(this JsonElement element, string? prefix = null)
    {
        var x = element.GetValue<float>(prefix + "x");
        var y = element.GetValue<float>(prefix + "y");
        var width = element.GetValue<float>(prefix + "width");
        var height = element.GetValue<float>(prefix + "height");
        return D2D_RECT_F.Sized(x, y, width, height);
    }

    public static T? GetValue<T>(this IDictionary<string, JsonElement>? dictionary, string key, T? defaultValue = default, IFormatProvider? provider = null)
    {
        ArgumentNullException.ThrowIfNull(key);
        if (dictionary == null)
            return defaultValue;

        if (!dictionary.TryGetValue(key, out var elementValue))
            return defaultValue;

        return Conversions.ChangeType(elementValue, defaultValue, provider);
    }

    public static T? GetValue<T>(this JsonElement element, string jsonPath, T? defaultValue = default)
    {
        if (!TryGetValue(element, jsonPath, out T? value))
            return defaultValue;

        return value;
    }

    public static bool TryGetValue<T>(this JsonElement element, string jsonPath, out T? value)
    {
        if (!TryGetValue(element, jsonPath, out object? obj))
        {
            value = default;
            return false;
        }

        return Conversions.TryChangeType(obj, out value);
    }

    public static bool TryGetValue(this JsonElement element, string jsonPath, out object? value)
    {
        ArgumentNullException.ThrowIfNull(jsonPath);
        if (element.TryGetProperty(jsonPath, out var directElement))
            return TryConvertToObject(directElement, out value);

        value = null;
        var segments = jsonPath.Split('.');
        var current = element;
        for (var i = 0; i < segments.Length; i++)
        {
            var segment = segments[i].Nullify();
            if (segment == null)
                return false;

            if (!current.TryGetProperty(segment, out var newElement))
                return false;

            if (i == segments.Length - 1)
                return TryConvertToObject(directElement, out value);

            current = newElement;
        }
        return false;
    }

    public static T? ConvertToObject<T>(this JsonElement element, T? defaultValue = default)
    {
        if (!TryConvertToObject<T>(element, out var value))
            return defaultValue;

        return value;
    }

    public static object? ConvertToObject(this JsonElement element, object? defaultValue)
    {
        if (!TryConvertToObject(element, out var value))
            return defaultValue;

        return value;
    }

    public static bool TryConvertToObject<T>(this JsonElement element, out T? value)
    {
        if (!TryConvertToObject(element, out var cvalue))
        {
            value = default;
            return false;
        }

        return Conversions.TryChangeType(cvalue, out value);
    }

    public static bool TryConvertToObject(this JsonElement element, out object? value)
    {
        switch (element.ValueKind)
        {
            case JsonValueKind.Null:
                value = null;
                return true;

            case JsonValueKind.Object:
                var dic = new Dictionary<string, object?>(StringComparer.OrdinalIgnoreCase);
                foreach (var child in element.EnumerateObject())
                {
                    if (!TryConvertToObject(child.Value, out var childValue))
                    {
                        value = null;
                        return false;
                    }

                    dic[child.Name] = childValue;
                }

                // empty dic => null
                if (dic.Count == 0)
                {
                    value = null;
                    return true;
                }

                value = dic;
                return true;

            case JsonValueKind.Array:
                var objects = new object?[element.GetArrayLength()];
                var i = 0;
                foreach (var child in element.EnumerateArray())
                {
                    if (!TryConvertToObject(child, out var childValue))
                    {
                        value = null;
                        return false;
                    }

                    objects[i++] = childValue;
                }

                value = objects;
                return true;

            case JsonValueKind.String:
                var str = element.ToString();
                if (DateTime.TryParseExact(str, ["o", "r", "s"], null, DateTimeStyles.None, out var dt))
                {
                    value = dt;
                    return true;
                }

                value = str;
                return true;

            case JsonValueKind.Number:
                if (element.TryGetInt32(out var i32))
                {
                    value = i32;
                    return true;
                }

                if (element.TryGetInt32(out var i64))
                {
                    value = i64;
                    return true;
                }

                if (element.TryGetDecimal(out var dec))
                {
                    value = dec;
                    return true;
                }

                if (element.TryGetDouble(out var dbl))
                {
                    value = dbl;
                    return true;
                }
                break;

            case JsonValueKind.True:
                value = true;
                return true;

            case JsonValueKind.False:
                value = false;
                return true;
        }

        value = null;
        return false;
    }
}
