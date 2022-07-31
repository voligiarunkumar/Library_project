using System;
using System.Collections.Generic;
#pragma warning disable CS0219
namespace ConsoleApp1
  {
    //Defining a class Book
    class Book
    {
        public int bookId;
        public string bookName;
        public int bookPrice;
        public int bookCount;
        public int x;
    }
    class Newspaper
    {
        public int newspaperId;
        public string newspaperName;
        public int newspaperPrice;
        public int newspaperCount;
        public int x;
    }
    //Defining a class Borrow
    class BorrowDetails
    {

       // public int userId;
        public string userName;
        // public string userAddress;
        public int borrowBookId;
        public DateTime borrowDate;
        public int borrowCount;
    }
    class BorrowNewspaper
    {
       // public int userIdn;
        public string userName;
       
        public int borrowNewspaperId;
        public DateTime borrowDate;
        public int borrowCount;
    }

    class Program
    {
      /*  static List<Book> bookList = new List<Book>();
        static List<BorrowDetails> borrowList = new List<BorrowDetails>();
        static List<Newspaper> newspaperList= new List<Newspaper>();
        
        static Book book = new Book();
        static Newspaper newspaper = new Newspaper();
        static BorrowDetails borrow = new BorrowDetails();
        static BorrowNewspaper borrown = new BorrowNewspaper();
       */
      


       public static void Main(string[] args)
        {

            Program obj = new Program();
            obj.main();

        }
        public void main()
        {
            Console.WriteLine("**************************MAIN MENU****************");
            Console.WriteLine("Choose The options by entering charecter:");

            Console.WriteLine("------------->a.Books\n" + "" +
                              "------------->b.Newspaper\n" + "" +
                              "-------------->c.Close");
            char ch;
            Console.WriteLine("Enter an alphabet");
            ch = Convert.ToChar(Console.ReadLine());
            Librarian object1 = new Librarian();

            Program pobj = new Program();

            switch (Char.ToLower(ch))
            {
                case 'a':
                    
                    
                    pobj.demo();
                    break;
                case 'b':
                    
                    
                    pobj.demon();
                    break;
                case 'c':
                    Console.WriteLine("*********************Thank you********************");
                    break;
            }
        }
        public void demo()
        {
            Console.WriteLine("***************************Books************************");
            Console.WriteLine("Choose The option by entering character");

            Console.WriteLine("---------->a.Librarian\n" + " " + 
                              "---------->b.Borrower\n" + " " +
                              "---------->c.Close");

            char ch;
            Console.WriteLine("Enter an alphabet");
            ch = Convert.ToChar(Console.ReadLine());
            Librarian object1 = new Librarian();
            Borrower object2 = new Borrower();

            switch (Char.ToLower(ch))
            {
                case 'a':
                    Console.WriteLine("**************************Librarian*******************");
                     Console.WriteLine("-------------------------------------------------------");
                    object1.Librarian1();
                    break;
                case 'b':
                    Console.WriteLine("**************************Borrower********************");
                     Console.WriteLine("-------------------------------------------------------");
                      object2.Borrower1 ();     
                      break;
                case 'c':
                   
                    Console.WriteLine("-------------------------------------------------------");
                    main();
                    break;
                
            }
        }
        public  void demon()
        {
            Librarian object1 = new Librarian();
            Borrower object2 = new Borrower();
            Console.WriteLine("*******************************Newspaper*******************************");
            Console.WriteLine("Choose The option by entering character");

            Console.WriteLine("--------->a.Librarian Newspaper\n" + " " + "" +
                             "----------->b.Borrower Newspaper\n" + " " + 
                             "------------>c.Close");

            char ch;
            Console.WriteLine("Enter an alphabet");

            ch = Convert.ToChar(Console.ReadLine());

            switch (Char.ToLower(ch))
            {
                case 'a':
                    
                     object1.Newspaper();
                    break;
                case 'b':
                    Console.WriteLine("---------------------------->>>Borrower<<<------------------------");
                   object2.Newspaperborrower();
                    break;
                case 'c':
                    
                    Console.WriteLine("-------------------------------------------------------");
                    demo();
                    break;
            }
        }
              

   }
}