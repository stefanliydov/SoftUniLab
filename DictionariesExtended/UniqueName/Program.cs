using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueName
{
    class Program
    {
        static void Main(string[] args)
        {
            var hash = new HashSet<string>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var currString = Console.ReadLine();
                hash.Add(currString);
            }
            foreach (var item in hash)
            {
                Console.WriteLine(item);
            }
        }
    }
}
