    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stateless
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var list = new List<string>();

            while( text  != "collapse" )
            {
                var collapseSymbols = Console.ReadLine();

                while(collapseSymbols.Length > 0)
                {
                    text = text.Replace(collapseSymbols, string.Empty);
                    collapseSymbols = collapseSymbols.Remove(collapseSymbols.Length - 1,1);
                    if(collapseSymbols.Length > 0)
                    collapseSymbols = collapseSymbols.Remove(0, 1);
                }
                if (text == string.Empty)
                    text = "(void)";
                
                list.Add(text);
                text = Console.ReadLine();

            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
