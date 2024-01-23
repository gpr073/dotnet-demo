using System;
using MyApp;
using Xunit;

namespace MyApp.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Main_ShouldPrintHelloWorld()
        {
            // Arrange
            var expected = "Hello, world!";
            var writer = new System.IO.StringWriter();
            Console.SetOut(writer);

            // Act
            Program.Main(null);

            // Assert
            var actual = writer.ToString().Trim();
            Assert.Equal(expected, actual);
        }
    }
}