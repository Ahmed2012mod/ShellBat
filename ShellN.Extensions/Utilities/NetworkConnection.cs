namespace ShellN.Extensions.Utilities;

public sealed class NetworkConnection
{
    private NetworkConnection() { }

    public required NET_RESOURCE_SCOPE Scope { get; init; }
    public required NET_RESOURCE_TYPE Type { get; init; }
    public required uint DisplayType { get; init; }
    public required uint Usage { get; init; }
    public required string? LocalName { get; init; }
    public required string? RemoteName { get; init; }
    public required string? Comment { get; init; }
    public required string? Provider { get; init; }

    public static IReadOnlyList<NetworkConnection> GetConnectedOrRememberedDisks()
    {
        var resources = Get(NET_RESOURCE_SCOPE.RESOURCE_CONNECTED, NET_RESOURCE_TYPE.RESOURCETYPE_DISK);
        foreach (var resource in Get(NET_RESOURCE_SCOPE.RESOURCE_REMEMBERED, NET_RESOURCE_TYPE.RESOURCETYPE_DISK))
        {
            if (!resources.Any(r => string.Equals(r.RemoteName, resource.RemoteName, StringComparison.OrdinalIgnoreCase)))
            {
                ((List<NetworkConnection>)resources).Add(resource);
            }
        }
        return resources;
    }

    public unsafe static IReadOnlyList<NetworkConnection> Get(
        NET_RESOURCE_SCOPE scope = NET_RESOURCE_SCOPE.RESOURCE_REMEMBERED,
        NET_RESOURCE_TYPE type = NET_RESOURCE_TYPE.RESOURCETYPE_DISK,
        WNET_OPEN_ENUM_USAGE usage = WNET_OPEN_ENUM_USAGE.RESOURCEUSAGE_NONE
        )
    {
        var list = new List<NetworkConnection>();
        if (Functions.WNetOpenEnumW(scope, type, usage, 0, out var handle) == 0)
        {
            var size = 16384u;
            WIN32_ERROR res;
            do
            {
                var resources = new ComMemory(size);
                var entryCount = uint.MaxValue;
                res = Functions.WNetEnumResourceW(handle, ref entryCount, resources.Pointer, ref size);
                if (res == WIN32_ERROR.ERROR_NO_MORE_ITEMS)
                    break;

                for (var i = 0; i < entryCount; i++)
                {
                    var netResource = ((NETRESOURCEW*)resources.Pointer) + i;
                    var nc = new NetworkConnection
                    {
                        Scope = netResource->dwScope,
                        Type = netResource->dwType,
                        DisplayType = netResource->dwDisplayType,
                        Usage = netResource->dwUsage,
                        LocalName = netResource->lpLocalName.ToString(),
                        RemoteName = netResource->lpRemoteName.ToString(),
                        Comment = netResource->lpComment.ToString(),
                        Provider = netResource->lpProvider.ToString(),
                    };
                    list.Add(nc);
                }
            }
            while (res != WIN32_ERROR.ERROR_NO_MORE_ITEMS);
        }
        return list;
    }
}
