using System;
using System.Collections.Generic;

namespace CitiesContinentCountry
{
    class Program
    {
        static void Main()
        {
            int continentsCount = int.Parse(Console.ReadLine());

            var atlasData = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < continentsCount; i++)
            {
                var tokens = Console.ReadLine().Split();
                string continent = tokens[0];
                string country = tokens[1];
                string city = tokens[2];

                if (!atlasData.ContainsKey(continent))
                {
                    atlasData[continent] = new Dictionary<string, List<string>>();
                }

                if (!atlasData[continent].ContainsKey(country))
                {
                    atlasData[continent][country] = new List<string>();
                }

                atlasData[continent][country].Add(city);
            }

            foreach (var continent in atlasData)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var country in continent.Value)
                {
                    Console.Write($" {country.Key} -> ");
                    Console.WriteLine(string.Join(", ", country.Value));
                }
            }
        }
    }
}
