using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer(1, "Peter Thomsen");
            BankAccount acc1 = new BankAccount(1, 8, 100);
            CheckAccount ca1 = new CheckAccount(4, 2, 1, 5, 300);
            EmployeeAccount em1 = new EmployeeAccount(5,0.5,1,5,200);

            c.AddAccount(acc1);
            c.AddAccount(ca1);
            c.AddAccount(em1);
            Console.WriteLine(c.GetTotalBalance());
            ca1.Withdraw(200);
            Console.WriteLine(c.GetTotalBalance());
            em1.Withdraw(3200);
            Console.WriteLine(em1.Disposable);
            Console.WriteLine(c.GetTotalDispose());
            
            Console.ReadLine();
        }
    }
}
