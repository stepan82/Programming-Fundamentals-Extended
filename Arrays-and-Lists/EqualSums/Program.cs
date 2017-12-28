using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int index = 0;

            int leftSum = 0;

            int rightSum = 0;

            for (int i = 1; i < numbers.Length; i++)
            {

                for (int j = i - 1; j >= 0; j--)
                {
                    leftSum += numbers[j];

                    if (i == numbers.Length - 1 && leftSum == numbers[i])
                    {
                        index = i;
                    }
                }

                for (int k = i + 1; k < numbers.Length; k++)
                {
                    if (i == numbers.Length - 1)
                    {
                        break;
                    }
                    rightSum += numbers[k];
                }

                if (leftSum == rightSum)
                {
                    index = i;
                    break;
                }

                leftSum = 0;
                rightSum = 0;
            }

            if (index != 0)
            {
                Console.WriteLine(index);
            }

            else if (numbers.Length == 1 || numbers.Min() < 0)
            {
                Console.WriteLine(0);
            }

            else if (index == 0)
            {
                Console.WriteLine("no");
            }
        }
    }
}
