using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Part_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            for (int i = startNumber; i <= endNumber; i++)
            {
                Console.Write($"{Convert.ToChar(i)} ");
            }
            Console.WriteLine();
        }
    }
}
