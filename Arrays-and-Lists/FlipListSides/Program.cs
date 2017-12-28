using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipListSides
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();

            Array.Reverse(input, 1, (input.Length - 2) - 1 + 1);

            Console.WriteLine(string.Join(" ", input));
        }       
    }
}
