using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main()
        {
            int studentsCount = int.Parse(Console.ReadLine());

            var diary = new Dictionary<string, List<double>>();

            for (int i = 0; i < studentsCount; i++)
            {
                var tokens = Console.ReadLine().Split();
                string name = tokens[0];
                double grade = double.Parse(tokens[1]);

                if (!diary.ContainsKey(name))
                {
                    diary[name] = new List<double>();
                }

                diary[name].Add(grade);
            }

            foreach (var student in diary)
            {
                Console.Write($"{student.Key} -> ");

                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:F2} ");
                };

                double averageGrade = student.Value.Average();

                Console.WriteLine("(avg: {0:F2})", averageGrade);
            }
        }
    }
}
