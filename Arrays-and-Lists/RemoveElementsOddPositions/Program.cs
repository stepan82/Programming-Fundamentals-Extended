using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElementsOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();

            List<string> result = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 != 0)
                {
                    result.Add(input[i]);
                }
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
