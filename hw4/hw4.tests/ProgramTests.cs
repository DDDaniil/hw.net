using Xunit;
using hw4;

namespace hw4.Tests
{
    public class ProgramTests
    {
        [Theory]
        [InlineData(new[] {"aaaaaaa", "+", "ffffff"}, 0)]
        [InlineData(new[] {"3", "+", "1"}, 0)]
        public void CorrectionProgram(string[] args, int expected)
        {
            var res = Program.Main(args);
            
            Assert.Equal(expected, res);
        }
    }
}