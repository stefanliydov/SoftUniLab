
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//04. Files
namespace Files
{
    class Files
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> storage = new Dictionary<string, Dictionary<string, long>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var directorySplit = Console.ReadLine().Split('\\');
                var currRoot = directorySplit[0];
                var fileSplit = directorySplit[directorySplit.Length - 1].Split(';');
                var nameExt = fileSplit[0];
                var size = long.Parse(fileSplit[1]);

                if (!storage.ContainsKey(currRoot))
                   storage[currRoot] = new Dictionary<string, long>();
                
                storage[currRoot][nameExt] = size;

            }
            var searchCommand = Console.ReadLine().Split();
            var ext = searchCommand[0];
            var root = searchCommand[2];
            bool exist = false;
            var sorted = storage.Where(x => x.Key == root).OrderByDescending(x => x.Value.Values).ToDictionary(x => x.Key, y => y.Value);

            foreach (var fileDir in sorted)
            {
                foreach (var s in fileDir.Value.OrderByDescending(x => x.Value).ThenBy(z => z.Key))
                {
                    if (s.Key.Split('.').Last() == ext)
                    {
                        Console.WriteLine($"{s.Key} - {s.Value} KB");
                        exist = true;
                    }
                }
            }
            if(exist == false)
                Console.WriteLine("No");
        }
    }
}