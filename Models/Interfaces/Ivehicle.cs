using System;
namespace Polymorphism.Models.Interfaces
{
	public interface IVehicle
	{


		double FuelQuantity { get; }
		double FuelConsumption { get; }
		string Drive(double kmToTravel);
		void Refuel(double liters);


	}
}

