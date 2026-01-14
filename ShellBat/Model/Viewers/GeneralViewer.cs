using System.Security.Cryptography.X509Certificates;

namespace ShellBat.Model.Viewers;

[System.Runtime.InteropServices.Marshalling.GeneratedComClass]
public partial class GeneralViewer(Entry entry) : Viewer(entry)
{
    public override int SortOrder => int.MinValue;
    public override bool IsSupported => true;

    public override Task<WebPropertyGrid?> GetProperties()
    {
        var options = WebPropertyGridReflectOptions.RemoveEmptyStringValues | WebPropertyGridReflectOptions.RemoveNullValues;
        WebPropertyGrid? grid = null;
        if (Entry.IsFolder)
        {
            var folder = new FolderProperties(Entry);
            fillShell(folder);
            grid = WebPropertyGrid.Reflect(folder, options);
            grid.Options.GroupByCategory = false;
        }
        else if (Entry.Extension.IsShortcut && Link.Load(Entry.ParsingName, throwOnError: false) is Link link)
        {
            var file = new LinkProperties(Entry, link);
            fillShell(file);
            grid = WebPropertyGrid.Reflect(file, options);
            grid.Options.GroupByCategory = true;
            link.Dispose();

            grid.Options.Categories.Insert(0, new WebPropertyGridCategory
            {
                Key = "Link",
                DisplayName = Res.Link,
                SortOrder = int.MaxValue - 1 // after General
            });

            grid.Options.Categories.Insert(0, new WebPropertyGridCategory
            {
                Key = "Link.Properties",
                DisplayName = Res.LinkProperties,
                SortOrder = int.MaxValue // after Link
            });
        }
        else
        {
            if (IOUtilities.PathIsFile(Entry.ParsingName))
            {
                var signature = Authenticode.GetSignature(Entry.ParsingName);
                if (signature != null)
                {
                    var fileWithSignature = new AuthenticodeProperties(Entry, signature);
                    fillShell(fileWithSignature);
                    grid = WebPropertyGrid.Reflect(fileWithSignature, options);
                    grid.Options.GroupByCategory = true;

                    grid.Options.Categories.Insert(0, new WebPropertyGridCategory
                    {
                        Key = "DigitalSignatures",
                        DisplayName = Res.DigitalSignatures,
                        SortOrder = int.MaxValue // last
                    });
                }
            }

            if (grid == null)
            {
                var file = new FilesProperties(Entry);
                fillShell(file);
                grid = WebPropertyGrid.Reflect(file, options);
                grid.Options.GroupByCategory = false;
            }
        }

        grid.Options.IsReadOnly = true;
        grid.Options.BaseClassName = "fld-pg";
        return Task.FromResult<WebPropertyGrid?>(grid);

        void fillShell(BaseProperties properties)
        {
            if (properties is FilesProperties fileProps)
            {
                var item = Entry.GetItem(Entry.ParsingName, ShellItemParsingOptions.DontThrowOnError);
                if (item != null)
                {
                    fileProps.Type = item.GetPropertyValue<string>(ShellN.PropertyKeys.System.ItemTypeText);
                    fileProps.ContentType = item.GetPropertyValue<string>(ShellN.PropertyKeys.System.ContentType);
                }
            }
        }
    }

    protected class BaseProperties(Entry entry)
    {
        public string Name { get; } = entry.DisplayName;
        public string FullName { get; } = entry.FullDisplayName;
        public string? LastWriteTime { get; } = entry.FormattedLastWriteTime;
        public string? CreationTime { get; } = entry.FormattedCreationTime;
        public string? LastAccessTime { get; } = entry.FormattedLastAccessTime;
        public string ShellAttributes { get; } = entry.Attributes.ToString().Replace("SFGAO_", string.Empty);
        public string FileAttributes { get; } = entry.FileAttributes.ToString();
    }

    protected class FilesProperties(Entry entry) : BaseProperties(entry)
    {
        public string Size { get; } = $"{entry.FormattedSize} ({ShellBatExtensions.FormatByteSize(entry.Size)})";
        public string? Type { get; internal set; }
        public string? ContentType { get; internal set; }
    }

