using Xunit;
using HelloWorld;

namespace HelloWorld.Tests;

public class UnitTest1
{
    // Test print function
    [Fact]
    public void PrintMessage_ShouldPrintHelloWorld()
    {
        using var writer = new StringWriter();
        Console.SetOut(writer);

        Program.PrintMessage();

        Assert.Equal("Hello World!" + Environment.NewLine, writer.ToString());
    }

    // Test main fuction
    [Fact]
    public void Main_ShouldPrintHelloWorld()
    {
        using var writer = new StringWriter();
        Console.SetOut(writer);

        Program.Main();

        Assert.Equal("Hello World!" + Environment.NewLine, writer.ToString());
    }
}