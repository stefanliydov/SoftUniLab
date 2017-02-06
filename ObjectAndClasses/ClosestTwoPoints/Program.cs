using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestTwoPoints
{
    class Program
    {
        public static object SecondPoint { get; private set; }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var arrayPoints = new string[n];
            for (int i = 0; i < n; i++)
            {
                var coordinates = (Console.ReadLine());
                arrayPoints[i] = coordinates;
            }

         
            double smallestDistance =500.0;
            double cordx = 0;
            double cordy = 0;
            double cordx1 = 0;
            double cordy2 = 0;
            for (int i = 0; i < arrayPoints.Length - 1; i++)
            {
                var splited = arrayPoints[i].Split(' ').Select(double.Parse).ToArray();
                var firstPoint = new Point() { x = splited[0] , y = splited[1]};

            for (int j = i + 1; j < arrayPoints.Length; j++)
            {
                var splited2 = arrayPoints[j].Split(' ').Select(double.Parse).ToArray();
                    var SeondPoint = new Point() { x = splited2[0], y = splited2[1] };

                    var distance = Math.Sqrt((firstPoint.x - SeondPoint.x) * (firstPoint.x - SeondPoint.x) + (firstPoint.y - SeondPoint.y) * (firstPoint.y - SeondPoint.y));
                    if (distance < smallestDistance)
                    {
                        smallestDistance = distance;
                        cordx = firstPoint.x;
                        cordy = firstPoint.y;
                        cordx1 = SeondPoint.x;
                        cordy2 = SeondPoint.y;
                    }

             }
          

            }
            Console.WriteLine("{0:f3}", smallestDistance);
            Console.WriteLine($"({cordx}, {cordy})");
            Console.WriteLine($"({cordx1}, {cordy2})");


        }
    }
    class Point
    {
        public double x { get; set; }
        public double y { get; set; }
    }
}
