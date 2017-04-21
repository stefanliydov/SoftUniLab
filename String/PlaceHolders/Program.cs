    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceHolders
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (input != "end")
            {
                var splited = input.Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var sentence = splited[0].Trim();
                var words = splited[1].Trim().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < words.Length; i++)
                {
                    var replace = "{"+i+"}";
                    sentence = sentence.Replace(replace, words[i]);
                }
                Console.WriteLine(sentence);

                input = Console.ReadLine();
            }
        }
    }
}
