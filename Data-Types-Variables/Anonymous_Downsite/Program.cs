using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSites = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());
            decimal totaLoss = 0.0M;
            BigInteger token = BigInteger.Pow(securityKey, numberOfSites);
            List<string> affectedSites = new List<string>();
            for (int i = 0; i < numberOfSites; i++)
            {
                var tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string siteName = tokens[0];
                affectedSites.Add(siteName);
                long siteVisits = long.Parse(tokens[1]);
                decimal sitePrice = decimal.Parse(tokens[2]);
                totaLoss += siteVisits * sitePrice;
            }

            foreach (var item in affectedSites)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Total Loss: {totaLoss:F20}");
            Console.WriteLine($"Security Token: {token}");
        }
    }
}
