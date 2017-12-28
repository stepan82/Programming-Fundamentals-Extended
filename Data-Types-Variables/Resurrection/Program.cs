using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            int phoenixCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < phoenixCount; i++)
            {
                long bodyLength = long.Parse(Console.ReadLine());
                decimal bodyWidth = decimal.Parse(Console.ReadLine());
                long wingLength = long.Parse(Console.ReadLine());

                var afterDeciaml = bodyWidth.ToString().Split('.').ToArray();
             
                if (afterDeciaml.Length == 1)
                {
                    decimal totalYears = (bodyLength * bodyLength) * (bodyWidth + (2 * wingLength));
                    Console.WriteLine($"{totalYears:F0}");
                }

                else
                {
                    int numbers = afterDeciaml[1].ToCharArray().Count();
                    decimal totalYears = (bodyLength * bodyLength) * (bodyWidth + (2 * wingLength));
                    Console.WriteLine($"{Math.Round(totalYears, numbers)}");
                }                        
            }
        }
    }
}
