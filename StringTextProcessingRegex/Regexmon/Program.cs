using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([a-zA-Z]+-[a-zA-Z]+)|([^a-zA-Z\-]+)";

            string text = Console.ReadLine();


            MatchCollection tokens = Regex.Matches(text, pattern);

            List<string> result = new List<string>();

            foreach (Match item in tokens)
            {
                result.Add(item.Value);
            }

            for (int i = 0; i < result.Count; i++)
            {
                if (!result[i].Contains('-') && i % 2 == 0)
                {
                    Console.WriteLine(result[i]);
                    
                }

                else if (result[i].Contains('-') && i % 2 != 0)
                {
                    Console.WriteLine(result[i]);                  
                }
            }

        }
    }
}
