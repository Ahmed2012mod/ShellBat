namespace ShellN.Extensions;

public sealed class ItemIdListEqualityComparer : IEqualityComparer<ItemIdList>
{
    public static ItemIdListEqualityComparer Instance { get; } = new ItemIdListEqualityComparer();

    public bool Equals(ItemIdList? left, ItemIdList? right)
    {
        if (left is null)
            return right is null;

        if (right is null)
            return false;

        return left.Equals(right);
    }

    public int GetHashCode(ItemIdList idList)
    {
        ArgumentNullException.ThrowIfNull(idList);
        return idList.GetHashCode();
    }
}
