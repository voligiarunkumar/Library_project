using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Borrower:Librarian
    {
        
      
        public  void Borrower1()
        {
            Program obj2 = new Program();
           
            Console.WriteLine("\n***********************************Menu********************************\n" +
            "1)---------------->Borrow book\n" +
            "2)----------------->Return book\n" +
            "3)------------------> Borrowlist\n"+"" +
            "4)------------------>Close");
            Console.Write("Choose your option from menu :");

            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Borrow();
            }
            else if (option == 2)
            {
                ReturnBook();
            }
            else if(option ==3)
            {
                Borrowbooklist();
            }

            else if (option == 3)
            {
                Console.WriteLine("Thank you");
               obj2.demo();
            }
        }
  
         public void Newspaperborrower()
        {
            
            Program obj3 = new Program();
            Console.WriteLine("\n**********************Menu**********\n"+"" +
                "1)------>Borrow Newspaper\n"+"" +
                "2)------>Return Newspaper\n"+
                "3)------->Show newspapers\n"+"" +
                "4)------->Show borrow news paper list\n"+
                "5)------->close\n");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Choose your option from menu :");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                BorrowNewspaper();
            }
            else if(option == 2)
            {
                ReturnNewspaper();
            }
            else if(option==3)
            {
                Console.WriteLine("search fro the avalibel newspapers");
                paperSearch();
            }
            else if(option==4)
            {
                Console.WriteLine("borrowed newspapers are:");
                BarrrowNewslist();
            }
            
            else if(option == 5)
            {
                Console.WriteLine("Thank You");
                obj3.demon();
            }
        }

    }
}
