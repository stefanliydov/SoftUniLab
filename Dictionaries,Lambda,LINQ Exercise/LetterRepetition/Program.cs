using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine();

            var dict = new Dictionary<char, int>();

            foreach (var symbol in words)
            {
                if (!dict.ContainsKey(symbol))
                    dict[symbol] = 1;
                else
                    dict[symbol] += 1;
            }
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key +" -> "+ item.Value);
            }
        }
    }
}
