using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new string[3] { "1", "2", "3" };
            var words = string.Empty;
            foreach (var item in arr)
            {
                words += item + " ";
            }
            Console.WriteLine(words.Trim());
            Console.WriteLine("Sep");
            arr[0] = null;
            arr[1] = null;
            arr[2] = null;
             words = string.Empty;
            foreach (var item in arr)
            {
                words += item + " ";
            }
            Console.WriteLine(words.Trim());
            Console.WriteLine("next line:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (24 + i).ToString();
            }
            foreach (var item in arr)
            {
                words += item + " ";
            }
            Console.WriteLine(words.Trim());
        }
    }
}
