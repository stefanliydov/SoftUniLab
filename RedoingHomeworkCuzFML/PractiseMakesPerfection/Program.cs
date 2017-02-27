using System;
using System.Numerics;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

namespace PractiseMakesPerfection
{
    class Program
    {


        static void Main(string[] args)
        {
            var arrLenghtCount = 1;
            var numbersArr = new string[arrLenghtCount];
            
            var command = Console.ReadLine().ToLower().Split();
            var countToAdd = 0;
            while(command[0] != "end")
            {
                if ( command[0] == "push")
                {
                    numbersArr[countToAdd] = command[1];
                    countToAdd++; 
                    if(numbersArr.Length == countToAdd)
                    {
                        arrLenghtCount *= 2;
                        var newNumbersArr = new string[arrLenghtCount];
                        for (int i = 0; i < numbersArr.Length; i++)
                        {
                            newNumbersArr[i] = numbersArr[i];
                        }
                        numbersArr = new string[arrLenghtCount];
                        for (int i = 0; i < numbersArr.Length; i++)
                        {
                              numbersArr[i]= newNumbersArr[i];
                        }
                    }
                }
               else if(command[0] == "pop")
                {
                    numbersArr[countToAdd - 1] = null;
                    countToAdd--;
                }
                else if(command[0] == "removeat")
                {
                    numbersArr[int.Parse(command[1])] = null;
                    for (int i = int.Parse(command[1]); i < countToAdd-1; i++)
                    {
                        numbersArr[i] = numbersArr[i + 1];
                    }
                    countToAdd--;
                    numbersArr[countToAdd ] = null;
                    
                }
                else if( command[0] == "clear")
                {
                    for (int i = 0; i < numbersArr.Length; i++)
                    {
                        numbersArr[i] = null;
                        countToAdd = 0;
                    }
                }
                command = Console.ReadLine().ToLower().Split();
            }

            if(numbersArr[0] ==null)
                Console.WriteLine("empty array");
            else
            {
                var words = string.Empty;
                foreach (var item in numbersArr)
                {
                    words += item + " ";
                }
                Console.WriteLine(words.Trim());
            }
        }
    }
}
