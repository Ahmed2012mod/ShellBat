namespace ShellN
{
    [Flags]
    public enum OFASI : uint
    {
        OFASI_NONE = 0x00000000,
        OFASI_EDIT = Constants.OFASI_EDIT,
        OFASI_OPENDESKTOP = Constants.OFASI_OPENDESKTOP,
    }
}
