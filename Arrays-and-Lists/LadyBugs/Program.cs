using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            long fieldLength = int.Parse(Console.ReadLine());

            long[] field = new long[fieldLength];

            var bugsPosition = Console.ReadLine().Split().Select(long.Parse).ToArray();

            for (int i = 0; i < field.Length; i++)
            {
                if (bugsPosition.Contains(i))
                {
                    field[i] = 1;
                }
            }

            var commands = Console.ReadLine().Split();

            while (commands[0] != "end")
            {
                long startIndex = long.Parse(commands[0]);

                string direction = commands[1];

                long flyLength = long.Parse(commands[2]);

                if (field[startIndex] != 1 || startIndex < 0 || startIndex > field.Length - 1)
                {
                    continue;
                }

                else if (startIndex + flyLength > field.Length - 1 && direction == "right")
                {
                    field[startIndex] = 0;
                }

                else if (startIndex < flyLength && direction == "left")
                {
                    field[startIndex] = 0;
                }

                commands = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
