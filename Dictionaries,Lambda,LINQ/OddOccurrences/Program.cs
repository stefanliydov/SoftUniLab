using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split(' ');

            var wordCount = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (!wordCount.ContainsKey(word))
                    wordCount[word] = 0;
                wordCount[word]++;
            }
            var result = new List<string>();
            foreach (var word in wordCount)
            {
                if (word.Value % 2 != 0)
                    result.Add(word.Key);
            }

            Console.WriteLine(string.Join(",", result));
        }
    }
}
