using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WormIpsum
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^[A-Z][a-z]*(\s[A-Za-z]?[a-z]*)+\.$";

            string text = Console.ReadLine();

            while (text != "Worm Ipsum")
            {
                if (Regex.IsMatch(text, pattern))
                {

                }
            }
        }
    }
}
