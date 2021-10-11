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

        public static int TryToParse(string[] args, out int val1, out string operation, out int val2)
        {
            var isVal1Int = int.TryParse(args[0], out val1);
            operation = args[1];
            var isVal2Int = int.TryParse(args[2], out val2);

            if (!isVal1Int || !isVal2Int) //if there are no int args
            {
                Console.WriteLine($"{args[0]}{args[1]}{args[2]} is not a valid calculation syntax");
                return 1;
            }

            if (!ExpectedOperation.Contains(operation))
            {
                Console.WriteLine($"{args[0]} {args[1]} {args[2]} invalid arguments");
                return 2;
            }

            return 0;

        }
    }
}