using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CashRegister reg1 = new CashRegister();
            reg1.total = 0;
            reg1.items = 0;

            CashRegister reg2 = new CashRegister();
            reg2.total = 0;
            reg2.items = 0;
        }
    }
}
