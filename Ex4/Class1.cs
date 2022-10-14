using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class CashRegister
    {
        public double total { get; private set; }

        public int items { get; private set; }

        public void AddItem(double price)
        {
            total += price;
            items++;
        }
    }
}
