using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEPhoenixOscarRomeoNovember
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            var creaturesData = new Dictionary<string, HashSet<string>>();

            List<string> check = new List<string>();

            while (input[0] != "Blaze" && input[1] != "it!")
            {
                string creature = input[0];

                string squadMate = input[1];

                check.Add(squadMate + "" + creature);

                if (!creaturesData.ContainsKey(creature))
                {
                    creaturesData[creature] = new HashSet<string>();
                }

                if (creature == squadMate || check.Contains(creature + "" + squadMate))
                {
                    creaturesData[squadMate].Remove(creature);

                    goto Input;
                }

                creaturesData[creature].Add(squadMate);

                Input:
                input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var creat in creaturesData.OrderByDescending(x => x.Value.Count()))
            {
                Console.WriteLine($"{creat.Key} : {creat.Value.Count()}");
            }
        }
    }
}
