using System;
using System.Linq;

namespace CommandInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var commands = Console.ReadLine().Split().ToArray();

            while (commands[0] != "end")
            {
                string action = commands[0];

                switch (action)
                {
                    case "reverse":
                        int startIndex = int.Parse(commands[2]);
                        int count = int.Parse(commands[4]);

                        if (startIndex < 0 || startIndex >= input.Length || count < 0 || (startIndex + count) > input.Length)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }

                        Array.Reverse(input, startIndex, count);
                        break;

                    case "sort":
                        int indexSort = int.Parse(commands[2]);
                        int countSort = int.Parse(commands[4]);

                        if (indexSort < 0 || indexSort >= input.Length || countSort < 0 || (indexSort + countSort) > input.Length)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }

                        Array.Sort(input, indexSort, countSort);
                        break;

                    case "rollLeft":
                        int rollLeftCount = int.Parse(commands[1]);

                        if (rollLeftCount < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }

                        for (int i = 0; i < rollLeftCount % input.Length; i++)
                        {
                            string perm = input[0];
                            for (int k = 0; k < input.Length - 1; k++)
                            {
                                input[k] = input[k + 1];
                            }
                            input[input.Length - 1] = perm;
                        }
                        break;

                    case "rollRight":
                        int rollRightCount = int.Parse(commands[1]);

                        if (rollRightCount < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }

                        for (int i = 0; i < rollRightCount % input.Length; i++)
                        {
                            string current = input[input.Length - 1];

                            for (int j = input.Length - 1; j >= 1; j--)
                            {
                                input[j] = input[j - 1];
                            }

                            input[0] = current;
                        }
                        break;
                }
                commands = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine($"[{string.Join(", ", input)}]");
        }
    }
}
