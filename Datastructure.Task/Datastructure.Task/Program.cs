using Datastructure.Task.Models;
using System;

namespace Datastructure.Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("ABC", "Murad", 32, 35);
            book1.Count = 3;
            book1.Sell();

            Book book2=new Book("ABCD", "Azad", 222, 76);
            book2.Count = 6;
            book2.Sell();

            Book book3 = new Book("ABCDE", "Anar", 122, 84);
            book3.Count = 2;
            book3.Sell();

            Library library = new Library(3);
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            
            library.GetBookByID(2);
            library.RemoveByID(4);
            
            
             
            

           
            
        }
    }
}
