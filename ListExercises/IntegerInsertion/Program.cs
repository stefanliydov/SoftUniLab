using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerInsertion
{
    class Program
    {
        static void Main(string[] args)
        {
            var listInt = Console.ReadLine().Split().Select(int.Parse).ToList();

            var commandNumber = Console.ReadLine();
            while (commandNumber != "end")
            {
                var number = int.Parse(commandNumber);
                var firstDigit = 0;
                while (number > 0)
                {
                    firstDigit = number%10;
                    number /= 10;
                }
                listInt.Insert(firstDigit, int.Parse(commandNumber));
                commandNumber = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", listInt));

        }
    }
}
