using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSumAfterExtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = Console.ReadLine().Split().ToList();
            var secondList = Console.ReadLine().Split().ToList();

            for (int i = 0; i < firstList.Count; i++)
            {
                if (secondList.Contains(firstList[i]))
                    secondList.Remove(firstList[i]);
            }
            var firstListSum = 0;
            var secondListSum = 0;
            foreach (var item in firstList)
                firstListSum += int.Parse(item);
            foreach (var item in secondList)
            {
                secondListSum += int.Parse(item);
            }
            if (firstListSum == secondListSum)
            {
                Console.WriteLine("Yes. Sum: " + firstListSum);
            }
            else
                Console.WriteLine("No. Diff: " + (Math.Abs(firstListSum - secondListSum)));
        }
    }
}
