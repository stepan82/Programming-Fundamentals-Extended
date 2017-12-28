using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {

            long wormLength = long.Parse(Console.ReadLine());

            decimal wormWidth = decimal.Parse(Console.ReadLine());

            long lengthInCm = wormLength * 100;

            

            if (wormWidth == 0)
            {
                decimal result = lengthInCm * wormWidth;
                Console.WriteLine($"{result:f2}");
            }
            else if (lengthInCm % wormWidth > 0)
            {
                decimal result = (lengthInCm / wormWidth) * 100;
                Console.WriteLine($"{result:f2}%");
            }
            else
            {
                decimal result = lengthInCm * wormWidth;
                Console.WriteLine($"{result:f2}");
            }
        }
    }
}
