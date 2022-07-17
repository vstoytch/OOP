using System;
using Polymorphism.Models.Interfaces;
using Polymorphism.Models;
namespace Polymorphism.Core
{
	public class Engine:IEngine
	{

		private readonly Vehicle car;
		private readonly Vehicle truck;


		public Engine(Vehicle car, Vehicle truck)
		{
			this.car = car;
			this.truck = truck;
		}


		public void Start()
        {
			int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

				string[] cmdArgs = Console.ReadLine().Split();


				string cmdType = cmdArgs[0];
				string vehicleType = cmdArgs[1];
				double cmdParams = double.
					Parse(cmdArgs[2]);


                if (cmdType=="Drive")
                {

                }
                else if (cmdType == "Reguel")
                {

                }





            }

        }
	}
}

