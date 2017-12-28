using System;
using System.Collections.Generic;
using System.Linq;

namespace Hornet_Armada
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            var activities = new SortedDictionary<string, long>();

            var legions = new Dictionary<string, SortedDictionary<string, long>>();

            for (int i = 0; i < lines; i++)
            {
                var tokens = Console.ReadLine()
                    .Split(new char[] { ' ', '-', '>', ':', '=' }, StringSplitOptions.RemoveEmptyEntries);

                long lastActivity = long.Parse(tokens[0]);
                string legionName = tokens[1];
                string soldierType = tokens[2];
                long soldierCount = long.Parse(tokens[3]);

                if (!legions.ContainsKey(legionName) && !activities.ContainsKey(legionName))
                {
                    legions[legionName] = new SortedDictionary<string, long>();
                    legions[legionName].Add(soldierType, soldierCount);
                    activities[legionName] = lastActivity;
                }

                else if (legions.ContainsKey(legionName) && activities.ContainsKey(legionName))
                {
                    if (!legions[legionName].ContainsKey(soldierType))
                    {
                        legions[legionName][soldierType] = soldierCount;
                    }

                    else
                    {
                        legions[legionName][soldierType] += soldierCount;
                    }

                    if (lastActivity > activities[legionName])
                    {
                        activities[legionName] = lastActivity;
                    }
                }
            }

            var command = Console.ReadLine()
                    .Split(new char[] { ' ', '\\' }, StringSplitOptions.RemoveEmptyEntries);

            if (command.Length == 1)
            {
                string soldierType = command[0];

                foreach (var legion in activities.OrderByDescending(x => x.Value))
                {
                    foreach (var item in legions.Where(x => x.Value.ContainsKey(soldierType)))
                    {
                        if (legion.Key == item.Key)
                        {
                            Console.WriteLine($"{legion.Value} : {legion.Key}");
                        }
                    }
                }
            }

            else
            {
                long activity = long.Parse(command[0]);

                string soldierType = command[1];

                foreach (var legion in legions.Where(l => l.Value.ContainsKey(soldierType))
                    .OrderByDescending(l => l.Value[soldierType]))
                {
                    if (activities[legion.Key] < activity)
                    {
                        Console.WriteLine($"{legion.Key} -> {legion.Value[soldierType]}");
                    }
                }
            }
        }
    }
}


