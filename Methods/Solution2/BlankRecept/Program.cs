using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlankRecept
{
    class Program
    {
        static void Main(string[] args)
        {
            Header();
            Body();
            Bottom();
        }
        public static void Header()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        public static void Body()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        public static void Bottom()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }

    }
}
