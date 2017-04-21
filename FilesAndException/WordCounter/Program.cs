using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordsToCount = File.ReadAllText("myfile.txt").ToLower().Split();
            var words = File.ReadAllText("file2.txt").ToLower().Split(new char[]  { '\n', '\r', ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);


            var dict = new Dictionary<string, int>();
            
            foreach (var word in words)
            {
                foreach (var item in wordsToCount)
                {
                    if (word == item)
                    {
                        if (!dict.ContainsKey(word))
                            dict[word] = 1;
                        else
                            dict[word] ++;
                    }
                }
            }


            var newList = dict.OrderByDescending(x => x.Value).Select(x => $"{x.Key} - {x.Value}").ToArray();
            File.AppendAllLines("result.txt", newList);
            Console.WriteLine(File.ReadAllText("result.txt"));
        }
    }
}
