using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceMeters = float.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            int secondsTotal = seconds + (minutes * 60) + (hours * 3600);
            float kilometers = distanceMeters / 1000F;
            float miles = distanceMeters / 1609F;
            float speedMetersSeconds = distanceMeters / (seconds + (minutes * 60) + (hours * 3600));
            float speedKmHours = kilometers / (secondsTotal / 3600.0F);
            float speedMilesHours = miles / (secondsTotal / 3600.0F);

            Console.WriteLine(speedMetersSeconds);
            Console.WriteLine(speedKmHours);
            Console.WriteLine(speedMilesHours);
        }
    }
}
