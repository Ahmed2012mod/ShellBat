#nullable enable
namespace ShellN;

// https://learn.microsoft.com/windows/win32/api/shdeprecated/nn-shdeprecated-itravelentry
[GeneratedComInterface, Guid("f46edb3b-bc2f-11d0-9412-00aa00a3ebd3")]
public partial interface ITravelEntry
{
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-itravelentry-invoke
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke(nint punk);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-itravelentry-update
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Update(nint punk, BOOL fIsLocalAnchor);
    
    // https://learn.microsoft.com/windows/win32/api/shdeprecated/nf-shdeprecated-itravelentry-getpidl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPidl(out nint ppidl);
}
