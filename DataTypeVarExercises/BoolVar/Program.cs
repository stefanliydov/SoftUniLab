    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace BoolVar
    {
        class Program
        {
            static void Main(string[] args)
            {
                string test = Console.ReadLine().ToLower();
                if ( test =="true")
                    Console.WriteLine("Yes");
                if (test == "false")
                    Console.WriteLine("No");
            }
        }
    }
