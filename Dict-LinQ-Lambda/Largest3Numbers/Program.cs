using System;
using System.Linq;

namespace Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var reversed = input.OrderByDescending(x => x).Take(3).ToArray();

            Console.WriteLine(string.Join(" ", reversed));
        }
    }
}
