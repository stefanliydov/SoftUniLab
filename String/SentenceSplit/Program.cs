using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var symbol = Console.ReadLine().Trim().ToCharArray();

            var textArr = text.Split(symbol[0]);
            Console.WriteLine("["+string.Join(",", textArr)+"]");

        }
    }
}
