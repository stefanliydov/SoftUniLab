using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumberSumsSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var k = long.Parse(Console.ReadLine());

            var seq = new long[n];
            seq[0] = 1;
            
            for (int i =0; i< n; i++)
            {
                long sum = 0;
                for (long index = i; index >=i-k;index--)
                {
                    if (index < 0)
                        break;
                    sum += seq[index];
                    seq[i] = sum;


                }
                Console.WriteLine(sum);

            }    
        }
    }
}
