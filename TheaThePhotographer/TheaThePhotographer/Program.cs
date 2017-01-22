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
            var pics = int.Parse(Console.ReadLine());
            var filterTime = int.Parse(Console.ReadLine());
            var filterFactor = int.Parse(Console.ReadLine());
            var uploadTime = int.Parse(Console.ReadLine());

            double goodPics = Math.Ceiling(pics * filterFactor / 100.0);
            var totalTime = (pics * filterTime) + (goodPics * uploadTime);

            int hours = 0;
            var minutes = totalTime / 60;
            Console.WriteLine(minutes);
            if (minutes >= 60)
                 hours = (int)(minutes / 60);

            Console.WriteLine(hours);





        }
    }
}
