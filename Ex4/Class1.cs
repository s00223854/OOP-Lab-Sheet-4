using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class CashRegister
    {
        public decimal total { get; set; }

        public int items { get; set; }

        public void AddItem(decimal price)
        {
            total += price;
            items++;
        }

        public void displayinfo()
        {
            Console.WriteLine($"Cash registor ")
        }
    }
}
