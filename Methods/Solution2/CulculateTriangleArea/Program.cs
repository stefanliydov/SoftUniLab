using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CulculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
           
            Console.WriteLine(GetArea(width, height));
        }
        public static double GetArea(double width, double height)
        {
            return (width * height) / 2;
        }
    }
}
