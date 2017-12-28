using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchHexadecimalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(0x)?[0-9A-F]+\b";

            string text = Console.ReadLine();

            var matchedNumbers = Regex.Matches(text, pattern);

            var result = matchedNumbers.Cast<Match>().Select(x => x.Value.TrimEnd()).ToArray();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
