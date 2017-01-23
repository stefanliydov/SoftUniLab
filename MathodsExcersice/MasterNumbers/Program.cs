using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
        }

        static int ReverseNumber(int num)
        {
            var numString = num.ToString();
            var reversedString = string.Empty;
            for(int i =0; i >= numString.Length -1; i--)
            {
                reversedString += numString[i];
            }

            var reversedNum = int.Parse(reversedString);
            return reversedNum;
        }
        static void SumOfDigitsDevBySeven(int num)
        {
            var sum = 0; 

            while (num > 0)
            {
                var digit = num % 10;
                sum += digit;
                num /= 10; 
            }
            if (sum % 7 == 0)
               Console.WriteLine(sum);                             
        }
      }
}
