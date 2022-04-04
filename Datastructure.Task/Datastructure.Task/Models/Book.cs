using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructure.Task
{
    class Book:Product
    {
        

        public string AuthorName { get; set; }
        public int PageCount { get; set; }

        
        public Book(string name, string authorName, int pageCount, double price ) 
        { 
            Name = name;
            Price = price;
            AuthorName = authorName;
            PageCount = pageCount;

        }

        public override void Sell()
        {
            ProductCountIsZeroException(Count);
            Count--;
            TotalIncome++;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} \n" +
                $"Author Name: {AuthorName} \n" +
                $"Page Count: {PageCount} \n" +
                $"Price: {Price} \n" +
                $"Count: {Count} \n" +
                $"Total Income: {TotalIncome}");
        }
        public override string ToString()
        {
            return $"Name: {Name} \n" +
                $"Author Name: {AuthorName} \n" +
                $"Page Count: {PageCount} \n" +
                $"Price: {Price} \n" +
                $"Count: {Count} \n" +
                $"Total Income: {TotalIncome}";
        }

    }
}
