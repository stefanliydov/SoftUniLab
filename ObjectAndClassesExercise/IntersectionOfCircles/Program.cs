using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionOfCircles
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstCircle = Console.ReadLine().Split().ToArray();
            var secondCircle = Console.ReadLine().Split().ToArray();

            var point1 = new Circle { x = int.Parse(firstCircle[0]), y = int.Parse(firstCircle[1]), r = int.Parse(firstCircle[2]) };
            var point2 = new Circle { x = int.Parse(secondCircle[0]), y = int.Parse(secondCircle[1]), r = int.Parse(secondCircle[2]) };
            var distance = Math.Sqrt((point1.x - point2.x) * (point1.x - point2.x) + (point1.y - point2.y) * (point1.y - point2.y));
            if (point1.r+ point2.r >= distance)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
 
}
