using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int marathonDuration = int.Parse(Console.ReadLine());

            int runnersNumber = int.Parse(Console.ReadLine());

            int averageLaps = int.Parse(Console.ReadLine());

            int trackLength = int.Parse(Console.ReadLine());

            int trackCapacity = int.Parse(Console.ReadLine());

            decimal moneyPerKilometer = decimal.Parse(Console.ReadLine());

            long maxCapacity = marathonDuration * trackCapacity;

            if (maxCapacity >= runnersNumber)
            {
                BigInteger totalMeters = runnersNumber * averageLaps * trackLength;
                BigInteger totalKilom = totalMeters / 1000;
                decimal totalSum = moneyPerKilometer * (decimal)totalKilom;
                Console.WriteLine($"Money raised: {totalSum:F2}");
            }

            else
            {
                BigInteger totalMeters = maxCapacity * averageLaps * trackLength;
                BigInteger totalKilom = totalMeters / 1000;
                decimal totalSum = moneyPerKilometer * (decimal)totalKilom;
                Console.WriteLine($"Money raised: {totalSum:F2}");
            }
        }
    }
}
