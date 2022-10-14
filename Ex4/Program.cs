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
            reg2.items= 0;

            Console.WriteLine("Adding item worth 3.40 to cash registor 1");
            Console.WriteLine("Adding item worth 9.56 to cash registor 1");
            Console.WriteLine("Adding item worth 1.31 to cash registor 1");
            reg1.AddItem(3.40);
            reg1.AddItem(9.56);
            reg1.AddItem(1.31);

            Console.WriteLine("Adding item worth 12.80 to cash registor 2");
            Console.WriteLine("Adding item worth 3.76 to cash registor 2");
            Console.WriteLine("Adding item worth 56.62 to cash registor 2");
            reg2.AddItem(12.80);
            reg2.AddItem(3.76);
            reg2.AddItem(56.62);

            Console.WriteLine("Cash registor Reg1 total: {0}", reg1.total);
            Console.WriteLine("Cash registor Reg1 total number of items: {0}", reg1.items);
            Console.WriteLine("Cash registor Reg2 total: {0}", reg2.total);
            Console.WriteLine("Cash registor Reg2 total number of items: {0}", reg2.items);
        }
    }
}
