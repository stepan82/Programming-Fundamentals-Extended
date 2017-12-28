using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalMoney = decimal.Parse(Console.ReadLine());

            int guestsCount = int.Parse(Console.ReadLine());

            decimal bananasPrice = decimal.Parse(Console.ReadLine());

            decimal eggsPrice = decimal.Parse(Console.ReadLine());

            decimal berriesPrice = decimal.Parse(Console.ReadLine());

            decimal portions = Math.Ceiling(guestsCount / 6.0M);

            decimal result = portions * (2 * bananasPrice) + portions * (4 * eggsPrice) + portions * (0.2M * berriesPrice);

            if (result <= totalMoney)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {result:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(result - totalMoney):F2}lv more.");
            }
        }
    }
}
