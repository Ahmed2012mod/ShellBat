namespace ShellN;

public static class PROPERTYKEYS
{
    public static PROPERTYKEY SystemNull { get; } = new();
    public static PROPERTYKEY SystemItemNameDisplay { get; } = new(new("b725f130-47ef-101a-a5f1-02608c9eebac"), 10);
    public static PROPERTYKEY SystemPerceivedType { get; } = new(new("28636aa6-953d-11d2-b5d6-00c04fd918d0"), 9);
    public static PROPERTYKEY SystemItemType { get; } = new(new("28636aa6-953d-11d2-b5d6-00c04fd918d0"), 11);
    public static PROPERTYKEY SystemKind { get; } = new(new("1e3ee840-bc2b-476c-8237-2acd1a839b22"), 3);
    public static PROPERTYKEY SystemSize { get; } = new(new("b725f130-47ef-101a-a5f1-02608c9eebac"), 12);
    public static PROPERTYKEY SystemFileAttributes { get; } = new(new("b725f130-47ef-101a-a5f1-02608c9eebac"), 13);
    public static PROPERTYKEY SystemDateModified { get; } = new(new("b725f130-47ef-101a-a5f1-02608c9eebac"), 14);
    public static PROPERTYKEY SystemDateCreated { get; } = new(new("b725f130-47ef-101a-a5f1-02608c9eebac"), 15);
    public static PROPERTYKEY SystemDateAccessed { get; } = new(new("b725f130-47ef-101a-a5f1-02608c9eebac"), 16);
    public static PROPERTYKEY SystemFileExtension { get; } = new(new("e4f10a3c-49e6-405d-8288-a23bd4eeaa6c"), 100);
    public static PROPERTYKEY SystemSFGAOFlags { get; } = new(new("28636aa6-953d-11d2-b5d6-00c04fd918d0"), 25);
    public static PROPERTYKEY SystemNamespaceCLSID { get; } = new(new("28636aa6-953d-11d2-b5d6-00c04fd918d0"), 6);
    public static PROPERTYKEY SystemVolumeBitLockerProtection => new(new("2d15a9a1-a556-4189-91ad-027458f11a07"), 1717);
}
