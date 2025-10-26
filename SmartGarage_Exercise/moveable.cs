using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{
    internal interface moveable
    {

        public abstract void MoveLeft();
        public abstract void MoveRight();
        public abstract void Moveforward();
        public abstract void Movebackward();
       
    }
}

