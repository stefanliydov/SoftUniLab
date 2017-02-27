using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListZipper
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var smallest = GetSmallestListValue(firstList,secondList);
            var digitCount = CountDigist(smallest);
            RemoveAllBiggerNumber(firstList, secondList, digitCount);
            if (secondList.Count >= firstList.Count)
            {
                for (int i = firstList.Count - 1; i >= 0; i--)
                {

                    secondList.Insert(i + 1, firstList[i]);

                }
                Console.WriteLine(string.Join(" ", secondList));
            }
            else
            {
                for (int i = secondList.Count - 1; i >= 0; i--)
                {

                    firstList.Insert(i, secondList[i]);
                }
                Console.WriteLine(string.Join(" ", firstList));
            }

        }

        private static void RemoveAllBiggerNumber(List<int> firstList, List<int> secondList, int digitCount)
        {
            for (int i = 0; i < firstList.Count; i++)
            {
                var count = 0;
                var test = firstList[i];
                while (test > 0)
                {
                  test = test / 10;
                    count++;
                }
                if (count > digitCount)
                { firstList.RemoveAt(i);
                    i--;
                }
                count = 0;
            }
            for (int i = 0; i < secondList.Count; i++)
            {
                var count = 0;
                var test =secondList[i];
                while (test > 0)
                {
                    test =test / 10;
                    count++;
                }
                if (count > digitCount)
                {
                    secondList.RemoveAt(i);
                    i--;
                }
                count = 0;
            }
        }

        private static int CountDigist(int smallest)
        {
            var digitCounter = 0;
            while (Math.Abs(smallest) > 0)
            {
                smallest /= 10;
                digitCounter++;
            }
            return digitCounter;

        }

        private static int GetSmallestListValue(List<int> firstList, List<int> secondList)
        {
            var smallest = int.MaxValue;
            for (int i = 0; i < firstList.Count; i++)
            {
                if (Math.Abs(firstList[i]) < smallest)
                    smallest = firstList[i];
            }
            for (int i = 0; i < secondList.Count; i++)
            {
                if (Math.Abs(secondList[i]) < smallest)
                    smallest = secondList[i];
            }
            return smallest;
        }
    }
}
