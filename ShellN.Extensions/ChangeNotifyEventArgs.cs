namespace ShellN.Extensions;

public class ChangeNotifyEventArgs(ItemIdList? idl1, ItemIdList? idl2, SHCNE_ID @event) : EventArgs
{
    public ItemIdList? IdList1 { get; } = idl1;
    public ItemIdList? IdList2 { get; } = idl2;
    public SHCNE_ID? Event { get; } = @event;
}
