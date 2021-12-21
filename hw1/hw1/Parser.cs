using System;
using System.Collections;
using System.Linq;

namespace hw1
{
    public static class Parser
    {
        private static readonly string[] ExpectedOperation = new[]
        {
            "+",
            "-",
            "*",
            $"/"
        };

        public static int TryToParse(string[] args, out double val1, out string operation, out double val2)
        {
            var isVal1Dbl = double.TryParse(args[0], out val1);
            operation = args[1];
            var isVal2Dbl = double.TryParse(args[2], out val2);

            if (!isVal1Dbl || !isVal2Dbl) 
            {
                Console.WriteLine($"{args[0]}{args[1]}{args[2]} is not a valid calculation syntax");
                return 1;
            }

            if (!ExpectedOperation.Contains(operation))
            {
                Console.WriteLine($"{args[0]} {args[1]} {args[2]} invalid arguments");
                return 2;
            }
            
            if (args[1] == "/" && args[2] == "0")
            {
                Console.WriteLine($"{args[0]}{args[1]}{args[2]} - cannot be divided by zero");
                return 3;
            }

            return 0;

        }
    }
}