using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> BankAccounts = new List<BankAccount>();

            var input = Console.ReadLine();

            while(input != "end")
            {
                var splitted = input.Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var bankName = splitted[0];
                var accountName = splitted[1];
                decimal accountBalance = decimal.Parse(splitted[2]);
                BankAccount currBankAcc = new BankAccount()
                {
                    BankName = bankName,
                    AccountName = accountName,
                    AccountBalance = accountBalance
                };
                BankAccounts.Add(currBankAcc);
                input = Console.ReadLine();
            }

          var sorted = BankAccounts.OrderByDescending(x => x.AccountBalance).ThenBy(x => x.BankName).ToList();
            foreach (var account in sorted)
            {
                Console.WriteLine("{0} -> {1} ({2})", account.AccountName, account.AccountBalance, account.BankName);
            }
        }
        class BankAccount
        {
            public string BankName { get; set; }
            public string AccountName { get; set; }
            public decimal AccountBalance { get; set; }
        }
    }
}
