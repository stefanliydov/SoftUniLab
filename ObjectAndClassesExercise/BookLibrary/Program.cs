using System;
using System.Collections.Generic;
using System.Linq;


namespace BookLibrary
{
   public class Program
    {
       public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            Library library = new Library();
            library.Books = new List<Book>();
            for (int i = 0; i < n; i++)
            {
                var booksInput = Console.ReadLine().Split().ToArray();
                
                Book book = new Book()
                {
                    title = booksInput[0],
                    author = booksInput[1],
                    publisher = booksInput[2],
                    releaseDate = booksInput[3],
                    ISBNnumber = booksInput[4],
                    price = double.Parse(booksInput[5])
                };
                
                library.Books.Add(book);

              }
            var booksByAuthor = new Dictionary<string, List<Book>>();
            foreach (var book in library.Books)
            {
                if (!booksByAuthor.ContainsKey(book.author))
                    booksByAuthor.Add(book.author, new List<Book>());
                
                    booksByAuthor[book.author].Add(book);        
            }
            var AuthorPrice = new Dictionary<string, double>();
            foreach (var author in booksByAuthor)
            {
                string authorName = author.Key;
                double sum = author.Value.Select(x => x.price).Sum();
                AuthorPrice.Add(authorName, sum);
            }
            AuthorPrice.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            foreach (var item in AuthorPrice)
            {
                Console.WriteLine("{0} -> {1:f2}", item.Key, item.Value);
            }
        }
        public class  Library
        {
            public string Name { get; set;  }
            public List<Book> Books { get; set; }
        }
        public class Book
        {
            public string title { get; set; }
            public string author { get; set; }
            public string publisher { get; set; }  
            public string releaseDate { get; set;}
            public string ISBNnumber { get; set; }
            public double price { get; set; }
              
        }
    }
}
