using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousCache
{
    class Program
    {
        static void Main()
        {
            var tokens = Console.ReadLine().Split(new char[] { '-', '>', ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);

            var dataSetInfo = new Dictionary<string, Dictionary<string, long>>();

            var cachedDataSet = new Dictionary<string, Dictionary<string, long>>();

            while (tokens[0] != "thetinggoesskrra")
            {
                if (tokens.Length == 1)
                {
                    string dataSet = tokens[0];

                    if (!dataSetInfo.ContainsKey(dataSet))
                    {
                        dataSetInfo[dataSet] = new Dictionary<string, long>();

                        if (cachedDataSet.ContainsKey(dataSet))
                        {
                            foreach (var item in cachedDataSet)
                            {
                                if (item.Key == dataSet)
                                {
                                    foreach (var values in item.Value)
                                    {
                                        dataSetInfo[dataSet].Add(values.Key, values.Value);
                                    }
                                }
                            }
                        }
                    }
                }

                else
                {
                    string dataKey = tokens[0];
                    long dataSize = long.Parse(tokens[1]);
                    string dataSet = tokens[2];

                    if (dataSetInfo.ContainsKey(dataSet))
                    {
                        dataSetInfo[dataSet].Add(dataKey, dataSize);
                    }

                    else
                    {
                        if (!cachedDataSet.ContainsKey(dataSet))
                        {
                            cachedDataSet[dataSet] = new Dictionary<string, long>();
                        }

                        cachedDataSet[dataSet].Add(dataKey, dataSize);
                    }
                }

                tokens = Console.ReadLine().Split(new char[] { '-', '>', ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var data in dataSetInfo.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"Data Set: {data.Key}, Total Size: {data.Value.Values.Sum()}");

                foreach (var value in data.Value)
                {
                    Console.WriteLine($"$.{value.Key}");
                }

                break;
            }
        }
    }
}
