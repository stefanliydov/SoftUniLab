using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().ToList();

            var camel = int.Parse(Console.ReadLine());
            var rounds = 0;
            while (list.Count != camel)
            {
                list.RemoveAt(0);
                rounds++;
                if (list.Count == camel)
                    break;
                list.Reverse();
                list.RemoveAt(0);
                list.Reverse();
            }
            if (rounds == 0)
                Console.WriteLine("already stable: " + string.Join(" ", list));
            else
            {
                Console.WriteLine(rounds + " rounds");
                Console.WriteLine("remaining: " + string.Join(" ", list));
            }

        }
    }
}
