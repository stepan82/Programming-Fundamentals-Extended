using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnunionLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var primalList = Console.ReadLine().Split().Select(int.Parse).ToList();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var currentList = Console.ReadLine().Split().Select(int.Parse).ToList();

                var secondList = new List<int>();

                for (int k = 0; k < currentList.Count; k++)
                {
                    if (!primalList.Contains(currentList[k]))
                    {
                        primalList.Add(currentList[k]);
                        secondList.Add(currentList[k]);
                    }
                }

                for (int d = primalList.Count-1; d >= 0; d--)
                {
                    if (currentList.Contains(primalList[d]) && !secondList.Contains(primalList[d]))
                    {
                        primalList.RemoveAt(d);
                    }
                }
            }

            primalList.Sort();

            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}
