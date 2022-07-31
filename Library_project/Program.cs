using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Removelogic ad = new Removelogic();
            Librarin l1 = new CrudOperationOnBook();
            Console.Write("\n::Add Book::\nPlease Enter New Booking ID: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please Enter New Book Name: ");
            string b = Console.ReadLine();
            ad.AddNew(bl, a, b);
           
        }
        static public void viewbook()
        {
            ;
            Console.WriteLine("\n::Books Available Are as Follows::\n");
            foreach (Book c in )
            {
                Console.WriteLine($"Book ID - {c.BookId}\tBook Name - {c.BookName}");
            }
        }
    }
}
