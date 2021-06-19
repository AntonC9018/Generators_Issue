using Microsoft.CodeAnalysis;

namespace Generator
{
    [Generator]
    public class MyGenerator : ISourceGenerator
    {
        public void Initialize(GeneratorInitializationContext context)
        {
        }

        public void Execute(GeneratorExecutionContext context)
        {
            context.AddSource("generated.cs", "class Foo { }");
        }
    }
}