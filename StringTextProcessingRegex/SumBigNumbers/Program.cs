using System;
using System.Collections.Generic;
using System.Linq;

namespace SumBigNumbers
{
    class Program
    {
        static void Main()
        {
            var firstNumber = Console.ReadLine().TrimStart(new char[] { '0' }).ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToList();

            var secondNumber = Console.ReadLine().TrimStart(new char[] { '0' }).ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToList();

            List<int> result = new List<int>();

            int ostatak = 0;

            if (firstNumber.Count > secondNumber.Count)
            {
                int count = firstNumber.Count - secondNumber.Count;

                for (int i = 0; i < count; i++)
                {
                    secondNumber.Insert(0, 0);
                }
            }

            else
            {
                int count = secondNumber.Count - firstNumber.Count;

                for (int i = 0; i < count; i++)
                {
                    firstNumber.Insert(0, 0);
                }
            }

            for (int i = firstNumber.Count - 1; i >= 0; i--)
            {
                if (firstNumber[i] + secondNumber[i] + ostatak < 10)
                {
                    result.Insert(0, firstNumber[i] + secondNumber[i] + ostatak);
                    ostatak = 0;
                }

                else
                {
                    result.Insert(0, (firstNumber[i] + secondNumber[i] + ostatak) % 10);
                    ostatak = 0;
                    ostatak++;

                    if (i == 0 && ostatak != 0)
                    {
                        result.Insert(0, ostatak);
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
