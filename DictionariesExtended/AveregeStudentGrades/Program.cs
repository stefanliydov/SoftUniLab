using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AveregeStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<double>>();

            var n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                var grade = 0.00;
                var currNameGrade = Console.ReadLine().Split();
                var name = currNameGrade[0];
                 grade = double.Parse(currNameGrade[1]);
                if (!dict.ContainsKey(name)) {
                    var list = new List<double> { grade };
                    dict.Add(name, list);
                }
                else
                    dict[name].Add(grade);
            }

            foreach (var item in dict)
            {
                var name = item.Key;
                var grades = item.Value;
                var gradesList = string.Join(" ", grades);
                var averege = grades.Average();
                Console.Write($"{name} -> " );
                foreach (var item1 in grades)
                {
                    Console.Write("{0:f2}", item1);
                    Console.Write(" ");
                }
                Console.Write( "(avg: {0:f2})", averege);
                Console.WriteLine();
            }
        }
    }
}
