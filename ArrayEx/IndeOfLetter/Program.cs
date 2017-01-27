using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndeOfLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            string arr = Console.ReadLine();


            string[] alpha = new string[]
       {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
            for (int i = 0; i <= arr.Length-1; i++)
            {
                for (int r = 0; r <= alpha.Length-1; r++)
                {
                    if (arr[i].ToString().CompareTo(alpha[r]) == 0)
                    {
                        Console.WriteLine(arr[i] +" -> "+r);
                    }
                }
               
            }
        }
    }
}
