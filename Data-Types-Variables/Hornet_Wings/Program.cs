using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            decimal distancePer_1000 = decimal.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            decimal distance = (wingFlaps / 1000) * distancePer_1000;
            long time = (wingFlaps / 100);
            decimal timePlus = (wingFlaps / endurance) * 5;
            decimal totalTime = time + timePlus;

            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine($"{totalTime} s.");
        }
    }
}
