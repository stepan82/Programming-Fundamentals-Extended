using System;
using System.Linq;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var field = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var initialField = new int[field.Length];

            for (int i = 0; i < initialField.Length; i++)
            {
                initialField[i] = field[i];
            }

            int steps = 0;

            int currentIndex = field.Length - 1;

            while (true)
            {
                for (int i = 0; i < field.Length - 1; i++)
                {
                    field[i] -= 1;
                }

                if (field[currentIndex] == 0)
                {
                    break;
                }

                if (field.Contains(0) && field[currentIndex] != 0)
                {
                    for (int i = 0; i < field.Length - 1; i++)
                    {
                        if (field[i] == 0)
                        {
                            field[i] = initialField[i];
                        }
                    }
                }

                steps++;

                int index = int.Parse(Console.ReadLine());

                currentIndex = index;
            }

            for (int i = 0; i < field.Length -1; i++)
            {
                Console.Write($"{field[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine(steps);
        }
    }
}
