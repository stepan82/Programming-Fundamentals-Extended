using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ConvertBase10BaseN
{
    class Program
    {
        static void Main()
        {
            var tokens = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();

            BigInteger baseNumber = tokens[0];

            BigInteger number = tokens[1];

            List<BigInteger> result = new List<BigInteger>(); 

            while (number > 0)
            {
                BigInteger calculation = number % baseNumber;
                result.Add(calculation);
                BigInteger nextNumber = number / baseNumber;
                number = nextNumber;
            }

            result.Reverse();

            Console.WriteLine(string.Join("", result));
        }      
    }
}
