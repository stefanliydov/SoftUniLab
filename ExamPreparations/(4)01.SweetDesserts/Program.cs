using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_01.SweetDesserts
{
    class Program
    {
        static void Main(string[] args)
        {
            var cash = decimal.Parse(Console.ReadLine());
            var guests = int.Parse(Console.ReadLine());
            var bananaPrice = decimal.Parse(Console.ReadLine());
            var eggPrice = decimal.Parse(Console.ReadLine());
            var berrisPricePerKilos = decimal.Parse(Console.ReadLine());
            
            decimal desserts = Math.Ceiling((decimal)guests / 6);

            decimal bananasNeededPrice = desserts * 2 * bananaPrice;
            decimal eggsNeededPrice = desserts * 4 * eggPrice;
            decimal barriesNeededPrice = desserts * (0.2M * berrisPricePerKilos);

            var totalPrice = bananasNeededPrice + eggsNeededPrice + barriesNeededPrice;

            if( totalPrice <= cash)
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.",totalPrice);
            else
            {
                var neededMoney = totalPrice - cash;
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", neededMoney);
            }




        }
    }
}
