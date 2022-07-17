using System;
using Polymorphism.Models.Interfaces;
namespace Polymorphism.Models
{
	public abstract class Vehicle: IVehicle
	{
		private double fuelQty;
		private double fuelCspt;
        public double FuelQuantity {

            get {

				return this.fuelQty;
			}
            private set {
				this.fuelQty = value;
			}
		}
		public virtual double FuelConsumption {
            get
            {
				return this.fuelCspt;
            }
			protected set
            {
				this.fuelCspt = value;
            }
		}

        protected Vehicle(double fuelQuantity,double fuelConsumption)
		{
			this.FuelConsumption = fuelConsumption;
			this.FuelQuantity = fuelQuantity;
		}


		public string Drive(double kmToTravel)
        {


			double fuelNeeded = kmToTravel * this.FuelConsumption;
            if (fuelNeeded>this.FuelQuantity)
            {
				      return $"{this.GetType().Name} needs refueling";
			}
            else
            {
				this.FuelQuantity -= fuelNeeded;
				return $"{this.GetType().Name} travelled {kmToTravel} km";
			}
			

        }
		public virtual void Refuel(double liters)
        {
			this.FuelQuantity += liters;
        }


	}
}

