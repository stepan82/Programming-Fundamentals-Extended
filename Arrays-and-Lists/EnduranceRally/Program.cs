using System;
using System.Linq;

namespace EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            var drivers = Console.ReadLine().Split();
            var track = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var checkPoints = Console.ReadLine().Split().Select(long.Parse).ToArray();

            for (int i = 0; i < drivers.Length; i++)
            {
                char letter = drivers[i].ToCharArray().First();
                double fuel = Convert.ToInt32(letter);

                for (int k = 0; k < track.Length; k++)
                {
                    if (checkPoints.Contains(k))
                    {
                        fuel += track[k];
                    }

                    else
                    {
                        fuel -= track[k];
                    }

                    if (fuel <= 0)
                    {
                        Console.WriteLine($"{drivers[i]} - reached {k}");
                        break;
                    }
                }

                if (fuel > 0)
                {
                    Console.WriteLine($"{drivers[i]} - fuel left {fuel:F2}");
                }            
            }
        }
    }
}
