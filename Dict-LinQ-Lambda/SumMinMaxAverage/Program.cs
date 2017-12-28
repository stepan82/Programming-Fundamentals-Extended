using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMinMaxAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            int[] arrayNumbers = new int[numbersCount];

            for (int i = 0; i < numbersCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                arrayNumbers[i] = number;
            }

            int totalSum = arrayNumbers.Sum();
            int min = arrayNumbers.Min();
            int max = arrayNumbers.Max();
            double average = arrayNumbers.Average();

            Console.WriteLine($"Sum = {totalSum}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Average = {average}");

        }
    }
}
