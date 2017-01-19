using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            var digit = char.Parse(Console.ReadLine());

            switch (digit)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    Console.WriteLine("digit");
                    break;
                case 'a':
                case 'e':
                case 'y':
                case 'u':
                case 'i':
                case 'o':
                    Console.WriteLine("vowel");
                    break;
                default:
                    Console.WriteLine("other");break;
            }
        }
    }
}
