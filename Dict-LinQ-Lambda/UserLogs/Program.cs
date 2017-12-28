using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace UserLogs
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var usersData = new Dictionary<string, Dictionary<string, List<int>>>();

            while (input != "end")
            {
                string patternUser = @"\b(?<=user=).+?\b";

                Match user = Regex.Match(input, patternUser);
           
                string patternIP = @"(?<=IP=).+?(?=\s)\b";

                Match ip = Regex.Match(input, patternIP);

                if (user.Success && ip.Success)
                {
                    if (!usersData.ContainsKey(user.Value))
                    {
                        usersData[user.Value] = new Dictionary<string, List<int>>();
                    }

                    if (!usersData[user.Value].ContainsKey(ip.Value))
                    {
                        usersData[user.Value][ip.Value] = new List<int>();
                    }

                    usersData[user.Value][ip.Value].Add(1);
                }

                input = Console.ReadLine();
            }

            foreach (var user in usersData.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key}: ");

                foreach (var logs in user.Value)
                {
                    if (logs.Key != user.Value.Keys.Last())
                    {
                        Console.Write($"{logs.Key} => {logs.Value.Sum()}, ");
                    }

                    else
                    {
                        Console.WriteLine($"{logs.Key} => {logs.Value.Sum()}.");
                    }
                    
                }
            }
        }
    }
}
