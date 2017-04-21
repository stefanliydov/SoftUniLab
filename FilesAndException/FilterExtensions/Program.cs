using System;
using System.IO;

namespace FilterExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            var ext = Console.ReadLine();


            var directory = Directory.GetFiles("input");
           
            foreach (var item in directory)
            {
                var fileInfo = new FileInfo(item);
                var extSplit = fileInfo.Name.Split('.');
                for (int i = 1; i < extSplit.Length; i++)
                {
                    if (extSplit[i] == ext)
                        Console.WriteLine(string.Join("",extSplit));
                }
            }
        }
    }
}
