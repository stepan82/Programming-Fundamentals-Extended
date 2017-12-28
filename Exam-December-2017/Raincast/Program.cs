using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            var printResult = new List<string>();

            while (tokens != "Davai Emo")
            {
                StringBuilder matchedRaincast = new StringBuilder();

                string patternType = @"^Type:\s(Danger|Normal|Warning)$";

                Match matchType = Regex.Match(tokens, patternType);

                while (matchType.Success == false)
                {
                    tokens = Console.ReadLine();
                    matchType = Regex.Match(tokens, patternType);
                }

                matchedRaincast.Append($"{matchType.Groups[1].Value}-");

                tokens = Console.ReadLine();

                string patternSource = @"^Source:\s([A-Za-z0-9]+)$";

                Match matchSource = Regex.Match(tokens, patternSource);

                while (matchSource.Success != true)
                {
                    tokens = Console.ReadLine();
                    matchSource = Regex.Match(tokens, patternSource);
                }

                matchedRaincast.Append($"{matchSource.Groups[1].Value}-");

                tokens = Console.ReadLine();

                string patternForecast = @"^(:?Forecast:\s)([^!.,?]+)$";
                Match matchForecast = Regex.Match(tokens, patternForecast);

                if (matchForecast.Success != true)
                {
                    tokens = Console.ReadLine();
                    matchForecast = Regex.Match(tokens, patternForecast);
                }

                matchedRaincast.Append($"{matchForecast.Groups[2].Value}-");

                result = matchedRaincast;

                printResult.Add(result.ToString());

                tokens = Console.ReadLine();
            }

            for (int i = 0; i < printResult.Count; i++)
            {
                var clear = printResult[i].Split('-').Select(x => x.Trim()).ToArray();

                Console.WriteLine($"({clear[0]}) {clear[2]} ~ {clear[1]}");
            }
        }
    }
}
