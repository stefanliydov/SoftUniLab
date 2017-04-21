using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();
            var testText = Console.ReadLine().ToLower();

            var count = 0;
            var index = 0;
            while (true)
            {
                  index = text.IndexOf(testText,index);
                if (index == -1)
                    break;
               
                count++;
                index++;
            }
            Console.WriteLine(count);
        }
    }
}
