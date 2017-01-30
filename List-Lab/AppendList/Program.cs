using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split('|').ToList();
            input.Reverse();
            var result = new List<string>();

            foreach (var numbers in input)
            {
                List<string> num = numbers.Split(' ').ToList();

                foreach (var item  in num)
                {
                    if(item!="")
                    result.Add(item);
                }
            }
            Console.WriteLine(String.Join(" ",result));
           
        }
    }
}
