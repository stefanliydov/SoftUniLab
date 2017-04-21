using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeString
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputText = Console.ReadLine();

            Dictionary<char, string> serialSymbols = new Dictionary<char, string>();

            for (int i = 0; i < inputText.Length; i++)
            {
                if (!serialSymbols.ContainsKey(inputText[i]))
                    serialSymbols.Add(inputText[i], i + "/");
                else
                    serialSymbols[inputText[i]] += i + "/";
            }
            foreach (var item in serialSymbols)
            {
                Console.WriteLine(item.Key +":"+ item.Value.TrimEnd('/'));
            }
        }
    }
}
