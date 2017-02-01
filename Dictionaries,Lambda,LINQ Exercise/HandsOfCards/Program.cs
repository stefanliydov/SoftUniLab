using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            var playersPoints = new Dictionary<string, HashSet<int>>();
            var trueCheck = Console.ReadLine();
            var cardPower = CardPower();
            var cardType = CardType(); 
            while (trueCheck != "JOKER")
            {
                var allPlayersCards = trueCheck.Split(':');
                


                var playerName = allPlayersCards[0];
                var cards = allPlayersCards[1].Split(new[] { ","," " }, StringSplitOptions.RemoveEmptyEntries);



               
                foreach (var card in cards)
                {
                    var power = card.Substring(0, card.Length - 1);
                    var type = card.Substring(card.Length-1);
                    var sum = cardPower[power] * cardType[type];
                    if (!playersPoints.ContainsKey(playerName))
                        playersPoints[playerName] = new HashSet<int>();
                    playersPoints[playerName].Add(sum); 
                }
                trueCheck = Console.ReadLine();

            }
            foreach (var player in playersPoints)
            {
              
                Console.WriteLine($"{player.Key}: {player.Value.Sum()}");
            }

        }

        private static Dictionary<string, int> CardType()
        {
            var cardType = new Dictionary<string, int>();

            cardType["S"] = 4;
            cardType["H"] = 3;
            cardType["D"] = 2;
            cardType["C"] = 1;

            return cardType;
        }

        private static Dictionary<string, int> CardPower()
        {
            var cardPowers = new Dictionary<string, int>();

            for (int i =2; i <= 10; i++)            
                cardPowers[i.ToString()] = i;

            cardPowers["J"] = 11;
            cardPowers["Q"] = 12;
            cardPowers["K"] = 13;
            cardPowers["A"] = 14;
            return cardPowers;
        }
    }
}
