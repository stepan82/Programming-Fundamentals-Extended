using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConvertBaseNBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();

            BigInteger baseGiven = tokens[0];

            BigInteger number = tokens[1];

            var numberConvert = number.ToString().ToCharArray();

            Array.Reverse(numberConvert);

            string converted = new string(numberConvert);

            BigInteger result = 0;

            for (int i = 0; i < converted.Length; i++)
            {
                int digit = int.Parse(converted[i].ToString());
                result += digit * (BigInteger.Pow(baseGiven, i));
            }

            Console.WriteLine(result);
        }
    }
}
