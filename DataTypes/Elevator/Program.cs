using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfPeople = int.Parse(Console.ReadLine());
            var capacity = int.Parse(Console.ReadLine());

            Console.WriteLine( (int)Math.Ceiling((double)numberOfPeople/capacity));
        }
    }
}
