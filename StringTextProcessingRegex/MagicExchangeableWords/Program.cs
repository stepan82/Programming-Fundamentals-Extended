using System;
using System.Linq;

namespace MagicExchangeableWords
{
    class Program
    {
        static void Main()
        {
            var words = Console.ReadLine().Split();

            var firstWord = words[0].ToCharArray().Distinct().ToArray();

            var secondWord = words[1].ToCharArray().Distinct().ToArray();

            if (firstWord.Length == secondWord.Length)
            {
                Console.WriteLine("true");
            }

            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
