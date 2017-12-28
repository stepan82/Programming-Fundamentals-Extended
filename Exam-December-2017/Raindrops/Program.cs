using System;
using System.Linq;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int regionsCount = int.Parse(Console.ReadLine());

            decimal density = decimal.Parse(Console.ReadLine());

            decimal totalQ = 0.0M;

            for (int i = 0; i < regionsCount; i++)
            {
                var tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

                long dropsCount = tokens[0];

                long sqMeters = tokens[1];

                totalQ += dropsCount / (decimal)sqMeters;
            }

            if (density == 0.0M)
            {
                Console.WriteLine($"{totalQ:F3}");
            }

            else
            {
                decimal result = totalQ / density;

                Console.WriteLine($"{result:F3}");
            }
        }
    }
}
