using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            int total = 0;
            foreach (var item in input)
            {
                var charArray = item.ToCharArray();
                Array.Reverse(charArray);
                string result = new string(charArray);
                int number = int.Parse(result);
                total += number;
            }

            Console.WriteLine(total);
        }
    }
}
