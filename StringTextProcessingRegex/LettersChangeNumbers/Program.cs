using System;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split(new char[] {' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            decimal sum = 0.0M;

            string alphabetUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            string alphabetLower = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 0; i < tokens.Length; i++)
            {
                string currentString = tokens[i];

                char leftLetter = currentString[0];

                long number = long.Parse(currentString.Substring(1, currentString.Length - 2));

                decimal currentResult = 0.0M;

                if (leftLetter >= 65 && leftLetter <= 90)
                {
                    long index = alphabetUpper.IndexOf(leftLetter) + 1;
                    decimal result = number / (decimal)index;
                    currentResult += result;
                }

                else if (leftLetter >= 97 && leftLetter <= 122)
                {
                    long index = alphabetLower.IndexOf(leftLetter) + 1;
                    decimal result = number * (decimal) index;
                    currentResult += result;
                }

                char rightLetter = currentString[currentString.Length - 1];

                if (rightLetter >= 65 && rightLetter <= 90)
                {
                    long index = alphabetUpper.IndexOf(rightLetter) + 1;
                    currentResult -= index;
                    sum += currentResult;
                    currentResult = 0;
                }

                else if (rightLetter >= 97 && rightLetter <= 122)
                {
                    long index = alphabetLower.IndexOf(rightLetter) + 1;
                    currentResult += index;
                    sum += currentResult;
                    currentResult = 0;
                }
            }

            Console.WriteLine($"{sum:F2}");
        }
    }
}
