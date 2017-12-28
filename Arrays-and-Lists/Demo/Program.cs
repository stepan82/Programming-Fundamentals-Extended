using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "pesho", "Gosho", "Sasho", "Ivan", "petko", "stepan", "sofi" };

            var result = names.OrderByDescending(st => st[0]).ToList();
            // int endIndex = 5;
            //
            // for (int i = 2; i <= 5 / 2; i++)
            // {
            //     string current = names[i];
            //     names[i] = names[endIndex];
            //     names[endIndex] = current;
            //     endIndex--;
            // }
            //
            // for (int i = 0; i < 2; i++)
            // {
            //     string current = names[names.Length - 1];
            //
            //     for (int j = names.Length - 1; j >= 1; j--)
            //     {
            //         names[j] = names[j - 1];
            //     }
            //
            //     names[0] = current;
            // }
            //
            //

            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
