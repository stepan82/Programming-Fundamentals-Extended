using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSumAfterExtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var list_1 = Console.ReadLine().Split().Select(int.Parse).ToList();

            var list_2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sumList_2 = 0;

            for (int i = 0; i < list_2.Count; i++)
            {
                if (!list_1.Contains(list_2[i]))
                {
                    sumList_2 += list_2[i];
                }
            }

            int sumList_1 = list_1.Sum();

            if (sumList_1 == sumList_2)
            {
                Console.WriteLine($"Yes. Sum: {sumList_1}");
            }

            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(sumList_1 - (double)sumList_2)}");
            }
        }
    }
}
