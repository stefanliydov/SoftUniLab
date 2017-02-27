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
            var dict = new Dictionary<string, int>();
            var currComm = Console.ReadLine().Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            
            while(currComm[0] != "end")
            {
               var name = currComm[0];
                int n;
                bool isNumberic = int.TryParse(currComm[1], out n);
               string value = currComm[1];
                if (isNumberic == false)
                {
                    if (dict.ContainsKey(value))
                        dict[name] = dict[value];
                    else { }
                }


                else
                    dict[name] = int.Parse(value);



           
                currComm = Console.ReadLine().Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            foreach (var item in dict)
                Console.WriteLine(item.Key+ " === "+ item.Value);
            
        }
    }
}
