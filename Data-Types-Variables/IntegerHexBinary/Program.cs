using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerHexBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string toHexa = Convert.ToString(input, 16).ToUpper();
            string toBinary = Convert.ToString(input, 2).ToUpper();

            Console.WriteLine(toHexa);
            Console.WriteLine(toBinary);
        }
    }
}
