    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace LongestLine
    {
        class Program
        {
            static void Main(string[] args)
            {
                double x1 = double.Parse(Console.ReadLine());
                double y1 = double.Parse(Console.ReadLine());
                double x2 = double.Parse(Console.ReadLine());
                double y2 = double.Parse(Console.ReadLine());
                double x3 = double.Parse(Console.ReadLine());
                double y3 = double.Parse(Console.ReadLine());
                double x4 = double.Parse(Console.ReadLine());
                double y4 = double.Parse(Console.ReadLine());

                LongestLine(x1, y1, x2, y2, x3, y3, x4, y4);
            }
            public static void LongestLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
            {
                var lineA = Math.Sqrt((x1-x2)*(x1 - x2) + (y1 - y2)*(y1-y2));
                var lineB = Math.Sqrt((x3 - x4) * (x3 - x4) + (y3 - y4) * (y3 - y4));
                ClosestToCenter(lineA,lineB, x1, y1, x2, y2, x3, y3, x4, y4);
            }
            public static void ClosestToCenter(double lineA, double lineB, double x1, double y1, 
                double x2, double y2, double x3, double y3, double x4, double y4)
            {
           
                 if (lineA >= lineB)
                {
                    var pointA = Math.Sqrt(x1 * x1 + y1 * y1);
                    var pointB = Math.Sqrt(x2 * x2 + y2 * y2);
                    if (pointA > pointB)
                        Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                    else
                        Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                
                }
                else
                {
                    var pointA = Math.Sqrt(x3 * x3 + y3 * y3);
                    var pointB = Math.Sqrt(x4 * x4 + y4 * y4);
                    if (pointA < pointB)
                        Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                    else
                        Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }  
    }
