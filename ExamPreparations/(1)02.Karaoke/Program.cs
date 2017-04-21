using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_02.Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var participants = Console.ReadLine().Split(new[] { ' ',',' }, StringSplitOptions.RemoveEmptyEntries);
            var songs = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            songs = TrimArr(songs);
            Dictionary<string, SortedSet<string>> singersAwards = new Dictionary<string, SortedSet<string>>();
          
            var command = Console.ReadLine();

            while(command != "dawn")
            {
                var splitted = command.Split(new[] {',' }, StringSplitOptions.RemoveEmptyEntries);
                var name = splitted[0].Trim();
                var song = splitted[1].Trim();
                var award = splitted[2].Trim();

                if(participants.Contains(name)&& songs.Contains(song))
                {
                    if (!singersAwards.ContainsKey(name))
                    {
                        singersAwards[name] = new SortedSet<string>();
                    }
                    singersAwards[name].Add(award);

                }

                command = Console.ReadLine();
            }

            var sortedSingerAwarsDict = singersAwards.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key);
            if(singersAwards.Count == 0)
                Console.WriteLine("No awards");
            else
            {
                foreach (var person in sortedSingerAwarsDict)
                {
                    Console.WriteLine($"{person.Key}: {person.Value.Count} awards" );
                    foreach (var award in person.Value)
                    {
                        Console.WriteLine("--{0}",award);
                    }
                }
            }

        }
        public static string[] TrimArr(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i].Trim();
            }
            return arr;
        }
    }
}
