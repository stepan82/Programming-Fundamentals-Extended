using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertrain
{
    class Program
    {
        static void Main(string[] args)
        {
            int locomPower = int.Parse(Console.ReadLine());

            List<int> wagons = new List<int>();

            while (true)
            {
                string wagonCapacity = Console.ReadLine();
                if (wagonCapacity == "All ofboard!")
                {
                    break;
                }

                else
                {
                    int capacity = int.Parse(wagonCapacity);
                    wagons.Add(capacity);

                    if (wagons.Sum() > locomPower)
                    {
                        int averageSum = (int)(wagons.Average());
                        int closest = wagons.OrderBy(item => Math.Abs(averageSum - item)).First();

                        for (int i = 0; i < wagons.Count; i++)
                        {
                            if (wagons[i] == closest)
                            {
                                wagons.RemoveAt(i);
                            }
                        }
                    }
                }
            }

            wagons.Reverse();
            wagons.Add(locomPower);

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
