using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();

            string matchWord = Console.ReadLine().ToLower();

            int count = 0;

            int index = text.IndexOf(matchWord);

            while (index != -1)
            {
                count++;
                index = text.IndexOf(matchWord, index + 1);
            }

            Console.WriteLine(count);
        }
    }
}
