using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PairsDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int difference = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    bool isEqual = Math.Abs(numbers[i] - numbers[j]) == difference;
                    if (isEqual)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
