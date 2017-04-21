using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var Boxes = new Dictionary<string, List<int>>();

            var inputBox = Console.ReadLine();

            while (inputBox != "end")
            {
                var splited = inputBox.Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);
                var uLeftCord = splited[0].Split(':').Select(int.Parse).ToList();
                var uRightCord = splited[1].Split(':').Select(int.Parse).ToList();
                var bLeftCord = splited[2].Split(':').Select(int.Parse).ToList();
                var bRightCord = splited[3].Split(':').Select(int.Parse).ToList();

                Point upLeftPoint = new Point() { X = uLeftCord[0], Y = uLeftCord[1] };
                Point upRightPoint = new Point() { X = uRightCord[0], Y = uRightCord[1] };
                Point boLeftPoint = new Point() { X = bLeftCord[0], Y = bLeftCord[1] };
                Point boRightPoint = new Point() { X = bRightCord[0], Y = bRightCord[1] };

                var height = CalculateDistance(upLeftPoint.X, upLeftPoint.Y, boLeftPoint.X, boLeftPoint.Y);
                var width = CalculateDistance(upLeftPoint.X, upLeftPoint.Y, upRightPoint.X, upRightPoint.Y);

                int perimeter = (int)(2 * width + 2 * height);
                int area = (int)(width * height);

                var newBoxCord = string.Join(", ", width.ToString(), height.ToString());
                var newBoxParArea = new List<int> { perimeter, area };

                Boxes[newBoxCord] = newBoxParArea;

                inputBox = Console.ReadLine();
            }

            foreach (var box in Boxes)
            {
                Console.WriteLine("Box: "+ box.Key);
                Console.WriteLine("Perimeter: "+ box.Value[0]);
                Console.WriteLine("Area: "+box.Value[1]);
            }
        }
        public static int CalculateDistance(int x, int y, int x1, int y1)
        {
            var distance = Math.Sqrt((x - x1) * (x - x1) + (y - y1) * (y - y1));
            return (int)distance;
        }
    }
}
