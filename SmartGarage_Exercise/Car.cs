using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise;


/// <summary>
/// מייצגת מכונית בעלת מנוע דלק.
/// </summary>
public class Car : FuelVehicle
		{

    /// <summary>
    /// אחוז הדלק הנוכחי (בין 0 ל-100).
    /// </summary>
    public int FuelPercentage
		  {
	     get; set;
		  }
    public string ModelName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


			/// <summary>
			 /// בנאי ליצירת מכונית חדשה.
			/// </summary>
			 /// <param name="model">שם דגם המכונית.</param>
			 /// <param name="fuel">כמות הדלק ההתחלתית.</param>
			public Car(string model, int fuel) : base(model)
			{
			}

    public Car(string modelName) : base(modelName)
    {
    }

    /// <summary>
    /// מבצע פעולת נסיעה הצורכת דלק.
    /// </summary>
    public override void Drive()
			{
				if (FuelPercentage > 10)
				{
					FuelPercentage -= 10;
					Console.WriteLine($"The car {ModelName} goes 'Vroom Vroom'. Fuel left: {FuelPercentage}%");
				}
				else
				{
					Console.WriteLine($"The car {ModelName} cannot drive. No fuel.");
				}
			}

			/// <summary>
			/// מתדלק את המכונית למקסימום.
			/// </summary>
			public void Refuel()
			{
				Console.WriteLine($"Refueling {ModelName}...");
				FuelPercentage = 100;
			}

    public override void MoveLeft()
    {
        throw new NotImplementedException();
    }

    public override void MoveRight()
    {
        throw new NotImplementedException();
    }

    public override void Moveforward()
    {
        throw new NotImplementedException();
    }

    public override void Movebackward()
    {
        throw new NotImplementedException();
    }


}

	
