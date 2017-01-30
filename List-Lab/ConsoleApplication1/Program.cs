using System;
using System.Collections.Generic;
using System.Linq;


  namespace ConsoleApplication1
{
   public class Program
    {
        public static void Main(string[] args)
        {
            var number = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

        }
    }
}
