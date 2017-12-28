using System;

namespace UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToCharArray();

            foreach (char letter in text)
            {
                string unicodeResult = "\\u" + ((int)letter).ToString("X4");

                Console.Write($"{unicodeResult.ToLower()}");
            }
            Console.WriteLine();
        }
    }
}
