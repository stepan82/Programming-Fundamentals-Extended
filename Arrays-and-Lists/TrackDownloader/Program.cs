using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            var blackList = Console.ReadLine().Split().ToArray();

            List<string> result = new List<string>();

            int contains = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                for (int i = 0; i < blackList.Length; i++)
                {
                    if (input.Contains(blackList[i]))
                    {
                        contains++;
                    }
                }

                if (contains == 0)
                {
                    result.Add(input);
                }

                contains = 0;
            }

            result.Sort();

            Console.WriteLine(string.Join("\r\n", result));
        }
    }
}
