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
            decimal microseconds = miliseconds * 1000;
            
            Console.WriteLine($"{cent} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} miliseconds = {microseconds} microseconds = {nano} nanoseconds");


        }
    }                                     
}
