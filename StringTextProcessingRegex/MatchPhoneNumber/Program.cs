using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main()
        {
            string pattern = @"[+]{1}359([ |-])2(\1)[0-9]{3}(\1)[0-9]{4}\b";

            string phoneNumbers = Console.ReadLine();

            MatchCollection matchedNumbers = Regex.Matches(phoneNumbers, pattern);

            Console.WriteLine(string.Join(", ", matchedNumbers.Cast<Match>()));
        }
    }
}
