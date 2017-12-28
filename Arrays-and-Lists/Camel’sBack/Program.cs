using System;

using System.Linq;

namespace Camel_sBack
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            int camelBack = int.Parse(Console.ReadLine());

            int inputLength = input.Count();

            int roundsNumber = (inputLength - camelBack) / 2;

            if (inputLength == camelBack)
            {
                Console.WriteLine($"already stable: {string.Join(" ", input)}");
            }

            else
            {
                Console.WriteLine($"{roundsNumber} rounds");

                Console.Write("remaining: ");

                for (int i = roundsNumber; i < input.Count - roundsNumber; i++)
                {
                    Console.Write($"{input[i]} ");
                }

                Console.WriteLine();
            }          
        }
    }
}
