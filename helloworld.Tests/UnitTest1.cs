using System;
using System.IO;
using Xunit;

namespace helloworld.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Main_writes_hello_world()
        {
            //arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            //act
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            //assert
            Assert.Equal("Hello, World!", output);
        }
    }
}
