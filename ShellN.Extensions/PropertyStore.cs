namespace ShellN.Extensions;

public class PropertyStore : InterlockedComObject<IPropertyStore>, IDictionary<PROPERTYKEY, object?>
{
    public static PropertyStore Create()
    {
        Functions.PSCreateMemoryPropertyStore(typeof(IPropertyStore).GUID, out var unk).ThrowOnError();
        return new PropertyStore(DirectN.Extensions.Com.ComObject.FromPointer<IPropertyStore>(unk)!);
    }

    public PropertyStore(IComObject<IPropertyStore> comObject)
        : base(comObject)
    {
        ArgumentNullException.ThrowIfNull(comObject);
    }

    public ICollection<PROPERTYKEY> Keys
    {
        get
        {
            var list = new List<PROPERTYKEY>();
            ComObject.Object.GetCount(out var count);
            for (var i = 0; i < count; i++)
            {
                if (ComObject.Object.GetAt((uint)i, out var key).IsSuccess)
                {
                    list.Add(key);
                }
            }
            return list;
        }
    }

    public ICollection<object?> Values
    {
        get
        {
            var list = new List<object?>();
            ComObject.Object.GetCount(out var count);
            for (var i = 0; i < count; i++)
            {
                // get consistent with Keys
                if (ComObject.Object.GetAt((uint)i, out var key).IsSuccess)
                {
                    ComObject.Object.GetValue(key, out var value);
                    using var pv = PropVariant.Attach(ref value);
                    list.Add(pv.Value);
                }
            }
            return list;
        }
    }

    public int Count
    {
        get
        {
            ComObject.Object.GetCount(out var count);
            return (int)count;
        }
    }

    bool ICollection<KeyValuePair<PROPERTYKEY, object?>>.IsReadOnly => false;

    public object? this[PROPERTYKEY key]
    {
        get
        {
            if (!TryGetValue(key, out var value))
                throw new KeyNotFoundException();

            return value;
        }
        set => SetValue(key, value);
    }

    void IDictionary<PROPERTYKEY, object?>.Add(PROPERTYKEY key, object? value) => SetValue(key, value);
    void ICollection<KeyValuePair<PROPERTYKEY, object?>>.Add(KeyValuePair<PROPERTYKEY, object?> item) => SetValue(item.Key, item.Value);
    public void SetValue(KeyValuePair<PROPERTYKEY, object?> item) => SetValue(item.Key, item.Value);
    public virtual void SetValue(PROPERTYKEY key, object? value)
    {
        if (value is PROPVARIANT detached)
        {
            ComObject.Object.SetValue(key, detached).ThrowOnError();
            return;
        }

        if (value is PropVariant propVariant)
        {
            ComObject.Object.SetValue(key, propVariant.Detached).ThrowOnError();
            return;
        }

        using var pv = new PropVariant(value);
        ComObject.Object.SetValue(key, pv.Detached).ThrowOnError();
    }

    bool IDictionary<PROPERTYKEY, object?>.Remove(PROPERTYKEY key) => RemoveValue(key);
    bool ICollection<KeyValuePair<PROPERTYKEY, object?>>.Remove(KeyValuePair<PROPERTYKEY, object?> item) => RemoveValue(item);
    public bool RemoveValue(KeyValuePair<PROPERTYKEY, object?> item) => RemoveValue(item.Key); // no, we don't compare with value...
    public virtual bool RemoveValue(PROPERTYKEY key) => ComObject.Object.SetValue(key, new PROPVARIANT()).IsSuccess;

    public virtual bool TryGetValue(PROPERTYKEY key, [MaybeNullWhen(false)] out object? value)
    {
        if (ComObject.Object.GetValue(key, out var pvValue).IsError || pvValue.Anonymous.Anonymous.vt == VARENUM.VT_EMPTY)
        {
            value = null;
            return false;
        }

        using var pv = PropVariant.Attach(ref pvValue);
        value = pv.Value;
        return true;
    }

    public virtual bool TryGetValue<T>(PROPERTYKEY key, [MaybeNullWhen(false)] out T? value)
    {
        if (ComObject.Object.GetValue(key, out var pvValue).IsError || pvValue.Anonymous.Anonymous.vt == VARENUM.VT_EMPTY)
        {
            value = default;
            return false;
        }

        using var pv = PropVariant.Attach(ref pvValue);
        var netValue = pv.Value;

        if (!Conversions.TryChangeType(netValue, out value))
        {
            value = default;
            return false;
        }
        return true;
    }

    public string? GetNullifiedStringValue(PROPERTYKEY key)
    {
        if (!TryGetValue(key, out var value))
            return null;

        if (value is string s)
            return s.Nullify();

        return value?.ToString().Nullify();
    }

    public T? GetValue<T>(PROPERTYKEY key, T? defaultValue = default)
    {
        if (!TryGetValue<T>(key, out var value))
            return defaultValue;

        return value;
    }

    public virtual void Clear()
    {
        ComObject.Object.GetCount(out var count);
        if (count == 0)
            return;

        var pv = new PROPVARIANT();
        for (var i = 0; i < count; i++)
        {
            ComObject.Object.GetAt((uint)i, out var key).ThrowOnError();
            ComObject.Object.SetValue(key, pv).ThrowOnError();
        }
    }

    public bool ContainsKey(PROPERTYKEY key) => TryGetValue(key, out _);
    public bool Contains(KeyValuePair<PROPERTYKEY, object?> item)
    {
        if (!TryGetValue(item.Key, out var value))
            return false;

        return value?.Equals(item.Value) ?? item.Value == null;
    }

    public virtual void CopyTo(KeyValuePair<PROPERTYKEY, object?>[] array, int arrayIndex)
    {
        // don't try to be too clever here or face a recursion
        var source = new List<KeyValuePair<PROPERTYKEY, object?>>();
        foreach (var kvp in this)
        {
            source.Add(kvp);
        }
        source.CopyTo(array, arrayIndex);
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    public IEnumerator<KeyValuePair<PROPERTYKEY, object?>> GetEnumerator()
    {
        ComObject.Object.GetCount(out var count);
        for (var i = 0; i < count; i++)
        {
            if (ComObject.Object.GetAt((uint)i, out var key).IsSuccess)
            {
                ComObject.Object.GetValue(key, out var value);
                using var pv = PropVariant.Attach(ref value);
                yield return new KeyValuePair<PROPERTYKEY, object?>(key, pv.Value);
            }
        }
    }

    public virtual void Commit() => ComObject.Object.Commit().ThrowOnError();
    public virtual void Save(Stream stream)
    {
        ArgumentNullException.ThrowIfNull(stream);
        var ps = ComObject.As<DirectN.IPersistStream>(throwOnError: true)!;
        var strm = new ManagedIStream(stream);
        ps.Object.Save(strm, true).ThrowOnError();
    }

    public static PropertyStore? Load(Stream? stream, bool throwOnError = true)
    {
        if (stream == null)
            return null;

        var store = Create();
        var stm = store.ComObject.As<DirectN.IPersistStream>(throwOnError: true)!;
        var hr = stm.Object.Load(new ManagedIStream(stream)).ThrowOnError(throwOnError);
        if (hr.IsError)
            return null;

        return store;
    }
}
