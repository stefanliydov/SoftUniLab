using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleProps
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            Console.WriteLine(2*width+2*height);
            Console.WriteLine(width*height);
            Console.WriteLine(Math.Sqrt(width*width+height*height));
        }
    }
}
