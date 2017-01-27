using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Vowel_to_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            if (char.Parse(str) == 'a' || char.Parse(str) == 'o' ||
                char.Parse(str) == 'u' || char.Parse(str) == 'e' ||
                char.Parse(str) == 'i')
            {
                Console.WriteLine("vowel");
            }
            else if (Int32.Parse(str) == 1 || Int32.Parse(str) == 2 ||
                Int32.Parse(str) == 3 || Int32.Parse(str) == 4 ||
                Int32.Parse(str) == 5 || Int32.Parse(str) == 6 ||
                Int32.Parse(str) == 7 || Int32.Parse(str) == 8 ||
                Int32.Parse(str) == 9 || Int32.Parse(str) == 0 )
            {
            Console.WriteLine("digit");
            }
            else
            {
            Console.WriteLine("other");
            }
        }
    }
}