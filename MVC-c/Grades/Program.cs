using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи брой ученици.");
            int countStudents = int.Parse(Console.ReadLine());
            double[] grade = new double[countStudents];
            int gradeB = 0;
            int gradeC=0;
            for (int i = 0; i < grade.Length; i++)
            {
                Console.WriteLine($"Въведи успех на ученик номер {i+1}");
                grade[i] = double.Parse(Console.ReadLine());
                if (grade[i]==2)
                {
                    gradeC++;
                }
                else if (grade[i] > 3.50 && grade[i]<=4)
                {
                    gradeB++;
                }
            }
            Console.WriteLine($"Брой ученици със слаб успех:{gradeC}");
            Console.WriteLine($"Брой ученици с добър успех:{gradeB}");
        }
    }
}
