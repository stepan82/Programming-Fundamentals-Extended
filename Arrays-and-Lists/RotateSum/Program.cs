using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rotations = int.Parse(Console.ReadLine());

            int[] result = new int[input.Length];

            for (int i = 0; i < rotations; i++)
            {
                int current = input[input.Length - 1];
                for (int j = input.Length - 1; j >= 1; j--)
                {
                    input[j] = input[j - 1];
                }
                input[0] = current;

                for (int r = 0; r < result.Length; r++)
                {
                    result[r] += input[r];
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
