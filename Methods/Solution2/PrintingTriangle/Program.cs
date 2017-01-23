using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            for(int row = 1; row<= number; row++)
            {
                Col(row);
            }
            for( int row = number-1; row>=1; row--)
            {
                Col(row);
            }
        }


        public static void Col(int n)
        {
            for (int col = 1; col <= n; col++)
            {
                Console.Write(col + " ");
            }
            Console.WriteLine();
        }
    }
}
