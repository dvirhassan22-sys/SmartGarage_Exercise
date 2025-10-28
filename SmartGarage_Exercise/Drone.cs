using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{
    internal class Drone : ElectricVehicle
    {
        public int velocity
        {
            get; set;
        }
        public Drone(string model) : base(model)
        {
        }
        public void fly()
        {
            MoveUp();
            Drive();
        }
        public override void Drive()
        {
            throw new NotImplementedException();
        }

        public override void Movebackward()
        {
            throw new NotImplementedException();
        }

        public override void Moveforward()
        {
            throw new NotImplementedException();
        }

        public override void MoveLeft()
        {
            throw new NotImplementedException();
        }

        public override void MoveRight()
        {
            throw new NotImplementedException();
        }
        public void MoveUp()
        {
            Console.WriteLine("Moving up!");
        }
        public void MoveDown()
        {
            Console.WriteLine("Moving down!");
        }
    }
}
