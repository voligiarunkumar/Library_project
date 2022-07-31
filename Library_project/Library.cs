using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_project
{
    internal class Library
    {
        protected List<Book> _books;
    }
    class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
    }
}
