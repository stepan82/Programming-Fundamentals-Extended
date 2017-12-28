using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> result = new List<string>();

            foreach (var item in text)
            {
                var word = item.ToCharArray();
                Array.Reverse(word);
                string reversed = new string(word);

                if (item == reversed && !result.Contains(item))
                {
                    result.Add(item);
                }

            }

            result.Sort();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
