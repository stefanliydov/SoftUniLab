using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfNumber = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            listOfNumber.RemoveAll(x => x < 0);
            if (listOfNumber.Count == 0)
                Console.WriteLine("empty");
            else
            {
                listOfNumber.Reverse();
                Console.WriteLine(String.Join(" ", listOfNumber));
            }
            
        }
    }
}
