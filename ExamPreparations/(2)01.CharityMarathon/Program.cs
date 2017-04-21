using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_01.CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var runners = int.Parse(Console.ReadLine()); 
            var numberOfLaps = int.Parse(Console.ReadLine());
            var lapLength = int.Parse(Console.ReadLine());
            var trackCapacity = int.Parse(Console.ReadLine());
            var moneyDonated = double.Parse(Console.ReadLine());

            var totalCapacity = days * trackCapacity;
            runners = Math.Min(runners, totalCapacity);
            ulong totalMeters = (ulong)runners * (ulong)numberOfLaps * (ulong)lapLength;
            decimal totalKm = (decimal)totalMeters / 1000;

            decimal moneyRaised = totalKm * (decimal)moneyDonated;

            Console.WriteLine("Money raised: {0:f2}", moneyRaised);


        }
    }
}
