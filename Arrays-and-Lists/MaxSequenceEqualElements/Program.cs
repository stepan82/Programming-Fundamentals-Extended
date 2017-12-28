using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int currentStart = 0;

            int currentSequence = 1;

            int bestStart = 0;

            int bestSequence = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentSequence++;

                    if (currentSequence > bestSequence)
                    {
                        bestStart = currentStart;
                        bestSequence = currentSequence;
                    }
                }

                else
                {
                    currentStart = i;
                    currentSequence = 1;
                }
            }

            for (int i = bestStart; i < bestStart + bestSequence; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}
