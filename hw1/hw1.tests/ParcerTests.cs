using Xunit;

namespace hw1.tests
{
    public class ParserTests
    {
        [Theory]
        [InlineData(new[] {"1", "+", "2"}, 0)]
        [InlineData(new[] {"4", "-", "1"}, 0)]
        [InlineData(new[] {"3", "+", "1"}, 0)]
        
        public void ParceRight_WhenArgumentsRight(string[] args, int expected)
        {
            var res = Parser.TryToParse(args, out var val1,
                out var operation, out var val2);

            Assert.Equal(expected, res);
        }
    }
}