using System;
using System.Security.Cryptography.X509Certificates;

namespace Accountsapp
{
    public class Account
    {
        private int Id;
        private string _name;
        private decimal _balance;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 15)
                    throw new ApplicationException("Name is too big");
                _name = value;  
            }
        }
        
        public decimal Balance
        {
            get { return _balance; }


        }

        public void create(int id, string name, decimal balance)
        {
            Id = id;
            _name = name;
            _balance = balance;
            Console.WriteLine("acc created successfully");
        }

        public void display()
        {
            Console.WriteLine("id is " + Id);
            Console.WriteLine("name is " + Name);
            Console.WriteLine("salary is " + Balance  );
        }

        public void deposite(decimal amount) 
        {
            _balance = amount + Balance;
            Console.WriteLine(Balance);
        }

        public void withdraw(decimal amount1)
        {
            if(Balance-amount1 <500)
            {
                Console.WriteLine("insufficient balance");
            }
            else
            {
                _balance=Balance-amount1;
                Console.WriteLine("balance is" + Balance);
            }
            

        }
    }
}