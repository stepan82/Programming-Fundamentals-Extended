using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_N_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList().OrderByDescending(x => x);

            int numbersToTake = int.Parse(Console.ReadLine());

            var result = numbers.Take(numbersToTake).ToArray();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
