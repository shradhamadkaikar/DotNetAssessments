using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.ConstructorAssesment
{
    public class Book
    {
        private int bid;
        private string name;
        private double price;
        private string author;

        public Book(int bookId, string bookName, double bookPrice, string bookAuthor)
        {
            this.bid = bookId;
            this.name = bookName;
            this.price = bookPrice;
            this.author = bookAuthor;
        }

        public void Display()
        {
            Console.WriteLine($"Book ID: {bid}");
            Console.WriteLine($"Book Name: {name}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Author: {author}");
        }
    }
}
