using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AnonymousVox
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternText = @"([a-zA-Z]+)(.+)\1";

            string patternPlaceholders = @"(?<=\{)(.+?)(?=\})";

            string text = Console.ReadLine();

            string placeholders = Console.ReadLine();

            List<string> substitWords = new List<string>();

            List<string> delWords = new List<string>();

            MatchCollection matchPlaceholders = Regex.Matches(placeholders, patternPlaceholders);

            MatchCollection matchText = Regex.Matches(text, patternText);

            foreach (Match item in matchPlaceholders)
            {
                substitWords.Add(item.Value);
            }

            foreach (Match item in matchText)
            {
                delWords.Add(item.Groups[2].Value);
            }

            int subsWords = substitWords.Count();
            int deletedWords = delWords.Count();

            if (subsWords >= deletedWords)
            {
                for (int i = 0; i < delWords.Count; i++)
                {
                    Regex MyRegex = new Regex(delWords[i]);
                    text= MyRegex.Replace(text, substitWords[i], 1);
                }
            }

            else if (deletedWords >= subsWords)
            {
                for (int i = 0; i < substitWords.Count; i++)
                {
                    Regex MyRegex = new Regex(delWords[i]);
                    text = MyRegex.Replace(text, substitWords[i], 1);
                }
            }

            Console.WriteLine(text);
        }
    }
}
