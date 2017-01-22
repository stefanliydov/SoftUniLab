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

            var seconds = Math.Ceiling(totalTime % 60);
            var minutes = (totalTime / 60) % 60;
            var hours = Math.Floor(((totalTime-minutes)/ 60 / 60) % 60);

           
            var day = 0;
            for (var i = 1; i <= hours; i++)
                if (hours >= 24)
                {
                    hours = hours - 24;
                    day++;
                    if (hours < 24)
                    {
                        break;
                    }
                }
                    Console.Write(day+":");
                    if (hours<=9)
                        Console.Write("0"+hours+ ":");
                    else
                        Console.Write(hours + ":");
                    if(minutes<=9)
                        Console.Write("0{0:f0}:",minutes);
                    else
                Console.Write("{0:f0}:", minutes);
            if (seconds<=9)
                        Console.Write("0" + seconds );
                    else
                        Console.Write(seconds);
                    Console.WriteLine();
                
          
        }
    }
}
