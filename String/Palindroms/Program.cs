using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindroms
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            var palindroms = new HashSet<string>();
            foreach (var word in text)
            {
                var revWord = ReverseWord(word);

                if (revWord == word)
                    palindroms.Add(word);
            }
            var sortedPalList = palindroms.OrderBy(x => x);

            Console.WriteLine(string.Join(", ",sortedPalList));
        }
        static public string ReverseWord (string s )
        {
            var rev = s.ToCharArray();
            Array.Reverse(rev);
            return new string(rev); 
        }
    }
}
