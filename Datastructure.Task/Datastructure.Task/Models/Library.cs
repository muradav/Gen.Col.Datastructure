using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datastructure.Task.Models
{
    internal class Library:Exceptions
    {
        public int BookLimit { get; set; }
        public int Count { get; set; }

        private Book[] books;


      
        public Library(int bookLimit)
        {
            BookLimit=bookLimit;
            books = new Book[bookLimit];
        }

        public void AddBook(Book book)
        {
            if (Count == BookLimit)
            {
                CapacityLimitException(BookLimit, Count);
                return;
            }
            books[Count] = book;
            Count++;
        }

        public void GetBookByID(int? id)
        {
            bool check = false;
            foreach (Book item in books)
            {
                if (id == item.ID)
                {
                    check = true;
                    Console.WriteLine(item);
                }
                if (id==null)
                {
                    check = true;
                    throw new NullReferenceException();
                }
            }
            if (check==false)
            {
                Console.WriteLine(" ");
            }
            
        }

        public void RemoveByID(int id)
        {
            foreach (var item in books)
            {
                if (id==item.ID)
                {
                    books = books.Where((books, index) => index != id).ToArray();
                }
                else
                {
                    NotFoundException(id);
                }
            }
            

        }
    }
}
