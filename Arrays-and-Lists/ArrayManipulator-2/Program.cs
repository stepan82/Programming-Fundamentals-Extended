using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            var commands = Console.ReadLine().Split();

            while (commands[0] != "end")
            {
                switch (commands[0])
                {
                    case "exchange":

                        int splitIndex = int.Parse(commands[1]);

                        if (splitIndex < 0 || splitIndex >= input.Count)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }

                        for (int i = 0; i <= splitIndex; i++)
                        {
                            input.Add(input[i]);
                        }

                        input.RemoveRange(0, splitIndex + 1);
                        break;

                    case "max":

                        if (commands[1] == "odd")
                        {
                            int maxOdd = int.MinValue;
                            int rightMostIndex = 0;

                            for (int i = 0; i < input.Count; i++)
                            {
                                if (input[i] % 2 != 0 && input[i] == maxOdd && i > rightMostIndex)
                                {
                                    maxOdd = input[i];
                                    rightMostIndex = i;
                                }

                                else if (input[i] % 2 != 0 && input[i] > maxOdd)
                                {
                                    maxOdd = input[i];
                                    rightMostIndex = i;
                                }
                            }

                            if (maxOdd == int.MinValue)
                            {
                                Console.WriteLine("No matches");
                            }

                            else
                            {
                                Console.WriteLine(rightMostIndex);
                            }
                        }

                        else
                        {
                            int maxEven = int.MinValue;
                            int rightMostIndex = 0;

                            for (int i = 0; i < input.Count; i++)
                            {
                                if (input[i] % 2 == 0 && input[i] == maxEven && i > rightMostIndex)
                                {
                                    maxEven = input[i];
                                    rightMostIndex = i;
                                }

                                else if (input[i] % 2 == 0 && input[i] > maxEven)
                                {
                                    maxEven = input[i];
                                    rightMostIndex = i;
                                }
                            }

                            if (maxEven == int.MinValue)
                            {
                                Console.WriteLine("No matches");
                            }

                            else
                            {
                                Console.WriteLine(rightMostIndex);
                            }
                        }
                        break;

                    case "min":
                        if (commands[1] == "odd")
                        {
                            int minOdd = int.MaxValue;
                            int rightMostIndex = 0;

                            for (int i = 0; i < input.Count; i++)
                            {
                                if (input[i] % 2 != 0 && input[i] == minOdd && i > rightMostIndex)
                                {
                                    minOdd = input[i];
                                    rightMostIndex = i;
                                }

                                else if (input[i] % 2 != 0 && input[i] < minOdd)
                                {
                                    minOdd = input[i];
                                    rightMostIndex = i;
                                }
                            }

                            if (minOdd == int.MaxValue)
                            {
                                Console.WriteLine("No matches");
                            }

                            else
                            {
                                Console.WriteLine(rightMostIndex);
                            }
                        }

                        else
                        {
                            int minEven = int.MaxValue;
                            int rightMostIndex = 0;

                            for (int i = 0; i < input.Count; i++)
                            {
                                if (input[i] % 2 == 0 && input[i] == minEven && i > rightMostIndex)
                                {
                                    minEven = input[i];
                                    rightMostIndex = i;
                                }

                                else if (input[i] % 2 == 0 && input[i] < minEven)
                                {
                                    minEven = input[i];
                                    rightMostIndex = i;
                                }
                            }

                            if (minEven == int.MaxValue)
                            {
                                Console.WriteLine("No matches");
                            }

                            else
                            {
                                Console.WriteLine(rightMostIndex);
                            }
                        }
                        break;

                    case "first":

                        int count = int.Parse(commands[1]);

                        if (count > input.Count)
                        {
                            Console.WriteLine("Invalid count");
                            break;
                        }

                        if (commands[2] == "odd")
                        {
                            int counting = count;

                            List<int> result = new List<int>();
                            for (int i = 0; i < input.Count; i++)
                            {
                                if (counting == 0)
                                {
                                    break;
                                }

                                if (input[i] % 2 != 0)
                                {
                                    result.Add(input[i]);
                                    counting--;
                                }
                            }

                            if (counting == count)
                            {
                                Console.WriteLine("[]");
                            }

                            else
                            {
                                Console.WriteLine($"[{ string.Join(", ", result)}]");
                            }
                        }

                        else
                        {
                            int counting = count;

                            List<int> result = new List<int>();
                            for (int i = 0; i < input.Count; i++)
                            {
                                if (counting == 0)
                                {
                                    break;
                                }

                                if (input[i] % 2 == 0)
                                {
                                    result.Add(input[i]);
                                    counting--;
                                }
                            }

                            if (counting == count)
                            {
                                Console.WriteLine("[]");
                            }

                            else
                            {
                                Console.WriteLine($"[{string.Join(", ", result)}]");
                            }
                        }
                        break;

                    case "last":

                        int countLast = int.Parse(commands[1]);

                        if (countLast > input.Count)
                        {
                            Console.WriteLine("Invalid count");
                            break;
                        }

                        if (commands[2] == "odd")
                        {
                            int counting = countLast;

                            List<int> result = new List<int>();

                            for (int i = input.Count - 1; i >= 0; i--)
                            {
                                if (counting == 0)
                                {
                                    break;
                                }

                                if (input[i] % 2 != 0)
                                {
                                    result.Add(input[i]);
                                    counting--;
                                }
                            }

                            if (counting == countLast)
                            {
                                Console.WriteLine("[]");
                            }

                            else
                            {
                                result.Reverse();
                                Console.WriteLine($"[{string.Join(", ", result)}]");
                            }
                        }

                        else
                        {
                            int counting = countLast;

                            List<int> result = new List<int>();
                            for (int i = input.Count - 1; i >= 0; i--)
                            {
                                if (counting == 0)
                                {
                                    break;
                                }

                                if (input[i] % 2 == 0)
                                {
                                    result.Add(input[i]);
                                    counting--;
                                }
                            }

                            if (counting == countLast)
                            {
                                Console.WriteLine("[]");
                            }

                            else
                            {
                                Console.WriteLine($"[{string.Join(", ", result)}]");
                            }
                        }

                        break;
                }

                commands = Console.ReadLine().Split();
            }

            Console.WriteLine($"[{string.Join(", ", input)}]");
        }
    }
}