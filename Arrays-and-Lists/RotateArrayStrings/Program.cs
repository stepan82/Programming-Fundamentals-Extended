using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArrayStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var letters = Console.ReadLine().Split().ToArray();

            string temp = letters[letters.Length - 1];

            for (int i = letters.Length-1; i >= 1; i--)
            {
                letters[i] = letters[i - 1];
            }

            letters[0] = temp;

            Console.WriteLine(string.Join(" ", letters));
        }
    }
}
