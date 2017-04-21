using System;
using System.Text.RegularExpressions;

namespace _1_04.WinningTicket1
{
  public  class Program
    {
      public  static void Main(string[] args)
        {
            var tickets = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var regex = new Regex(@"([@#$^])\1{5,}");

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                    Console.WriteLine("invalid ticket");

                else
                {
                    var firstHalf = ticket.Substring(0, 10);
                    var secondHalf = ticket.Substring(10, 10);
                    var firstHalfMatch = regex.Match(firstHalf);
                    var secondHalfMatch = regex.Match(secondHalf);

                    if (firstHalfMatch.Success  && secondHalfMatch.Success )
                    {
                        var symbol = firstHalfMatch.ToString()[1];
                        if (firstHalfMatch.Value == secondHalfMatch.Value)
                        {
                            
                            if (firstHalfMatch.Value.Length == 10)
                                Console.WriteLine($"ticket \"{ticket}\" - 10{symbol} Jackpot!");
                            else
                                Console.WriteLine($"ticket \"{ticket}\" - {firstHalfMatch.Value.Length}{symbol}");
                        }
                        else if(firstHalfMatch.Value.Length > secondHalfMatch.Value.Length) 
                            Console.WriteLine($"ticket \"{ticket}\" - {secondHalfMatch.Value.Length}{symbol}");
                        else if(firstHalfMatch.Value.Length < secondHalfMatch.Value.Length)
                            Console.WriteLine($"ticket \"{ticket}\" - {firstHalfMatch.Value.Length}{symbol}");
                    }
                    else
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    

           

                }
            }
        }
    }
}
