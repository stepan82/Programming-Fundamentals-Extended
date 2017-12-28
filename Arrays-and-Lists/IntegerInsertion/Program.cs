using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerInsertion
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            var commands = Console.ReadLine().Split();

            while (commands[0] != "end")
            {
                char firstChar = commands[0].First();
                int index = (int)Char.GetNumericValue(firstChar);
                int number = int.Parse(commands[0]);
                input.Insert(index, number);

                commands = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
