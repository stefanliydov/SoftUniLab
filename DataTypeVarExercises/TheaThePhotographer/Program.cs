using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var pics = long.Parse(Console.ReadLine());
            var filterTime = long.Parse(Console.ReadLine());
            var filterFactor = long.Parse(Console.ReadLine());
            var uploadTime = long.Parse(Console.ReadLine());

            double goodPics = Math.Ceiling(pics * filterFactor / 100.0);
            var totalTime = (pics * filterTime) + (goodPics * uploadTime);

            


            Console.WriteLine(TimeSpan.FromSeconds(totalTime).ToString(@"d\:hh\:mm\:ss"));



        }
    }
}
