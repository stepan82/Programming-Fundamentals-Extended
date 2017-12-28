using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var tokens = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int takeCount = tokens[0];

            int deleteCount = tokens[1];

            int toFind = tokens[2];

            var taken = number.Take(takeCount).ToList();
            taken.RemoveRange(0, deleteCount);

            if (taken.Contains(toFind))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
