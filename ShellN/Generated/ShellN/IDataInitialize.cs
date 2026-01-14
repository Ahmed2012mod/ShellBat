#nullable enable
namespace ShellN;

[GeneratedComInterface, Guid("2206ccb1-19c1-11d1-89e0-00c04fd7a829")]
public partial interface IDataInitialize
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDataSource(nint pUnkOuter, uint dwClsCtx, PWSTR pwszInitializationString, in Guid riid, ref nint ppDataSource);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInitializationString(nint pDataSource, byte fIncludePassword, out PWSTR ppwszInitString);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDBInstance(in Guid clsidProvider, nint pUnkOuter, uint dwClsCtx, PWSTR pwszReserved, in Guid riid, out nint ppDataSource);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDBInstanceEx(in Guid clsidProvider, nint pUnkOuter, uint dwClsCtx, PWSTR pwszReserved, in COSERVERINFO pServerInfo, uint cmq, [In][Out][MarshalUsing(CountElementName = nameof(cmq))] MULTI_QI[] rgmqResults);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadStringFromStorage(PWSTR pwszFileName, out PWSTR ppwszInitializationString);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WriteStringToStorage(PWSTR pwszFileName, PWSTR pwszInitializationString, uint dwCreationDisposition);
}
