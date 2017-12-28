using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().ToCharArray();
            
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n',
                'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for (int i = 0; i < tokens.Length; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if (tokens[i] == letters[j])
                    {
                        Console.WriteLine($"{tokens[i]} -> {j}");
                    }
                }
            }
        }
    }
}
