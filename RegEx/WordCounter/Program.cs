using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {

            var symbolTimes = Console.ReadLine().ToCharArray();
            var symbol = symbolTimes[0];
            var times = int.Parse(symbolTimes[1].ToString());

            var sentence = Console.ReadLine();
            Regex sentenceCheck = new Regex(@"^[A-Z].*[!.?]$");

            Regex sentenceSplitter = new Regex(@"\w+");
            var list = new List<string>();

            while (sentence != "end")
            {
                 
                if (sentenceCheck.IsMatch(sentence))
                {
                    var matches = sentenceSplitter.Matches(sentence);

                    foreach (Match match in matches)
                    {
                        var currWord = match.Value;
                        var count = 0;
                        for (int i = 0; i < currWord.Length; i++)
                        {
                            if (currWord[i] == symbol)
                                count++;
                        }
                        if (count == times)
                            list.Add(currWord);

                    }


                }

                sentence = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ",list));
        }
    }
}
