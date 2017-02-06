using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrarySecondsAttempt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
        }
    }
    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
    public class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public string releaseDate { get; set; }
        public string ISBNnumber { get; set; }
        public double price { get; set; }

    }
}
