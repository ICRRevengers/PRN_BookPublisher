using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Models
{
    public class Book
    {
        public string BookID { get; set; }
        public string BookName { get; set; }
        public int Quantity { get; set; }
        public string AuthorName { get; set; }
        public string PublisherID { get; set; }

        public Book(string bookID, string bookName, int quantity, string authorName, string publisherID)
        {
            BookID = bookID;
            BookName = bookName;
            Quantity = quantity;
            AuthorName = authorName;
            PublisherID = publisherID;
        }
        public Book(string bookName, int quantity, string authorName, string publisherID)
        {
            BookName = bookName;
            Quantity = quantity;
            AuthorName = authorName;
            PublisherID = publisherID;
        }
        public Book()
        {
        }
    }
}
