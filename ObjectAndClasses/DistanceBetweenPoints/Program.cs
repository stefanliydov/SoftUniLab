using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPointCords = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var secondPointCords = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
              

            var firstPoint = new Point()
            {
                x = firstPointCords[0],
                y = firstPointCords[1]
            };
            var secondsPoint = new Point()
            {
                x = secondPointCords[0],
                y = secondPointCords[1]
            };

            double result = Math.Sqrt((firstPoint.x - secondsPoint.x) * (firstPoint.x - secondsPoint.x) + (firstPoint.y - secondsPoint.y) * (firstPoint.y - secondsPoint.y));
            Console.WriteLine("{0:f3}",Distance(firstPoint.x, firstPoint.y, secondsPoint.x, secondsPoint.y));
        }
        static public double Distance  (double x, double y, double x1, double y1)
        {
            return Math.Sqrt((x - x1) * (x - x1) + (y - y1) * (y - y1));
        }
        class Point
        {
            public double x { get; set; }
            public double y { get; set; }
        }
    }
}
