using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>();

            var currValue = Console.ReadLine().Split(new char[] { '-', ' ', '>' }, StringSplitOptions.RemoveEmptyEntries);

            while(currValue[0] != "end")
            {
                dict[currValue[0]] = currValue[1];
                currValue = Console.ReadLine().Split(new char[] { '-', ' ', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }
            var word = Console.ReadLine();

            var nullDict = dict.Where(x => x.Value == "null").ToDictionary(x=> x.Key, x=> word);
            var unchangedWords = dict.Where(x => x.Value != "null").OrderByDescending(x => x.Value.Length);

         var finalDict =   unchangedWords.Concat(nullDict);

            foreach (var item in finalDict)
            {
                Console.WriteLine(item.Key + " <-> "+ item.Value);
            }
        }
    }
}
