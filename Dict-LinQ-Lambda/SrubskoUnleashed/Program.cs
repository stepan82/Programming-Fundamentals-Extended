using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SrubskoUnleashed
{
    class Program
    {
        static void Main()
        {
            string pattern = @"\b(?<singer>[A-Za-z]+(\s[A-Za-z]+)*)\s@(?<place>[A-Za-z]+(\s[A-Za-z]+)*)\s(?<price>[0-9]+)\s(?<count>[0-9]+)\b";

            string data = Console.ReadLine();

            var concertInfo = new Dictionary<string, Dictionary<string, int>>();

            while (data != "End")
            {
                MatchCollection concertData = Regex.Matches(data, pattern);

                foreach (Match item in concertData)
                {
                    string place = item.Groups["place"].Value;

                    string singer = item.Groups["singer"].Value;

                    int income = int.Parse(item.Groups["price"].Value) * int.Parse(item.Groups["count"].Value);

                    if (!concertInfo.ContainsKey(place))
                    {
                        concertInfo[place] = new Dictionary<string, int>();
                    }

                    if (!concertInfo[place].ContainsKey(singer))
                    {
                        concertInfo[place][singer] = 0;
                    }

                    concertInfo[place][singer] += income;
                }

                data = Console.ReadLine();
            }

            foreach (var venue in concertInfo)
            {
                Console.WriteLine(venue.Key);

                foreach (var singer in venue.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
