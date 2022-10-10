using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_Sheet_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.CarMake = "Ford";
            c1.CarModel = "Escort";
            c1.CurrentSpeed = 0;
            c1.EngineSize = 1.6;

            Car c2 = new Car();
            c2.CarMake = "Opel";
            c2.CarModel = "Astra";
            c2.CurrentSpeed = 0;
            c2.EngineSize = 1.2;

            c1.DisplayInfo();

            Console.WriteLine(c2);

            for (int i = 0; i < 10; i++)
            {
                c1.Accelerate();
            }

            Console.WriteLine(c1);
            //Ex1
            //Console.WriteLine($"the {c1.CarMake} {c1.CarModel} engine size {c1.EngineSize} is currently at {c1.CurrentSpeed} Km/h");
            //Console.WriteLine($"the {c2.CarMake} {c2.CarModel} engine size {c2.EngineSize} is currently at {c2.CurrentSpeed} km/h" );
        }
    }
}
