using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberParticip = int.Parse(Console.ReadLine());

            decimal technical = 0.0M;
            decimal theoretical = 0.0M;
            decimal practical = 0.0M;

            for (int i = 0; i < numberParticip; i++)
            {
                int distanceMiles = int.Parse(Console.ReadLine());

                decimal cargoTones = decimal.Parse(Console.ReadLine());

                string teamName = Console.ReadLine();

                long distanceMeters = distanceMiles * 1600;

                decimal cargoKilo = cargoTones * 1000M;

                decimal participantEarnedMoney = (cargoKilo * 1.5M) - (0.7M * distanceMeters * 2.5M);

                if (teamName == "Technical")
                {
                    technical += participantEarnedMoney;
                }
                if (teamName == "Theoretical")
                {
                    theoretical += participantEarnedMoney;
                }
                if (teamName == "Practical")
                {
                    practical += participantEarnedMoney;
                }
            }

            if (technical > theoretical && technical > practical)
            {
                Console.WriteLine($"The Technical Trainers win with ${technical:F3}.");
            }

            if (theoretical > technical && theoretical > practical)
            {
                Console.WriteLine($"The Theoretical Trainers win with ${theoretical:F3}.");
            }

            if (practical > technical && practical > theoretical)
            {
                Console.WriteLine($"The Practical Trainers win with ${practical:F3}.");
            }
            
        }
    }
}
