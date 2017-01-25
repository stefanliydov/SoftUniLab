using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
       
                int input = int.Parse(Console.ReadLine());
            string inputString = input.ToString();
            string revers = string.Empty;
                for (int i = inputString.Length - 1; i >= 0; i--)
                {
                revers += inputString[i];
                    Console.Write(inputString[i]);
                }
            var toNum = Convert.ToInt32(revers);
           
            }
    }
}
