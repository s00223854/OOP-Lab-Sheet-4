using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_Sheet_4
{
    
    public class Car
    {
        private string carMake;

        public string CarMake
        {
            get { return this.carMake; }
            set { this.carMake = value; }
        }

        private string carModel;

        public string CarModel
        {
            get { return this.carModel; }
            set { this.carModel = value; }
        }

        private int currentSpeed;

        public int CurrentSpeed
        {
            get { return this.currentSpeed; }
            set { this.currentSpeed = value; }
        }

        private double engineSize;

        public double EngineSize
        {
            get { return this.engineSize; }
            set { this.engineSize = value; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Car make: {carMake}");
            Console.WriteLine($"Car Model: {carModel}");
            Console.WriteLine($"Current Speed: {currentSpeed}");
            Console.WriteLine($"Engine Size: {EngineSize}");
        }

        public override string ToString()
        {
            return
                string.Format($"Car Make: {CarMake}" +
                                $"\nCar Model: {CarModel}" +
                                $"\nCurrent Speed: {CurrentSpeed}") +
                                $"\nEngine size: {EngineSize}";
        }

        public void Accelerate()
        {
            CurrentSpeed += 10;
            Console.WriteLine($"current speed is {CurrentSpeed}");
        }
    }
}
