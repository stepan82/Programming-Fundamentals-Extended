using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            var commands = Console.ReadLine().Split().ToArray();

            while (commands[0] != "print")
            {
                switch (commands[0])
                {
                    case "add":
                        int index = int.Parse(commands[1]);
                        int element = int.Parse(commands[2]);
                        input.Insert(index, element);
                        break;

                    case "addMany":
                        int indexMany = int.Parse(commands[1]);
                        for (int i = commands.Length-1; i >= 2; i--)
                        {
                            input.Insert(indexMany, int.Parse(commands[i]));
                        }
                        break;

                    case "contains":
                        int elementContains = int.Parse(commands[1]);
                        int count = 0;
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i] == elementContains)
                            {
                                Console.WriteLine(i);
                                count++;
                                break;
                            }                    
                        }

                        if (count == 0)
                        {
                            Console.WriteLine(-1);
                        }
                        break;

                    case "remove":
                        int indexRemove = int.Parse(commands[1]);
                        input.RemoveAt(indexRemove);
                        break;

                    case "shift":
                        int positions = int.Parse(commands[1]);
                        for (int i = 0; i < positions; i++)
                        {
                            int current = input[0];
                            for (int j = 0; j < input.Count-1; j++)
                            {
                                input[j] = input[j + 1];
                            }
                            input[input.Count - 1] = current;
                        }
                        break;

                    case "sumPairs":
                        if (input.Count % 2 == 0)
                        {
                            for (int i = input.Count - 1; i >= 0; i -= 2)
                            {
                                input[i] += input[i - 1];
                                input.RemoveAt(i - 1);
                            }
                        }
                        else
                        {
                            for (int i = input.Count - 2; i >= 0; i -= 2)
                            {
                                input[i] += input[i - 1];
                                input.RemoveAt(i - 1);
                            }
                        }
                       
                        break;
                }

                commands = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine($"[{string.Join(", ", input)}]");
        }
    }
}
