using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{
    public abstract class Vehicle:IMovable
    {
        public string ModelName
        {
            get; set;
        }
        public Vehicle(string modelName)
        {
            ModelName = modelName;
        }
        public abstract void Drive();
        public abstract void MoveLeft();
        public abstract void MoveRight();
        public abstract void Moveforward();
        public abstract void Movebackward();

        public void MoveForward()
        {
            Console.WriteLine("Moving forwards");
        }

        public void MoveBackward()
        {
            Console.WriteLine("Moving backwards");
        }
    }
}

