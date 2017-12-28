using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HornetComm
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternPrMessage = @"^([0-9]+) \<\-\> ([a-zA-Z0-9]+)$";

            string patternBroadcast = @"^([^0-9]+) \<\-\> ([a-zA-Z0-9]+)$";

            Regex messageRegex = new Regex(patternPrMessage);
            Regex broadcastRegex = new Regex(patternBroadcast);

            string input = Console.ReadLine();

            List<string> messages = new List<string>();

            List<string> broadcast = new List<string>();

            while (input != "Hornet is Green")
            {
                if (Regex.IsMatch(input, patternPrMessage))
                {
                    Match match = messageRegex.Match(input);
                    var leftPart = match.Groups[1].Value.ToCharArray();
                    var rightPart = match.Groups[2].Value;
                    Array.Reverse(leftPart);
                    string reversedBroadcast = new string(leftPart);
                    string result = $"{reversedBroadcast} -> {rightPart}";
                    messages.Add(result);
                }

                if (Regex.IsMatch(input, patternBroadcast))
                {
                    Match match = broadcastRegex.Match(input);
                    string messag = match.Groups[1].Value;
                    string frequency = match.Groups[2].Value;

                    StringBuilder casingChanged = new StringBuilder();

                    for (int i = 0; i < frequency.Length; i++)
                    {
                        if (frequency[i] >= 97 && frequency[i] <= 122)
                        {
                            char c = Convert.ToChar(frequency[i] - 32);
                            casingChanged.Append(c);
                        }

                        else if (frequency[i] >= 65 && frequency[i] <= 90)
                        {
                            char c = Convert.ToChar(frequency[i] + 32);
                            casingChanged.Append(c);
                        }
                        else
                        {
                            casingChanged.Append(frequency[i]);
                        }
                    }

                    string converted = casingChanged.ToString();

                    string result = $"{converted} -> {messag}";

                    broadcast.Add(result);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (broadcast.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                for (int i = 0; i < broadcast.Count; i++)
                {
                    Console.WriteLine(broadcast[i]);
                }
            }

            Console.WriteLine("Messages:");

            if (messages.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                for (int i = 0; i < messages.Count; i++)
                {
                    Console.WriteLine(messages[i]);
                }
            }
        }
    }
}
