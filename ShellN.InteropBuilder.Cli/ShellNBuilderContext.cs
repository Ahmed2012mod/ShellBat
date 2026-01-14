using Win32InteropBuilder;
using Win32InteropBuilder.Model;

namespace ShellN.InteropBuilder.Cli;

public class ShellNBuilderContext(BuilderConfiguration configuration, IGenerator language)
    : BuilderContext(configuration, language)
{
    public override string GetConstantValue(BuilderType type, Constant constant)
    {
        if (type.Name == "DEVPROPKEY")
        {
            // format is {3927062522, 22685, 17522, 132, 228, 10, 190, 54, 253, 98, 239}, 2
            var parts = constant.ValueAsText.Split("}, ");
            var fmtId = parts[0].Trim('{', '}');
            var pid = parts[1];
            return $"new(new({fmtId}), {pid})";
        }

        return base.GetConstantValue(type, constant);
    }
}
