using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());

            var records = new Dictionary<string, SortedDictionary<string, long>>();

            for (int i = 0; i < linesCount; i++)
            {
                var data = Console.ReadLine().Split();

                string ipAddress = data[0];

                string user = data[1];

                long duration = long.Parse(data[2]);

                if (!records.ContainsKey(user))
                {
                    records[user] = new SortedDictionary<string, long>();
                }

                if (!records[user].ContainsKey(ipAddress))
                {
                    records[user][ipAddress] = 0;
                }

                records[user][ipAddress] += duration;
            }

            foreach (var user in records.OrderBy(x => x.Key))
            {
                Console.Write($"{user.Key}: ");

                Console.Write($"{user.Value.Values.Sum()} [");

                foreach (var item in user.Value.OrderBy(y => y.Key))
                {
                    if (item.Key != user.Value.Keys.Last())
                    {
                        Console.Write($"{item.Key}, ");
                    }

                    else
                    {
                        Console.Write($"{item.Key}");
                    }
                }

                Console.WriteLine("]");
            }
        }
    }
}
