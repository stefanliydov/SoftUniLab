using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWord
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ');

            var random = new Random();
            for (int i = 0; i < words.Length; i++)
            {
               var p = random.Next(0, words.Length);


                var temp = words[i];
                words[i] = words[p];
                words[p] = temp;
            }
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
