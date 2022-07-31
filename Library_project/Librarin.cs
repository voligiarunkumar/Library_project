using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Library_project
{
     class Librarin : Library
    {
        public Librarin()
        {
            AddBook(new Book() {BookId=1,BookName="arun"});
            AddBook(new Book() { BookId = 1, BookName = "Avenger Secret War" });
            AddBook(new Book() { BookId = 2, BookName = "Black Adam" });
            AddBook(new Book() { BookId = 3, BookName = "Shazam" });
            AddBook(new Book() { BookId = 4, BookName = "GOT" });
            AddBook(new Book() { BookId = 5, BookName = "IronHeart" });


        }
        public void AddBook(Book newbook)
        {
            if (_books == null)
            {
                _books = new List<Book>();
            }
            _books.Add(newbook);
        }
        class CrudOperationOnBook : Librarin, IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                if (_books != null)
                {
                    foreach (Book AvailableBook in _books)
                    {
                        yield return AvailableBook;
                    }
                }

                else
                {
                    yield break;
                }
            }
        }
    }
}
