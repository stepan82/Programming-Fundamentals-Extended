using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PhoenixGrid
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^[^\s_]{3}(\.[^\s_]{3})*$";

            string input = Console.ReadLine();

            while (input != "ReadMe")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    var inputChar = input.ToCharArray();
                    Array.Reverse(inputChar);
                    string reversed = new string(inputChar);

                    if (reversed == input)
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }

                else
                {
                    Console.WriteLine("NO");
                }

                input = Console.ReadLine();
            }
        }
    }
}
