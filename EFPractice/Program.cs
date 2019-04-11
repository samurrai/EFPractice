using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Author authorPushkin = new Author
            {
                Name = "Pushkin"
            };
            Author authorKrylov = new Author
            {
                Name = "Krylov"
            };

            Book bookTales = new Book
            {
                Name = "Tales"
            };

            bookTales.Authors.Add(authorPushkin);
            bookTales.Authors.Add(authorKrylov);

            authorPushkin.Books.Add(bookTales);
            authorKrylov.Books.Add(bookTales);

            var visitorVanya = new Visitor
            {
                Name = "Vanya",
                IsDebtor = true
            };

            visitorVanya.Books.Add(bookTales);


            var visitorPetya = new Visitor
            {
                Name = "Petya",
                IsDebtor = true,
            };
            var authors = new List<Author>();
            authors.Add(new Author {
                Name = "Troelson"
            });
            visitorVanya.Books.Add(new Book() {
                Name = "C# Language",
                Authors = authors
            });
            var visitorDanya = new Visitor
            {
                Name = "Danya",
                IsDebtor = false
            };
            visitorDanya.Books.Add(new Book {
                Name = "Unnamed"
            });
            var visitorMasha = new Visitor
            {
                Name = "Masha",
                IsDebtor = true
            };
            Book bookPoems = new Book()
            {
                Name = "Poems"
            };
            bookPoems.Authors.Add(new Author { Name = "Ivan Dremin" });
            visitorMasha.Books.Add(bookPoems);
            var visitorAnya = new Visitor
            {
                Name = "Anya",
                IsDebtor = false
            };
            visitorAnya.Books.Add(new Book { Name = "History" });

            using (var appContext = new AppContext())
            {
                //appContext.Authors.Add(authorKrylov);
                //appContext.Authors.Add(authorPushkin);
                //appContext.Authors.AddRange(authors);

                //appContext.Books.Add(bookPoems);
                //appContext.Books.Add(bookTales);
                //appContext.Books.Add(new Book { Name = "#1" });

                //appContext.Visitors.Add(visitorAnya);
                //appContext.Visitors.Add(visitorDanya);
                //appContext.Visitors.Add(visitorMasha);
                //appContext.Visitors.Add(visitorPetya);
                //appContext.Visitors.Add(visitorVanya);

                //appContext.SaveChanges();

                Console.WriteLine("Должники: ");
                foreach (var visitor in appContext.Visitors)
                {
                    if (visitor.IsDebtor)
                    {
                        Console.WriteLine(visitor.Name);
                    }
                }
                int index = 1;

                Console.WriteLine("3я книга: ");
                foreach (var book in appContext.Books)
                {
                    if (index == 3)
                    {
                        Console.WriteLine(book.Name);
                        break;
                    }
                    index++;
                }

                Console.WriteLine("Доступные книги: ");
                foreach (var book in appContext.Books)
                {
                    Console.WriteLine(book.Name);
                }

                index = 1;

                Console.WriteLine("Книги 2го клиента: ");
                foreach (var visitor in appContext.Visitors)
                {
                    if (index == 2)
                    {

                        foreach (var book in appContext.Books)
                        {
                            Console.WriteLine(book.Name);
                        }
                        break;
                    }
                    index++;
                }

                foreach (var visitor in appContext.Visitors)
                {
                    visitor.IsDebtor = false;
                }
            }

        }
    }
}
