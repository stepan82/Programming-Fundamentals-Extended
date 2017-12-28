using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int initialIndex = int.Parse(Console.ReadLine());

            int damage = 1;

            while (true)
            {
                var commands = Console.ReadLine().Split().ToArray();

                if (commands[0] == "Supernova")
                {
                    break;
                }

                string direction = commands[0];

                int steps = int.Parse(commands[1]);

                switch (direction)
                {
                    case "left":

                        for (int i = 0; i < steps; i++)
                        {
                            initialIndex--;

                            if (initialIndex < 0)
                            {
                                initialIndex = input.Length - 1;
                                damage++;
                            }
                            input[initialIndex] -= damage;

                        }
                        break;

                        case "right":
                        for (int i = 0; i < steps; i++)
                        {
                            initialIndex++;

                            if (initialIndex > input.Length-1)
                            {
                                initialIndex = 0;
                                damage++;
                            }
                            input[initialIndex] -= damage;

                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
