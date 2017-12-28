using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double rectleWidth = double.Parse(Console.ReadLine());
            double rectHeight = double.Parse(Console.ReadLine());

            double perimeter = (rectHeight * 2) + (rectleWidth * 2);
            double area = rectHeight * rectleWidth;
            double diagonal = Math.Sqrt(Math.Pow(rectleWidth, 2) + Math.Pow(rectHeight, 2));

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine($"{diagonal}");
        }
    }
}
