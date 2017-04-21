using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _03_01.SoftUniCoffeeOrders
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());

            var totalSum = 0.0M;
            for (int i = 0; i < n; i++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                var orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsuleCount = int.Parse(Console.ReadLine());

               int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

                var orderPrice = daysInMonth * (long)capsuleCount * pricePerCapsule;
                totalSum += orderPrice;
                Console.WriteLine("The price for the coffee is: ${0:f2}", orderPrice);

            }
            Console.WriteLine("Total: ${0:f2}",totalSum);
        }
    }
}
