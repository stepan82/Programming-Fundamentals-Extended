using System;
using System.Collections.Generic;

namespace A_MinerTask
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var data = new Dictionary<string, long>();

            string currentKey = string.Empty; 

            while (input != "stop")
            {
                long quantity;
                if (long.TryParse(input, out quantity) == false)
                {
                    if (data.ContainsKey(input))
                    {
                        currentKey = input;
                    }
                    else
                    {
                        data[input] = 0;
                        currentKey = input;
                    }                   
                }

                else
                {
                    data[currentKey] += quantity;
                }

                input = Console.ReadLine();
            }

            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
