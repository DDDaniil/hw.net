using Xunit;

namespace hw1.Tests
{
    public class ProgramTests
    {
        [Theory]
        [InlineData(new[] {"777", "", "777"}, 2)]
        [InlineData(new[] {"77", "ololo", "77"}, 2)]
        [InlineData(new[] {"1","$","1"},2)]
        [InlineData(new[] {"2"," ","3"},2)]
        [InlineData(new[] {"Gh", "+", "3"}, 1)]
        [InlineData(new[] {"", "+", "a"}, 1)]
        [InlineData(new[] {"aaaaaaa", "+", "ffffff"}, 1)]
        [InlineData(new[] {"", "+", ""}, 1)]
        [InlineData(new[] {"1", "+", "2"}, 0)]
        [InlineData(new[] {"4", "-", "1"}, 0)]
        [InlineData(new[] {"3", "+", "1"}, 0)]
        public void CorrectionProgram(string[] args, int expected)
        {
            /*var res = Parser.TryToParse(args, out var val1,
                out var operation, out var val2);*/
            //var res = Program.Main(args);
            
            //Assert.Equal(expected, res);
        }
    }
}