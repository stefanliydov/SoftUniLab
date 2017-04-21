using System;
using System.Text;
using System.Linq;


namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToCharArray();
            Array.Reverse(text);
            Console.WriteLine(text);
           
         
        }
    }
}
