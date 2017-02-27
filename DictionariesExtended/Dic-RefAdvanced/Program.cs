using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dict_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<int>>();
            var currComm = Console.ReadLine().Split(new char[] { ' ', '-','>',',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (currComm[0] != "end")
            {
                var name = currComm[0];
                int n;
                bool isNumberic = int.TryParse(currComm[1], out n);
                string values = currComm[1];
                if (isNumberic == true)
                {
                    var list = new List<int>();
                    for (int i = 1; i < currComm.Count; i++)
                    {
                        list.Add(int.Parse(currComm[i]));
                    }

                    if (!dict.ContainsKey(name))
                    {
                        dict[name] = list;
                    }
                    else
                        dict[name].AddRange(list);
                }
                else
                {
                    if (dict.ContainsKey(values))
                    {
                        var list = new List<int>();
                        dict[name].AddRange(dict[values]);
                    }
                    else
                    {

                    }
                }
     
                currComm = Console.ReadLine().Split(new char[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            foreach (var item in dict)
                Console.WriteLine(item.Key + " === " + string.Join(", ", item.Value));

        }
    }
}
