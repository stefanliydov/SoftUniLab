using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeProps
{
    class Program
    {
        static void Main(string[] args)
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string parameters = Console.ReadLine();
            Calculations(cubeSide, parameters);
        }
        static void Calculations(double cubeSide, string parameters)
        {
            double face = Math.Sqrt((cubeSide * cubeSide) + (cubeSide * cubeSide));
            double space = Math.Sqrt((cubeSide * cubeSide) + (cubeSide * cubeSide) + (cubeSide * cubeSide));
            double volume = cubeSide * cubeSide * cubeSide;
            double area = cubeSide * cubeSide * 6;
            if(parameters == "face")
                Console.WriteLine("{0:f2}",face);
            else if( parameters=="space")
                Console.WriteLine("{0:f2}", space);
            else if( parameters=="volume")
                Console.WriteLine("{0:f2}", volume);
            else if( parameters == "area")
                Console.WriteLine("{0:f2}", area);

        }
    }
}
