using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0
{
    /// <summary>
    /// A subclass of Vehicles for Cars.
    /// </summary>
    public class Car : Vehicle
    {
        private double milesPerGallon;
        private int seatingCapacity;

        public double MilesPerGallon { get => milesPerGallon; set => milesPerGallon = value; }
        public int SeatingCapacity { get => seatingCapacity; set => seatingCapacity = value; }

        public Car(double milesPerGallon, int seatingCapacity):base()
        {
            BasicVehicle("Car");
            MilesPerGallon = milesPerGallon;
            SeatingCapacity = seatingCapacity;
        }
    }
}
