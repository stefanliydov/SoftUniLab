using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIItable
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            

            for(var i= num1; i <= num2; i++)
            {
                
                Console.Write(Convert.ToChar(i)+" ");
                Console.WriteLine();
            }
        }
    }
}
