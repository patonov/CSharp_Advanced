using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> studentGrades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string student = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!studentGrades.ContainsKey(student))
                {
                    studentGrades.Add(student, new List<decimal>());
                }
                studentGrades[student].Add(grade);
            }

            foreach (var student in studentGrades)
            {
                var name = student.Key;
                var grades = student.Value;
                var average = grades.Average();

                Console.Write("{0} -> ", name);

                foreach (var grade in grades)
                {
                    Console.Write("{0:F2} ", grade);
                }
                Console.WriteLine("(avg: {0:F2})", average);

            }

        }
    }
}
