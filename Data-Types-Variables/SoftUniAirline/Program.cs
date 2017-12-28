using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniAirline
{
    class Program
    {
        static void Main(string[] args)
        {
            int flightsCount = int.Parse(Console.ReadLine());
            decimal totalProfit = 0.0M;
            for (int i = 0; i < flightsCount; i++)
            {
                int adultCount = int.Parse(Console.ReadLine());
                decimal adultTicketPrice = decimal.Parse(Console.ReadLine());
                int youthCount = int.Parse(Console.ReadLine());
                decimal youthTicketPrice = decimal.Parse(Console.ReadLine());
                decimal fuelPriceHour = decimal.Parse(Console.ReadLine());
                decimal fuelConsumption = decimal.Parse(Console.ReadLine());
                int flightDuration = int.Parse(Console.ReadLine());

                decimal income = (adultCount * adultTicketPrice) + (youthCount * youthTicketPrice);

                decimal expenses = flightDuration * fuelConsumption * fuelPriceHour;

                decimal profit = income - expenses;
                totalProfit += profit;

                if (income >= expenses)
                {
                    Console.WriteLine($"You are ahead with {profit:F3}$.");
                }
                else
                {
                    Console.WriteLine($"We've got to sell more tickets! We've lost {profit:F3}$.");
                }
            }

            decimal averageProfit = totalProfit / flightsCount;

            Console.WriteLine($"Overall profit -> {totalProfit:F3}$.");
            Console.WriteLine($"Average profit -> {averageProfit:F3}$.");
        }
    }
}
