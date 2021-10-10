using System;
using Xunit;

namespace hw4.tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(1, "+", 3, 4)]
        [InlineData(2, "-", 2, 0)]
        [InlineData(3, "*", 1, 3)]
        [InlineData(4, "/", 2, 2)]
        [InlineData(0, "+", 0, 0)]
        [InlineData(1, "/", 1, 1)]
        public void Calculate_IfArgumentsRight(int val1, string operation,
            int val2, int expected)
        {
            var res = Calculator.Calculate(val1, operation, val2);
            
            Assert.Equal(expected, res);
            
        }
        
        [Theory]
        [InlineData(777, "", 777, 0)]
        [InlineData(77, "lol", 77, 0)]
        [InlineData(7, "7", 7, 0)]
        public void Calculate_IfArgumentsNotRight(int val1, string operation, 
            int val2, int expected)
        {
            var res = Calculator.Calculate(val1, operation, val2);
            
            Assert.Equal(expected, res);
        }
    }
}