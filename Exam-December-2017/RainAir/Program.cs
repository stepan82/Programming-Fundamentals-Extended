using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine();
            var flightsData = new Dictionary<string, List<long>>();

            while (tokens != "I believe I can fly!")
            {
                var splitedTokens = tokens.Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);

                string text = splitedTokens[1];
                long num2;

                if (long.TryParse(text, out num2) == true)
                {
                    string customerName = splitedTokens[0];

                    if (!flightsData.ContainsKey(customerName))
                    {
                        flightsData[customerName] = new List<long>();

                        for (int i = 1; i < splitedTokens.Length; i++)
                        {
                            flightsData[customerName].Add(long.Parse(splitedTokens[i]));
                        }
                    }

                    else
                    {
                        for (int i = 1; i < splitedTokens.Length; i++)
                        {
                            flightsData[customerName].Add(long.Parse(splitedTokens[i]));
                        }
                    }                  
                }

                else
                {
                    string customerName = splitedTokens[0];
                    string customer2Name = splitedTokens[1];

                    flightsData[customerName].Clear();

                    for (int i = 0; i < flightsData[customer2Name].Count(); i++)
                    {
                        flightsData[customerName].Add(flightsData[customer2Name][i]);
                    }
                }

                tokens = Console.ReadLine();
            }

            foreach (var flight in flightsData.OrderByDescending(x => x.Value.Count()).ThenBy(y => y.Key))
            {
                Console.Write($"#{flight.Key} ::: ");

                var ordered = flight.Value.OrderBy(x => x).ToList();

                Console.WriteLine(string.Join(", ", ordered));
            }
        }
    }
}
