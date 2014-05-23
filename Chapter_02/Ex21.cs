using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

//using System.Data.Linq;
//using System.Data.Linq.Mapping;

namespace Chapter_02
{
    [TestFixture]
    public class Chapter_02_Examples
    {
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public int PublicationYear { get; set; }
        }

        public class PurchaseOrder
        {
            public int OrderNumber { get; set; }
            public string Title { get; set; }
            public int Quantity { get; set; }
        }

        //[Table(Name = "Employees")]
        //public class Employee
        //{
        //    [Column]
        //    public int EmployeeID { get; set; }
        //    [Column]
        //    public string FirstName { get; set; }
        //    [Column]
        //    public string LastName { get; set; }
        //}

        
        [Test]
        public void Example_21_1()
        {
            List<Book> bookList = new List<Book>
                                      {
                                          new Book
                                              {
                                                  Title = "Learning C# 3.0",
                                                  Author = "Jesse Liberty",
                                                  Publisher = "O'Reilly",
                                                  PublicationYear = 2008
                                              },
                                          new Book
                                              {
                                                  Title = "Programming C# 3.0",
                                                  Author = "Jesse Liberty",
                                                  Publisher = "O'Reilly",
                                                  PublicationYear = 2008
                                              },
                                          new Book
                                              {
                                                  Title = "C# 3.0 Cookbook",
                                                  Author = "Jay Hilyard",
                                                  Publisher = "O'Reilly",
                                                  PublicationYear = 2007
                                              },
                                          new Book
                                              {
                                                  Title = "C# 3.0 in a Nutshell",
                                                  Author = "Ben Albahari",
                                                  Publisher = "O'Reilly",
                                                  PublicationYear = 2007
                                              },
                                          new Book
                                              {
                                                  Title = "Head First C#",
                                                  Author = "Andrew Stellman",
                                                  Publisher = "O'Reilly",
                                                  PublicationYear = 2007
                                              },
                                          new Book
                                              {
                                                  Title = "Programming C#, fourth edition",
                                                  Author = "Jesse Liberty",
                                                  Publisher = "O'Reilly",
                                                  PublicationYear = 2005
                                              }
                                      };

            

            //// find books by Jesse Liberty
            //IEnumerable<Book> resultsAuthor =
            //    from testBook in bookList
            //    where testBook.Author == "Jesse Liberty"
            //    select testBook;

            //Console.WriteLine("Books by Jesse Liberty:");
            //foreach (Book testBook in resultsAuthor)
            //{
            //    Console.WriteLine("{0}, by {1}", testBook.Title,
            //    testBook.Author);
            //}

            //// find books published before 2008
            //IEnumerable<Book> resultsDate =
            //    from testBook in bookList
            //    where testBook.PublicationYear < 2008
            //    select testBook;
            //Console.WriteLine("\nBooks published before 2008:");
            //foreach (Book testBook in resultsDate)
            //{
            //    Console.WriteLine("{0}, by {1}, {2}", testBook.Title,
            //    testBook.Author, testBook.PublicationYear);
            //}


            // find books by Jesse Liberty
            var resultsAuthor_2 =
                from testBook in bookList
                where testBook.Author == "Jesse Liberty"
                select new {testBook.Title, testBook.Author};


            Console.WriteLine("\n\nBooks by Jesse Liberty:");
            foreach (var testBook in resultsAuthor_2)
            {
                Console.WriteLine("{0}, by {1}", testBook.Title, testBook.Author);
            }

            // Lambda Expressions
            // find books by Jesse Liberty
            var resultsAuthor_3 = bookList.Where(bookEval => bookEval.Author == "Jesse Liberty");

            Console.WriteLine("\n\nBooks by Jesse Liberty:");
            foreach (var testBook in resultsAuthor_3)
            {
                Console.WriteLine("{0}, by {1}", testBook.Title, testBook.Author);
            }

            // Ordering and Joining
            var resultList =
                from myBook in bookList
                orderby myBook.Author
                select myBook;
            Console.WriteLine("\n\nBooks by author:");
            foreach (var testBook in resultList)
            {
                Console.WriteLine("{0}, by {1}", testBook.Title, testBook.Author);
            }

            List<PurchaseOrder> orderList = new List<PurchaseOrder>
                                                {
                                                    new PurchaseOrder
                                                        {
                                                            OrderNumber = 23483,
                                                            Title = "C# 3.0 Cookbook",
                                                            Quantity = 57
                                                        },
                                                    new PurchaseOrder
                                                        {
                                                            OrderNumber = 57284,
                                                            Title = "Head First C#",
                                                            Quantity = 42
                                                        },
                                                    new PurchaseOrder
                                                        {
                                                            OrderNumber = 56389,
                                                            Title = "Programming C# 3.0",
                                                            Quantity = 12
                                                        },
                                                    new PurchaseOrder
                                                        {
                                                            OrderNumber = 95639,
                                                            Title = "C# 3.0 Cookbook",
                                                            Quantity = 122
                                                        },
                                                    new PurchaseOrder
                                                        {
                                                            OrderNumber = 57493,
                                                            Title = "C# 3.0 in a Nutshell",
                                                            Quantity = 43
                                                        },
                                                    new PurchaseOrder
                                                        {
                                                            OrderNumber = 73558,
                                                            Title = "Programming C# 3.0",
                                                            Quantity = 99
                                                        },
                                                    new PurchaseOrder
                                                        {
                                                            OrderNumber = 45385,
                                                            Title = "C# 3.0 Cookbook",
                                                            Quantity = 35
                                                        },
                                                };

            var resultList2 =
                from myBook in bookList
                join myOrder in orderList on myBook.Title equals myOrder.Title
                where myOrder.Quantity >= 50
                select new {myBook.Title, myBook.Author, myOrder.Quantity};
            Console.WriteLine("Book orders with quantities greater than 50:");
            foreach (var testBook in resultList2)
            {
                Console.WriteLine("Title: {0}\tAuthor: {1} \tQuantity: {2}", testBook.Title, testBook.Author, testBook.Quantity);
            }




        }



        
    }
}
