using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] studentInput = Console.ReadLine().Split();
                var studentName = studentInput[0];

                List<double> grades = new List<double>();
                for (int j = 1; j < studentInput.Length; j++)
                {
                    var grade =double.Parse( studentInput[j]);
                    grades.Add(grade);

                }
                Student student = new Student();
                student.Name = studentName;
                student.Grades = grades;
                students.Add(student);
            }

            foreach (var student in students.Where(x => x.AverageGrades() >=5).OrderBy(x=>x.Name).ThenByDescending(x 
                => x.AverageGrades()))
                {
                Console.WriteLine("{0} -> {1:f2}", student.Name, student.AverageGrades());
                }
            


        }
    }
    public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }

        public double AverageGrades()
        {
            double averageGrade = this.Grades.Average();
            return averageGrade;
        }
        


    }
}
