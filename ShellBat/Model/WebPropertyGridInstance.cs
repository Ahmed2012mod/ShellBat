namespace ShellBat.Model;

[System.Runtime.InteropServices.Marshalling.GeneratedComClass]
public partial class WebPropertyGridInstance : DispatchObject, INotifyPropertyChanged
{
    public IDictionary<string, object?> Properties { get; } = new Dictionary<string, object?>(StringComparer.OrdinalIgnoreCase);

    public event PropertyChangedEventHandler? PropertyChanged;

    public ISet<string> ChangedPropertyNames { get; } = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
    public bool HasChanges => ChangedPropertyNames.Count > 0;

    public virtual bool SetValue(string propertyName, object? value)
    {
        ArgumentNullException.ThrowIfNull(propertyName);
        if (Properties.TryGetValue(propertyName, out var existingValue) &&
            Equals(existingValue, value))
            return false;

        Properties[propertyName] = value;
        ChangedPropertyNames.Add(propertyName);
        OnPropertyChanged(this, propertyName);
        return true;
    }

    public virtual object? GetValue(string propertyName)
    {
        ArgumentNullException.ThrowIfNull(propertyName);
        Properties.TryGetValue(propertyName, out var value);
        return value;
    }

    public string? GetNullifiedString(string propertyName)
    {
        ArgumentNullException.ThrowIfNull(propertyName);
        if (!Properties.TryGetValue(propertyName, out var value))
            return null;

        return Conversions.ChangeType<string>(value).Nullify();
    }

    public T? GetTypedValue<T>(string propertyName, T? defaultValue = default)
    {
        ArgumentNullException.ThrowIfNull(propertyName);
        if (!Properties.TryGetValue(propertyName, out var value))
            return defaultValue;

        return Conversions.ChangeType<T>(value, defaultValue);
    }

    protected virtual void OnPropertyChanged(object sender, [CallerMemberName] string? propertyName = null) => PropertyChanged?.Invoke(sender, new PropertyChangedEventArgs(propertyName));
}
