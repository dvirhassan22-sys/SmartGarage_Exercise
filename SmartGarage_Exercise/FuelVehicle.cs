using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{
    public abstract class FuelVehicle:Vehicle
    {
        public int FuelPrecentage
        {
            get; protected set;
        }
            public FuelVehicle(string model,int fuelPrecentage): base(model)
        {
            this.FuelPrecentage = Math.Clamp(fuelPrecentage, 0, 100);

        }

        public FuelVehicle(string modelName) : base(modelName)
        {
        }

        public virtual void Refuel()
        {
            FuelPrecentage = 100;
        }
        }
    }

