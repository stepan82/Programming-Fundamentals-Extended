using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(?<loko><{1}\[{1}[^0-9a-zA-Z]*\]{1}\.{1})+(?<wagon>\.{1}\[{1}[a-zA-Z0-9]*\]{1}\.{1})*$";

            string input = Console.ReadLine();

            List<string> result = new List<string>();

            while (input != "Traincode!")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    result.Add(input);
                }

                input = Console.ReadLine();
            }

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
