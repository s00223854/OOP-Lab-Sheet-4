using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount a1 = new BankAccount();
            a1.AccountNumber = 123;
            a1.AccountHolder = "Bob";
            a1.Balance = 20.1;

            BankAccount a2 = new BankAccount();
            a2.AccountNumber = 456;
            a2.AccountHolder = "Beth";
            a2.Balance = 932.0;


            Console.WriteLine("Adding 10 to account 1");
            a1.deposit(10);
            a1.displayinfo();

            Console.WriteLine("Withdrawing 500 from account 2");
            a2.withdraw(500);
            a2.displayinfo();
        }
    }
}
