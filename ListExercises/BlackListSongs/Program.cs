using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackListSongs
{
    class Program
    {
        static void Main(string[] args)
        {
            var blackList = Console.ReadLine().Split().ToArray();

            var song = Console.ReadLine();
            var songs = new List<string>();
            while (song != "end")
            {

                bool check = true;
                for (int i = 0; i < blackList.Length; i++)
                {
                    if (song.Contains(blackList[i]))
                        check = false;
                }
                if (check == true)
                    songs.Add(song);
                   
              
                 song = Console.ReadLine();
            }
            songs.Sort();
            foreach (var item in songs)
            {
                Console.WriteLine(item);
            }
        }
    }
}
