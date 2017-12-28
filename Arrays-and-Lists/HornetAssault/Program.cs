using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var hornets = Console.ReadLine().Split().Select(long.Parse).ToList();

            long power = hornets.Sum();

            for (int i = 0; i < beehives.Length; i++)
            {
                if (beehives[i] < power)
                {
                    beehives[i] = 0;
                }

                else
                {
                    beehives[i] = beehives[i] - power;
                    power -= hornets[0];
                    hornets.RemoveAt(0);
                }

                if (hornets.Sum() == 0)
                {
                    break;
                }
            }

            if (beehives.Sum() > 0)
            {
                foreach (var item in beehives)
                {
                    if (item > 0)
                    {
                        Console.Write($"{item} ");
                    }
                }
            }

            else
            {
                foreach (var item in hornets)
                {
                    Console.Write($"{item} ");
                }
            }
        }
    }
}