    protected class LinkProperties(Entry entry, Link link) : FilesProperties(entry)
    {
        [Category("Link")]
        public string? TargetPath { get; } = link.TargetPath;

        [Category("Link")]
        public string? Arguments { get; } = link.Arguments;

        [Category("Link")]
        public ushort Hotkey { get; } = link.Hotkey;

        [Category("Link")]
        public string ShowCommand { get; } = link.ShowCommand.ToString();

        [Category("Link")]
        public Guid Clsid { get; } = link.Clsid;

        [Category("Link")]
        public string? Description { get; } = link.Description;

        [Category("Link")]
        public string? WorkingDirectory { get; } = link.WorkingDirectory;

        [Category("Link.Properties")]
        public IEnumerable<KeyValuePair<string, object?>> Properties
        {
            get
            {
                var properties = link.Properties;
                if (properties == null)
                    yield break;

                foreach (var kv in properties)
                {
                    var pd = kv.Key.ToDescription();
                    var desc = pd?.DisplayName ?? pd?.CanonicalName;
                    if (desc != null)
                        yield return new KeyValuePair<string, object?>(desc, kv.Value);
                    else
                        yield return new KeyValuePair<string, object?>(kv.Key.ToString(), kv.Value);
                }
            }
        }
    }

    protected class AuthenticodeProperties(Entry entry, AuthenticodeSignature signature) : FilesProperties(entry)
    {
        [Category("DigitalSignatures")]
        [WebPropertyGridProperty(IsHtml = true, BaseClassName = "signatures")]
        public string Signatures
        {
            get
            {
                var signatures = new StringBuilder();
                foreach (var signature in signature.AllSignatures)
                {
                    foreach (var sig in signature.SignerInfos)
                    {
                        var signer = sig.Certificate?.GetNameInfo(X509NameType.SimpleName, false).Nullify() ??
                            sig.Certificate?.GetNameInfo(X509NameType.DnsName, false).Nullify() ??
                            sig.Certificate?.SubjectName.Name.Nullify() ?? "???";
                        signatures.AppendLine("<div class=signature>");
                        signatures.AppendLine($"<strong tooltip='{sig.Certificate?.FriendlyName}'>{Res.Signer}&nbsp;:</strong> {signer}<br/>");
                        signatures.AppendLine($"<strong>{Res.Algorithm}&nbsp;:</strong> {sig.HashAlgorithm.FriendlyName}<br/>");

                        var issuer = sig.Certificate?.GetNameInfo(X509NameType.SimpleName, true).Nullify() ??
                            sig.Certificate?.GetNameInfo(X509NameType.DnsName, true).Nullify() ??
                            sig.Issuer?.Name.Nullify() ?? "???";

                        signatures.AppendLine($"<strong tooltip='{sig.Issuer?.Name}'>{Res.Issuer}&nbsp;:</strong> {issuer}<br/>");
                        if (sig.TimestampSignature != null)
                        {
                            signatures.AppendLine($"<strong>{Res.Timestamp}&nbsp;:</strong> {sig.TimestampSignature.Time:F}<br/>");
                        }

                        if (sig.ProgramName != null)
                        {
                            signatures.AppendLine($"<strong>{Res.ProgramName}&nbsp;:</strong> {sig.ProgramName}<br/>");
                        }

                        if (sig.PublisherLink != null)
                        {
                            signatures.AppendLine($"<strong>{Res.Publisher}&nbsp;: </strong>{sig.PublisherLink}<br/>");
                        }

                        if (sig.MoreLink != null)
                        {
                            signatures.AppendLine($"<strong>{Res.More}&nbsp;: </strong>{sig.MoreLink}<br/>");
                        }

                        signatures.AppendLine("</div>");
                    }
                }
                return signatures.ToString();
            }
        }
    }

    protected class FolderProperties(Entry entry) : BaseProperties(entry)
    {
        public string? VirtualDiskImagePath { get; } = entry.VirtualDiskImagePath;
    }
}
