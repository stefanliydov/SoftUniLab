using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            var distance = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var seconds = int.Parse(Console.ReadLine());

            float test = hours * 60f* 60f +minutes * 60f + seconds;
            float mPerS = (distance / test);
            Console.WriteLine(mPerS);
            
            float test2 = hours + minutes / 60f + seconds / 60f / 60f;
            float kmPerH = (distance/1000) / test2;
            Console.WriteLine(kmPerH);

            float test3 = hours + minutes / 60f + seconds / 60f / 60f;
            float mPerH= ((distance / 1000) / test2) / 1.609f;
            Console.WriteLine(mPerH);




        }
    }
}
