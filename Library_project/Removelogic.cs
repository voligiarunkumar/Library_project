using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_project
{
    internal class Removelogic
    {
        public void AddNew(object d, int i, string b)
        {
            if (d is CrudOperationOnBook)
            {
                CrudOperationOnBook cd = d as CrudOperationOnBook;
                cd.AddBook(new Book() { BookId = i, BookName = b });
                Console.WriteLine("Book Added Successfully");
            }
        }
    }
}
