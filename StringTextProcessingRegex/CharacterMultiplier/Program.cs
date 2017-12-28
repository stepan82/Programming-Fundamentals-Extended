using System;
using System.Linq;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();

            string first = input[0];
            string second = input[1];
            int result = 0;

            if (first.Length == second.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    result += first[i] * second[i];
                }
            }

            else
            {
                string max = input.OrderByDescending(s => s.Length).First();
                string min = input.OrderBy(s => s.Length).First();

                for (int i = 0; i < max.Length; i++)
                {
                    if (i > min.Length - 1)
                    {
                        result += max[i];
                    }
                    else
                    {
                        result += min[i] * max[i];
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
