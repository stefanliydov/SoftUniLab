using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeFormat = @"hh\:mm\:ss";
            var time = TimeSpan.ParseExact(Console.ReadLine(),timeFormat, CultureInfo.InvariantCulture);
            var steps = int.Parse(Console.ReadLine());
            var secPerStep = int.Parse(Console.ReadLine());

            var secondsInDay = 60*60*24;
            int totalSecs = (int)(((double)steps * secPerStep)  % secondsInDay);
            var arrivalTime = time.Add(new TimeSpan(0, 0, totalSecs));
            Console.WriteLine("Time Arrival: "+ arrivalTime.ToString(timeFormat));

        }
    }
}
