using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        { var baseNumber = double.Parse(Console.ReadLine());
            var pow = int.Parse(Console.ReadLine());

            Console.WriteLine(RaiseToPower(baseNumber, pow));
            
        }
        public static double RaiseToPower(double baseNumber, int pow)
        {
            double result = 1d; 
            for (int i =1; i<=pow; i++)
            {
                result *=baseNumber ;
            }
            
            return result;
        }
    }
}
