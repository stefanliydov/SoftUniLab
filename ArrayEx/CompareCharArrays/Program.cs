using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');
            if (firstArray.Length != secondArray.Length)
            {
                char[] maxLenght = new char[Math.Max(firstArray.Length, secondArray.Length)];
                char[] minLenght = new char[Math.Min(firstArray.Length, secondArray.Length)];

                if (firstArray.Length > secondArray.Length)
                {

                    for (int i = 0; i < Math.Max(firstArray.Length, secondArray.Length); i++)
                        maxLenght[i] = char.Parse(firstArray[i]);
                    for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
                        minLenght[i] = char.Parse(secondArray[i]);
                }
                else if (firstArray.Length < secondArray.Length)
                {

                    for (int i = 0; i < Math.Max(firstArray.Length, secondArray.Length); i++)
                        maxLenght[i] = char.Parse(secondArray[i]);
                    for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
                        minLenght[i] = char.Parse(firstArray[i]);
                }



                for (int i = 0; i <= minLenght.Length -1; i++)
                {
                    if (i == (minLenght.Length - 1))
                    {
                        if (minLenght[i] == maxLenght[i])
                        {
                            Console.WriteLine(string.Join("", minLenght));
                            Console.WriteLine(string.Join("", maxLenght));
                            break;
                        }
                        else if (maxLenght[i] > minLenght[i])
                        {
                            Console.WriteLine(string.Join("", minLenght));
                            Console.WriteLine(string.Join("", maxLenght));
                            break;
                        }
                        else if (maxLenght[i] < minLenght[i])
                        {
                            Console.WriteLine(string.Join("", maxLenght));
                            Console.WriteLine(string.Join("", minLenght));
                            break;
                        }
                    }

                    else if (maxLenght[i] > minLenght[i])
                    {
                        Console.WriteLine(string.Join("", minLenght));
                        Console.WriteLine(string.Join("", maxLenght));
                        break;
                    }
                    else if (maxLenght[i] < minLenght[i])
                    {
                        Console.WriteLine(string.Join("", maxLenght));
                        Console.WriteLine(string.Join("", minLenght));
                        break;
                    }

                }
            }
            else
            {
                char[] firstChar = new char[Math.Max(firstArray.Length, secondArray.Length)];
                char[] secondChar = new char[Math.Min(firstArray.Length, secondArray.Length)];

                for (int i = 0; i <= firstArray.Length-1; i++)
                {
                    firstChar[i] =char.Parse( firstArray[i]);
                    secondChar[i] = char.Parse(secondArray[i]);

                }

                for (int i = 0; i < firstChar.Length-1; i++)
                {
                    if (firstChar[i] >= secondChar[i])
                    {
                        Console.WriteLine(string.Join("", secondChar));
                        Console.WriteLine(string.Join("", firstChar));
                        break;
                    }
                    else if (firstChar[i] < secondChar[i])
                    {
                        Console.WriteLine(string.Join("", firstChar));
                        Console.WriteLine(string.Join("", secondChar));
                        break;
                    }
                }

            }


        }
    }
}
