using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyAndBilliard
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, decimal> menu = menuGet();

            var customerPurchase = Console.ReadLine();
            SortedDictionary<string, Dictionary<string, int>> customersNameOrderList = new SortedDictionary<string, Dictionary<string, int>>();
            while(customerPurchase !="end of clients")
            {
                Customer customer = new Customer();
                var splited = customerPurchase.Split( new[]{'-',','},StringSplitOptions.RemoveEmptyEntries);
                customer.Name = splited[0];
             
                customer.ShopList[splited[1]] = int.Parse(splited[2]);
                if (menu.ContainsKey(splited[1]))
                    customersNameOrderList[customer.Name] = customer.ShopList;
                customerPurchase = Console.ReadLine();       
            }
            decimal bill = 0; 
            foreach (var customer in customersNameOrderList)
            {
                var name= customer.Key;
                var productQuantity = (customer.Value);
                var product = string.Empty;
                int quantity = 0;
                foreach (var item in customer.Value)
                {
                     product = item.Key;
                     quantity = item.Value;
                }
                var price = menu[product];
                var totalPrice = price * quantity;
                bill += totalPrice;
                Console.WriteLine(name);
                Console.WriteLine($"-- {product} - {quantity}");
                Console.WriteLine("Bill: {0:f2}", totalPrice);
            }
            Console.WriteLine("Total bill: {0:f2}", bill);
            
        }

        private static Dictionary<string, decimal> menuGet()
        {
            var n = int.Parse(Console.ReadLine());
            Dictionary<string, decimal> menu = new Dictionary<string, decimal>();
            for (int i = 0; i < n; i++)
            {
                var productPrice = Console.ReadLine().Split('-');

                menu[productPrice[0]] = decimal.Parse(productPrice[1]);
            }
            return menu;
        }
    }
    public class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> ShopList = new Dictionary<string, int>();
    }
}
