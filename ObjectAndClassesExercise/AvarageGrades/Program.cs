using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvarageGrades
{
    class Student
    {
        public string Name { get; set; }
        public double[] Grades { get; set; }
        public double AverageGrade { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Student[] students = new Student[n];

            for (int i = 0; i < n; i++)
            {
                var studentData = Console.ReadLine().Split().ToArray();
                double[] grades = new double[studentData.Length-1];
                for (int j = 1; j <= studentData.Length - 1; j++)
                    grades[j-1] = double.Parse(studentData[j]);
               students[i] = new Student { Name = studentData[0], Grades = grades, AverageGrade = grades.Average() };
            }
            foreach (var item in students.Select(x =>x.Name).OrderBy(gr=> gr))
            {
                var GradesOversix = item.Where(x => x >= 5);
                
            }
        }
      
    }
}
