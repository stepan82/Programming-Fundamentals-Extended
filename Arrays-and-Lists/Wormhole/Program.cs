using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wormhole
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int steps = 0;

            for (int i = 0; i < input.Length; i++)
            {
                steps++;

                if (input[i] != 0)
                {
                    int current = input[i];
                    input[i] = 0;
                    i = current;
                    
                }
            }

            Console.WriteLine(steps);
        }
    }
}
