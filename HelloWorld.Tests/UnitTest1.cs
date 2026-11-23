using Xunit;
using HelloWorld;

namespace HelloWorld.Tests;

public class UnitTest1
{
    [Fact]
    public void PrintMessage_ShouldPrintHelloWorld()
    {
        using var writer = new StringWriter();
        Console.SetOut(writer);

        Program.PrintMessage();

        Assert.Equal("Hello World!" + Environment.NewLine, writer.ToString());
    }
}