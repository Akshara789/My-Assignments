using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountsapp
{
    public  class Program
    {
        static void Main(string[] args)
        {
            int ch;
            Account a = null;

            do
            {
                Console.WriteLine("******************");
                Console.WriteLine("1.Create Account");
                Console.WriteLine("2.Display Account Information");
                Console.WriteLine("3.Display bank balance");
                Console.WriteLine("4.Withdraw");
                Console.WriteLine("5.Balance amount");
                Console.WriteLine("0. Quit");
                Console.WriteLine("Enter your choice");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("enter the id");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter name");
                        string name = Console.ReadLine();
                        Console.WriteLine("enter balance");
                        decimal balance = decimal.Parse(Console.ReadLine());
                        a = new Account();

                        a.create(id, name, balance);
                        break;
                    case 2:
                        if (a != null)
                        {
                            a.display(); 
                        }
                        else
                        {
                            Console.WriteLine("create account first");
                        }
                        break;

                    case 3:
                        if (a != null)
                        {
                            Console.WriteLine("enter amount");
                            decimal amount = decimal.Parse(Console.ReadLine());
                            a.deposite(amount);
                        }

                        break;
                    case 4:
                        if (a != null)
                        {
                            Console.WriteLine("enter amount");
                            decimal amount1 = Decimal.Parse(Console.ReadLine());
                            a.withdraw(amount1);
                        }
                        else
                        {
                            Console.WriteLine("create acc first");
                        }

                        break;
                    
                    case 0:
                        a = null;
                        break;

                    default:
                        Console.WriteLine();
                        break;
                }
            }


                        

             while(ch!=0);   
            
            
               
                    
                  
                  
                  

            
           

        }
    }
}
