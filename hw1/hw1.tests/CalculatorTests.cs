using System;
using Xunit;

namespace hw1.tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(1, "+", 1, 2)]
        [InlineData(1, "-", 1, 0)]
        [InlineData(5, "*", 1, 5)]
        [InlineData(6, "/", 3, 2)]
        public void Should_Calculate_Correctly_WhenRightArguments(int val1, string operation,
            int val2, int expected)
        {
            var res = Calculator.Calculate(val1, operation, val2);
            
            Assert.Equal(expected, res);
            
        }
    }
}