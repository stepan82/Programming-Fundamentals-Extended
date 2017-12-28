using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExtractSentencesKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyWord = Console.ReadLine();

            string text = Console.ReadLine();

            string pattern = $@"\b[^?.!]*\b{keyWord}\b[^?.!]*";

            foreach (Match m in Regex.Matches(text, pattern))
            {
                Console.WriteLine(m.Value.TrimStart());
            }
        }
    }
}
