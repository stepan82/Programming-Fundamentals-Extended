using System;
using System.Collections.Generic;

namespace OddOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split();

            var wordsOccurance = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!wordsOccurance.ContainsKey(word))
                {
                    wordsOccurance[word] = 0;
                }

                wordsOccurance[word]++;
            }

            List<string> result = new List<string>();

            foreach (var item in wordsOccurance)
            {
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
