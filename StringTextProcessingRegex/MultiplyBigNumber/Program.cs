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

            int multiplyer = int.Parse(Console.ReadLine());

            List<int> result = new List<int>();

            int ostatak = 0;

            for (int i = firstNumber.Count - 1; i >= 0; i--)
            {
                if ((firstNumber[i] * multiplyer) + ostatak < 10)
                {
                    result.Insert(0, (firstNumber[i] * multiplyer) + ostatak);
                    ostatak = 0;
                }

                else
                {
                    result.Insert(0, ((firstNumber[i] * multiplyer) + ostatak) % 10);
                    ostatak = ((firstNumber[i] * multiplyer) + ostatak) / 10;

                    if (i == 0 && ostatak != 0)
                    {
                        result.Insert(0, ostatak);
                        break;
                    }
                }
            }
            int sum = result.Sum();
            if (sum == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(string.Join("", result));
            }           
        }
    }
}
