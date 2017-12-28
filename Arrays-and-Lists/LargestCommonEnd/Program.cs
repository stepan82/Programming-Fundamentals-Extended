using System;

using System.Linq;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');

            int leftMax = 0;
            int rightMax = 0;

            int min = Math.Min(firstArray.Length, secondArray.Length);

            for (int i = 0; i < min; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    leftMax++;
                }
                else
                {
                    break;
                }
            }

            var firstReversed = firstArray.Reverse().ToArray();
            var secondReversed = secondArray.Reverse().ToArray();

            for (int i = 0; i < min; i++)
            {
                if (firstReversed[i] == secondReversed[i])
                {
                    rightMax++;
                }
                else
                {
                    break;
                }
            }

            int result = Math.Max(leftMax, rightMax);

            Console.WriteLine(result);
        }
    }
}
