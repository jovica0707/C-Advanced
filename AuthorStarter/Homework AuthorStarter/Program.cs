using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace AuthorStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new AuthorRepo();
            var authors = repo.GetAuthors();
            Console.WriteLine($"There are {authors.Count()} total authors");
            Thread.Sleep(7000);
            Console.WriteLine($"with {authors.SelectMany(a => a.Books).Count()} total books");

            Console.WriteLine("1) How many books are collaborations (have more than one author)?");

            var booksCollabs = authors
                                    .SelectMany(author => author.Books)
                                    .GroupBy(book => book.ID)
                                    .Where(dupl => dupl.Count() > 1)
                                    .ToList();


            Console.WriteLine($"{booksCollabs.Count()} books are collaborations");
            Console.WriteLine("");


            Thread.Sleep(2000);
            Console.WriteLine("2) Which book has the most authors (and how many)?");


            var theAuthors = booksCollabs
                                 .OrderByDescending(num => num.Count())
                                 .First();

            var mostAuthorsBook = theAuthors.First();

            Console.WriteLine($"The book '{mostAuthorsBook.Title}' has {theAuthors.Count()} authors");
            Console.WriteLine("");

            Thread.Sleep(5000);
            Console.WriteLine("3) What author wrote most collaborations?");



            var collabList = authors
                                  .SelectMany(book => book.Books)
                                  .Where(book => (booksCollabs.Select(a => a.Key))
                                  .Any(b => b == book.ID))
                                  .ToList();

            var collabNum = authors
                                  .Select(author => author.Books.Where(books => collabList.Any(book => book.ID == books.ID))
                                  .Count())
                                  .Max();

            var mostCollabAuthor = authors
                                        .Where(author => author.Books
                                        .Where(books => collabList.Any(book => book.ID == books.ID)).Count() == collabNum)
                                        .FirstOrDefault();


            Console.WriteLine($"The author {mostCollabAuthor.Name} has {collabNum} collaborations");
            Console.WriteLine("");


            Console.ReadLine();
        }
    }
}