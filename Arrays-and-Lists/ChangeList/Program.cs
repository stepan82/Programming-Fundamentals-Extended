using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var commands = Console.ReadLine().Split(' ').ToArray();

            while (true)
            {
                if (commands[0] == "Odd" || commands[0] == "Even")
                {
                    break;
                }
                if (commands[0] == "Delete")
                {
                    int number = int.Parse(commands[1]);
                    for (int i = numbers.Count-1; i >= 0; i--)
                    {
                        if (numbers[i] == number)
                        {
                            numbers.RemoveAt(i);
                        }
                    }
                }

                else
                {
                    int number = int.Parse(commands[1]);
                    int position = int.Parse(commands[2]);
                    numbers.Insert(position, number);
                }

                commands = Console.ReadLine().Split(' ').ToArray();
            }

            if (commands[0] == "Even")
            {
                foreach (var item in numbers.Where(x => x % 2 == 0))
                {
                    Console.Write($"{item} ");
                }
            }

            else
            {
                foreach (var item in numbers.Where(x => x % 2 != 0))
                {
                    Console.Write($"{item} ");
                }
            }
        }
    }
}
