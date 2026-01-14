namespace ShellBat.Utilities;

public class VisualStudioProject
{
    internal VisualStudioProject(IComObject<DirectN.IDispatch> project)
    {
        try
        {
            Name = project.GetProperty<string>("Name") ?? string.Empty;
            FullName = project.GetProperty<string>("FullName") ?? string.Empty;
            FileName = project.GetProperty<string>("FileName") ?? string.Empty;

            using var configuration = project.GetComObjectProperty<DirectN.IDispatch>("ConfigurationManager")?.GetComObjectProperty<DirectN.IDispatch>("ActiveConfiguration");
            if (configuration != null)
            {
                using var props = configuration.GetComObjectProperty<DirectN.IDispatch>("Properties");
                var outputPath = VisualStudioSolution.GetNullifiedValue(props, "OutputPath") ??
                    VisualStudioSolution.GetNullifiedValue(props, "IntermediatePath");

                // kinda hacky
                outputPath = outputPath?.Replace(@"obj\", @"bin\", StringComparison.OrdinalIgnoreCase).TrimEnd('\\', '/');
                if (outputPath != null)
                {
                    if (!IOUtilities.IsPathRooted(outputPath))
                    {
                        var projectDir = Path.GetDirectoryName(FullName);
                        if (!string.IsNullOrWhiteSpace(projectDir))
                        {
                            outputPath = Path.GetFullPath(Path.Combine(projectDir, outputPath));
                        }
                    }

                    if (IOUtilities.PathIsDirectory(outputPath))
                    {
                        OutputPath = outputPath;
                    }
                }
            }
        }
        finally
        {
            project.Dispose();
        }
    }

    public string Name { get; }
    public string FullName { get; }
    public string FileName { get; }
    public string? OutputPath { get; }

    public override string ToString() => FullName;
}
