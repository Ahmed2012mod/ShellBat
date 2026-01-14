namespace ShellBat.Model;

public interface IEnumProvider
{
    bool IsFlags { get; }
    IDictionary<string, object?>? Values { get; }
}
