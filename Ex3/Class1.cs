using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class  BankAccount
    {
        private int accountNumber;

        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        private string accountHolder;

        public string AccountHolder
        {
            get { return this.accountHolder; }
            set { this.accountHolder = value; }
        }

        private double balance;

        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public void deposit(double amount)
        {
            Balance += amount;
        }

        public void withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
        }

        public void displayinfo()
        {
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Account Holder: {accountHolder}");
            Console.WriteLine($"Balance: {balance}");
        }
    }
}
