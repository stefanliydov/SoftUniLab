using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            PrintHeaderRow(n);
            PrintMiddleRow(n);
            PrintHeaderRow(n);

        }
        public static void PrintHeaderRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
        public static void PrintMiddleRow(int n)
        {
            for (int i = 1; i <= n / 2; i++)
            {
                Console.Write('-');
                Console.Write(string.Concat(Enumerable.Repeat("\\/", (n * 2 - 2) / 2)));
                Console.Write('-');
                Console.WriteLine();
            }
        }
    }
}
