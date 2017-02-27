using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesExtended
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new SortedDictionary<string, long>();
            var command = Console.ReadLine().Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (command[0] != "Over")
            {
                long n;
                bool isNumeric = long.TryParse(command[1], out n);
                var name = String.Empty;
                long number = 0;
                if (isNumeric == true)
                {
                     name = command[0];
                     number = long.Parse(command[1]);
                }
                else
                {
                     name = command[1];
                     number = long.Parse(command[0]);
                }
                 dict[name]= number;


                command = Console.ReadLine().Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            foreach (var item in dict)
            {
                Console.WriteLine( item.Key+ " -> " +item.Value);
            }
        }
    }
}
