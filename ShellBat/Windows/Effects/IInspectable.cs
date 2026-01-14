namespace ShellBat.Windows.Effects;

[SupportedOSPlatform("windows8.0")]
[System.Runtime.InteropServices.Marshalling.GeneratedComInterface, Guid("af86e2e0-b12d-4c6a-9c5a-d7aa65101e90")]
public partial interface IInspectable
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIids(out uint iidCount, out nint iids);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRuntimeClassName(out HSTRING className);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTrustLevel(out DirectN.TrustLevel trustLevel);
}
