using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            long pokePower = long.Parse(Console.ReadLine());
            long pokeDistance = long.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int targetCounter = 0;
            long result = pokePower;
            while (result >= pokeDistance)
            {
                result -= pokeDistance;
                targetCounter++;
                if ((result / (double) pokePower) == 0.5 && exhaustionFactor != 0)
                {
                    result /= exhaustionFactor;
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine(result);
            Console.WriteLine(targetCounter);
        }
    }
}
