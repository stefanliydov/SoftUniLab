using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingAwaysFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();

            string[] items = values.Split(' ');
            double[] arr = new double[items.Length];

            for (int i = 0; i < items.Length; i++)
            {
                arr[i] = double.Parse(items[i]);
                var roundedAwayFromZero = arr[i];
                Console.WriteLine($"{roundedAwayFromZero} => "+ Math.Round(roundedAwayFromZero, 0, MidpointRounding.AwayFromZero));
            }
        }
    }
}
