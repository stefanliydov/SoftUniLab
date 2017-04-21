using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace RegistersUsers
{
    class Program
    {
        static void Main(string[] args)
        {

            var dict = new Dictionary<string, DateTime>();
            var userLog = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            while(userLog[0] != "end")
            {
                dict[userLog[0]] = DateTime.ParseExact(userLog[1], "dd/MM/yyyy",CultureInfo.InvariantCulture);


                userLog = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            Dictionary<string, DateTime> orderedDict = dict.Reverse().OrderBy(x => x.Value).Take(5).OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in orderedDict)
            {
                Console.WriteLine(item.Key);
            }
        }   

    }
}
