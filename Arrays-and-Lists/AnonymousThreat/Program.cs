using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();

            while (true)
            {
                var commands = Console.ReadLine().Split(' ').ToArray();

                if (commands[0] == "3:1")
                {
                    break;
                }

                switch (commands[0])
                {
                    case "merge":

                        int startIndex = int.Parse(commands[1]);
                        int endIndex = int.Parse(commands[2]);
                        if (startIndex < 0 || startIndex > input.Count - 1)
                        {
                            startIndex = 0;
                        }

                        if (endIndex > input.Count - 1)
                        {
                            endIndex = input.Count - 1;
                        }

                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            if (i == startIndex)
                            {
                                continue;
                            }
                            input[startIndex] += input[i];
                        }

                        for (int i = endIndex; i >= startIndex + 1; i--)
                        {
                            if (i == startIndex)
                            {
                                continue;
                            }
                            input.RemoveAt(i);
                        }
                        break;


                    case "divide":
                        int index = int.Parse(commands[1]);

                        int partitions = int.Parse(commands[2]);

                        int charCount = input[index].Count();


                        if (charCount % partitions == 0)
                        {
                            int part = charCount / partitions;

                            List<string> currentString = new List<string>();

                            for (int i = 0; i < input[index].Length; i += part)
                            {
                                string result = input[index].Substring(i, part);
                                currentString.Add(result);
                            }

                            input.RemoveAt(index);

                            input.InsertRange(index, currentString);
                        }

                        else
                        {
                            int part = charCount / partitions;

                            int length = part * (partitions - 1);

                            List<string> currentString = new List<string>();

                            for (int i = 0; i < length; i += part)
                            {
                                string result = input[index].Substring(i, part);
                                currentString.Add(result);
                            }

                            string lastElement = input[index].Substring(length, input[index].Length - length);
                            currentString.Add(lastElement);

                            input.RemoveAt(index);

                            input.InsertRange(index, currentString);
                        }

                        break;
                }

            }

            Console.WriteLine(string.Join(" ", input));

        }
    }
}
