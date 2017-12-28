using System;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            var bombSpec = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int number = bombSpec[0];
            int power = bombSpec[1];

            while (input.Contains(number))
            {
                int index = input.IndexOf(number);

                if (index + power > input.Count - 1 && 0 + power <= index)
                {
                    input.RemoveRange(index - power, power + 1 + (input.Count - 1 - index));
                }

                else if (index + power <= input.Count - 1 && 0 + power > index)
                {
                    input.RemoveRange(0, power + 1 + (index - 0));
                }

                else
                {
                    input.RemoveRange(index - power, power * 2 + 1);
                }             
            }

            Console.WriteLine(input.Sum());
        }
    }
}
