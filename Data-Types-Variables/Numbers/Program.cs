using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray().OrderByDescending(c => c).ToArray();

            double average = numbers.Average();
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (count == 5)
                {
                    break;
                }
                if (numbers[i] > average)
                {
                    Console.Write($"{numbers[i]} ");
                    count++;
                }
            }
            
            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
