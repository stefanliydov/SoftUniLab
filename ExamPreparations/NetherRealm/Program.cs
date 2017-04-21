using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
namespace NetherRealm
{
    class Program
    {
        static void Main(string[] args)
        {
            var demons = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            var healthRegex = new Regex(@"[^0-9+\-\*/\.]");
            var damageNumberRegex = new Regex(@"-?\d+\.?\d*");
            var multipliRegex = new Regex(@"[\/\*]");

            SortedDictionary<string, Demon> demonString = new SortedDictionary<string, Demon>();

            foreach (var demon in demons)
            {
            
                
                var health = 0;
                double damage = 0.00;

                var healthPoints = demon.Where(s => !char.IsDigit(s) 
                && s != '+' 
                && s != '-' 
                && s != '*' 
                && s != '/' 
                && s != '.');
                foreach (var healthPoint in healthPoints)              
                    health += healthPoint;

                var damageNumbers = damageNumberRegex.Matches(demon);
                foreach (Match damageNumber in damageNumbers)           
                    damage += double.Parse(damageNumber.Value);

                var multisigns = demon.Where(s => s == '*' || s == '/');
                foreach (var multisign in multisigns)
                {
                    if (multisign == '*')
                        damage *= 2;
                    else if (multisign == '/')
                        damage /= 2;
                }
                Demon currDemonStats = new Demon()
                {
                    Name = demon,
                    Health = health,
                    Damage = damage
                };
                demonString.Add(demon, currDemonStats);
            }
            foreach (var demon in demonString)
            {
                Console.WriteLine($"{demon.Key} - {demon.Value.Health} health, {demon.Value.Damage:f2} damage" );
            }
        }
        class Demon
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public double Damage { get; set; }
        }
    }
}
