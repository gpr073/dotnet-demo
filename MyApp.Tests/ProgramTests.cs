// using System;
// using MyApp;
// using Xunit;

// namespace MyApp.Tests
// {
//     public class ProgramTests
//     {
//         [Fact]
//         public void Main_ShouldPrintHelloWorld()
//         {
//             // Arrange
//             var expected = "Hello, world!";
//             var writer = new System.IO.StringWriter();
//             Console.SetOut(writer);

//             // Act
//             Program.Main(null);

//             // Assert
//             var actual = writer.ToString().Trim();
//             Assert.Equal(expected, actual);
//         }
//     }
// }

using System;
using System.Collections;
using Xunit;

public class TCHLNTests
{
    [Fact]
    public void TestStackElements()
    {
        // Arrange
        Stack my_stack = new Stack();
        my_stack.Push("Tech");
        my_stack.Push("Evolution");
        my_stack.Push("Techolution");
        my_stack.Push(null);
        my_stack.Push(1234);
        my_stack.Push(490.98);

        // Act
        var elements = new ArrayList();
        foreach (var elem in my_stack)
        {
            elements.Add(elem);
        }

        // Assert
        Assert.Equal(6, elements.Count);
        Assert.Equal(490.98, elements[0]);
        Assert.Equal(1234, elements[1]);
        Assert.Null(elements[2]);
        Assert.Equal("Techolution", elements[3]);
        Assert.Equal("Evolution", elements[4]);
        Assert.Equal("Tech", elements[5]);
    }
}