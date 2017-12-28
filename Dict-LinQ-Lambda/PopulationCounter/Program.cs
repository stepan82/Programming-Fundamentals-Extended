using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            var statistic = new Dictionary<string, Dictionary<string, long>>();

            while (data[0] != "report")
            {
                string city = data[0];

                string country = data[1];

                long population = long.Parse(data[2]);

                if (!statistic.ContainsKey(country))
                {
                    statistic[country] = new Dictionary<string, long>();
                }

                if (!statistic[country].ContainsKey(city))
                {
                    statistic[country][city] = 0;
                }

                statistic[country][city] += population;

                data = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var country in statistic.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");

                foreach (var city in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
