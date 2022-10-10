using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_Sheet_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Car
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

        static void DisplayInfo()
        { }
    }
}
