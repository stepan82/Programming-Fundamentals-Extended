using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splinter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal tripDistance = decimal.Parse(Console.ReadLine());

            decimal fuelCapacity = decimal.Parse(Console.ReadLine());

            decimal milesHeavyWinds = decimal.Parse(Console.ReadLine());

            decimal milesNonHeavyWinds = tripDistance - milesHeavyWinds;

            decimal nonHeavyWindsConsum = milesNonHeavyWinds * 25;

            decimal heavyWindsConsum = milesHeavyWinds * (25 * 1.5M);

            decimal fuelConsum = heavyWindsConsum + nonHeavyWindsConsum;

            decimal tollerance = fuelConsum * 0.05M;

            decimal totalFuel = fuelConsum + tollerance;

            if (fuelCapacity >= totalFuel)
            {
                Console.WriteLine($"Fuel needed: {totalFuel:F2}L");
                Console.WriteLine($"Enough with {(fuelCapacity - totalFuel):F2}L to spare!");
            }

            else
            {
                Console.WriteLine($"Fuel needed: {totalFuel:F2}L");
                Console.WriteLine($"We need {(totalFuel - fuelCapacity):F2}L more fuel.");
            }
        }
    }
}
