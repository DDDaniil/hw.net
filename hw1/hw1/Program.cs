using System;
using il;

namespace hw1
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Only two values");
                return 4;
            }

            var parserResult = ParserIL.TryToParse(args, out var arg1, out var arg2, out var op);

            if (parserResult != 0) return parserResult;

            var result = CalculatorIL.Calculate(args[1], arg1, arg2);

            Console.Write($"{arg1} {op} {arg2} = {result}");

            return 0;
        }
    }
}