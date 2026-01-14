namespace ShellN.Extensions;

public interface IItemWithAbsoluteIdList : IItemWithId
{
    ItemIdList? AbsoluteIdList { get; }
}
