using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CenturiesNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int toYears = centuries * 100;
            decimal toDays = Math.Floor(toYears * 365.2422M);
            int toHours = (int)toDays * 24;
            BigInteger toMinutes = 60 * toHours;
            BigInteger toSeconds = toMinutes * 60;
            BigInteger toMilliseconds = toSeconds * 1000;
            BigInteger toMicroseconds = toMilliseconds * 1000;
            BigInteger toNanoseconds = toMicroseconds * 1000;

            Console.WriteLine($"{centuries} centuries = {toYears} years = {toDays} days = {toHours} hours = " +
                $"{toMinutes} minutes = {toSeconds} seconds = {toMilliseconds} milliseconds = {toMicroseconds} microseconds = {toNanoseconds} nanoseconds");
        }
    }
}
