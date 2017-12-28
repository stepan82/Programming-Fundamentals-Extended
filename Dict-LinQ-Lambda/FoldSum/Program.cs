using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

            var left = numbers.Take(numbers.Count / 4).Reverse().ToArray();
            var right = numbers.Skip(numbers.Count - numbers.Count / 4).Reverse().ToArray();

            for (int i = numbers.Count / 4; i < numbers.Count - numbers.Count / 4; i++)
            {
                result.Add(numbers[i]);
            }

            for (int i = 0; i < numbers.Count / 4; i++)
            {
                result[i] += left[i];
            }

            for (int i = 0; i < right.Length; i++)
            {
                result[numbers.Count / 4 + i] += right[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
