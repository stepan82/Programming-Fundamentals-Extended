using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {

            string timeStart = Console.ReadLine();
            DateTime time = DateTime.Parse(timeStart);

            double steps = double.Parse(Console.ReadLine());
            double secondsPerStep = double.Parse(Console.ReadLine());

            BigInteger totalTime = ((BigInteger)(steps * secondsPerStep)) % 86400;
            DateTime result = time.AddSeconds((int)totalTime);
            Console.WriteLine($"Time Arrival: {result:HH:mm:ss}");
        }
    }
}