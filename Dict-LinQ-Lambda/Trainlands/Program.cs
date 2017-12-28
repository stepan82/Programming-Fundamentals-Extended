using System;
using System.Collections.Generic;
using System.Linq;

namespace Trainlands
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            var trainData = new Dictionary<string, Dictionary<string, long>>();

            while (input[0] != "It’s" && input[1] != "Training")
            {
                if (input.Length > 4)
                {
                    string train = input[0];
                    string wagon = input[2];
                    long power = long.Parse(input[4]);

                    if (!trainData.ContainsKey(train))
                    {
                        trainData[train] = new Dictionary<string, long>();
                    }

                    trainData[train].Add(wagon, power);
                }

                else if (input.Length < 4 && input[1] == "->")
                {
                    string train = input[0];
                    string otherTrain = input[2];

                    if (!trainData.ContainsKey(train))
                    {
                        trainData[train] = new Dictionary<string, long>();
                    }

                    foreach (var item in trainData)
                    {
                        if (item.Key == otherTrain)
                        {
                            foreach (var wagon in item.Value)
                            {
                                trainData[train].Add(wagon.Key, wagon.Value);
                            }
                        }
                    }

                    trainData.Remove(otherTrain);
                }

                else
                {
                    string train = input[0];
                    string otherTrain = input[2];

                    if (trainData.ContainsKey(train))
                    {
                        trainData.Remove(train);
                    }

                    trainData[train] = new Dictionary<string, long>();

                    foreach (var item in trainData)
                    {
                        if (item.Key == otherTrain)
                        {
                            foreach (var wagon in item.Value)
                            {
                                trainData[train].Add(wagon.Key, wagon.Value);
                            }
                        }
                    }
                }

                input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var machine in trainData.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(y => y.Value.Keys.Count()))
            {
                Console.WriteLine($"Train: {machine.Key}");

                foreach (var item in machine.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{item.Key} - {item.Value}");
                }
            }
        }
    }
}
