using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y', 'w' };
            char[] digits = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            if (vowels.Contains(input))
            {
                Console.WriteLine("vowel");
            }
            else if (digits.Contains(input))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
