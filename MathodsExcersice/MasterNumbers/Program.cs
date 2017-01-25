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
             
             
            for (int i = 232; i <= num; i++)
            {
                
                if (ReverseNumber(i) == true && SumOfDigitsDevBySeven(i) == true && EvenDigit(i) == true)
                     Console.WriteLine(i);
            }

        }

        static bool ReverseNumber(int num)
        {
            var numString = num.ToString();
            if (numString.Length < 4 && numString[0] == numString[numString.Length - 1])
                return true;
            else if (numString.Length < 6 && numString[0] == numString[numString.Length - 1] && numString[1] == numString[numString.Length - 2])
                return true;
            else if (numString.Length < 8 && numString[0] == numString[numString.Length - 1] && numString[1] == numString[numString.Length - 2]
                && numString[2] == numString[numString.Length - 3])
                return true;
            else
                return false;
           
        }
        static bool SumOfDigitsDevBySeven(int num)
        {
            var sum = 0; 

            while (num > 0)
            {
                var digit = num % 10;
                sum += digit;
                num /= 10; 
            }
            if (sum % 7 == 0)
                return true;
            else
                return false;                                   
        }
        public static bool EvenDigit(int num)
        {
            var checker = 0;
            var evenDigit = 0;
            while (num> 0)
            {
                checker = num % 10;
                num /= 10;
                if (checker % 2 == 0)
                {
                    evenDigit = checker;
                    return true;
                }
                
            }
            return false;
        }
       

    }
}
