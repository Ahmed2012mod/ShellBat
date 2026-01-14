namespace ShellBat.Utilities;

// https://learn.microsoft.com/en-us/windows/win32/debug/pe-format
public class PEInfo
{
    private readonly List<string> _exports = [];

    private PEInfo(PEFormat format)
    {
        Format = format;
    }

    public IReadOnlyList<string> Exports => _exports.AsReadOnly();
    public PEFormat Format { get; }
    public IMAGE_SUBSYSTEM ImageSubSystem { get; private set; }

    public static IEnumerable<PEInfo> FromDirectory(string directoryPath, string? searchPattern = null, EnumerationOptions? options = null)
    {
        ArgumentNullException.ThrowIfNull(directoryPath);

        searchPattern ??= "*.*";
        options ??= new EnumerationOptions
        {
            RecurseSubdirectories = false,
            IgnoreInaccessible = true,
            AttributesToSkip = FileAttributes.System | FileAttributes.Hidden
        };

        foreach (var file in Directory.EnumerateFiles(directoryPath, searchPattern, options))
        {
            var export = FromFile(file);
            if (export != null)
            {
                yield return export;
            }
        }
    }

    public static PEInfo? FromFile(string filePath)
    {
        ArgumentNullException.ThrowIfNull(filePath);
        using var file = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete);
        return FromStream(file);
    }

    public static PEInfo? FromStream(Stream file)
    {
        ArgumentNullException.ThrowIfNull(file);
        try
        {
            if (file.Length <= 60)
                return null;

            var br = new BinaryReader(file);
            if (br.ReadByte() != 'M' || br.ReadByte() != 'Z')
                return null;

            file.Seek(60, SeekOrigin.Begin);
            var e_lfanew = br.ReadInt32();

            file.Seek(e_lfanew, SeekOrigin.Begin);
            if (br.ReadInt32() != 0x4550) // PE
                return null;

            file.Seek(e_lfanew + 4 + 2, SeekOrigin.Begin);
            var numberOfSections = br.ReadInt16();
            if (numberOfSections == 0)
                return null;

            file.Seek(e_lfanew + 16 + 2, SeekOrigin.Begin);
            var sizeOfOptionalHeader = br.ReadInt16();

            file.Seek(e_lfanew + 24, SeekOrigin.Begin); // max size of PE32
            var optionalHeader = file.Position;
            var format = (PEFormat)br.ReadInt16();
            if (format != PEFormat.PE32 && format != PEFormat.PE32Plus)
                return null;

            var export = new PEInfo(format);
            file.Seek(optionalHeader + 68, SeekOrigin.Begin);
            export.ImageSubSystem = (IMAGE_SUBSYSTEM)br.ReadInt16();

            file.Seek(optionalHeader + (format == PEFormat.PE32 ? 92 : 108), SeekOrigin.Begin);
            var numberOfRvaAndSizes = br.ReadInt32();
            if (numberOfRvaAndSizes != 16)
                return null;

            var exportVirtualAddress = br.ReadUInt32();
            var exportSize = br.ReadUInt32();
            if (exportVirtualAddress == 0 || exportSize == 0)
                return export;

            file.Seek(numberOfRvaAndSizes * 8 - 8, SeekOrigin.Current);
            var sections = new List<Section>();
            for (var i = 0; i < numberOfSections; i++)
            {
                var name = Encoding.ASCII.GetString(br.ReadBytes(8)).Replace("\0", string.Empty);
                var section = new Section(name);
                sections.Add(section);

                section.VirtualSize = br.ReadUInt32();
                section.VirtualAddress = br.ReadUInt32();
                section.SizeOfRawData = br.ReadUInt32();
                section.PointerToRawData = br.ReadUInt32();
                section.PointerToRelocations = br.ReadUInt32();
                section.PointerToLinenumbers = br.ReadUInt32();
                section.NumberOfRelocations = br.ReadInt16();
                section.NumberOfLinenumbers = br.ReadInt16();
                section.Characteristics = br.ReadUInt32();
            }

            var offset = rvaToOffset(exportVirtualAddress);

            // https://docs.microsoft.com/en-us/windows/win32/debug/pe-format#export-directory-table
            file.Seek(offset + 24, SeekOrigin.Begin);
            var numberOfNames = br.ReadInt32();
            var exportAddressTableRva = br.ReadInt32();
            var namePointerRva = br.ReadUInt32();

            var namesOffset = rvaToOffset(namePointerRva);
            file.Seek(namesOffset, SeekOrigin.Begin);

            for (var i = 0; i < numberOfNames; i++)
            {
                var nameRva = br.ReadUInt32();
                var pos = file.Position;
                file.Seek(rvaToOffset(nameRva), SeekOrigin.Begin);

                var sb = new StringBuilder();
                do
                {
                    var c = br.ReadByte();
                    if (c == 0)
                        break;

                    sb.Append((char)c);
                }
                while (true);

                export._exports.Add(sb.ToString());
                file.Seek(pos, SeekOrigin.Begin);
            }

            uint rvaToOffset(uint rva)
            {
                for (var i = 0; i < sections.Count; i++)
                {
                    var o = sections[i].VirtualAddress + sections[i].SizeOfRawData;
                    if (o >= rva)
                        return sections[i].PointerToRawData + rva + sections[i].SizeOfRawData - o;
                }
                return 0xFFFFFFFF;
            }
            return export;
        }
        catch (UnauthorizedAccessException)
        {
            return null;
        }
        catch (Exception e)
        {
            Application.TraceError($"Failed to read exports: {e}");
            return null;
        }
    }

    private sealed class Section(string name)
    {
        public string Name = name;
        public uint VirtualSize;
        public uint VirtualAddress;
        public uint SizeOfRawData;
        public uint PointerToRawData;
        public uint PointerToRelocations;
        public uint PointerToLinenumbers;
        public short NumberOfRelocations;
        public short NumberOfLinenumbers;
        public uint Characteristics;

        public override string ToString() => Name;
    }
}