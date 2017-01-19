using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            byte cent = byte.Parse(Console.ReadLine());
            short years = (short)(cent * 100);
            uint days = (uint)(years * 365.2422);
            long hours = days * 24;
            ulong minutes = (ulong)(hours * 60);
            ulong seconds = minutes * 60;
            decimal miliseconds = seconds * 1000;
            decimal nano = miliseconds * 1000000;
            Console.WriteLine(hours);
            Console.WriteLine(minutes);
            Console.WriteLine(seconds);
            Console.WriteLine(miliseconds);
            Console.WriteLine(nano);
        }
    }                                     
}
