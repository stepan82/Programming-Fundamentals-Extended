using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = 0;
            int permMax = 0;
            int mostFrequent = input[0];

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        count++;
                    }
                }

                if (count > permMax)
                {
                    mostFrequent = input[i];
                    permMax = count;
                }
                count = 0;
            }

            Console.WriteLine(mostFrequent);
        }
    }
}
