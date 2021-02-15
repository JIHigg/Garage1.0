using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0
{
    /// <summary>
    /// A subclass of Vehicles for Airplanes
    /// </summary>
    public class Airplane : Vehicle
    {
        private int noOfEngines;
        private int seatingCapacity;

        public int SeatingCapacity { get => seatingCapacity; set => seatingCapacity = value; }
        public int NoOfEngines { get => noOfEngines; set => noOfEngines = value; }
        public Airplane()
        {

        }

        public Airplane(int seatingCapacity, int noOfEngines, string model): base ()
        {
            BasicVehicle("Airplane");
            SeatingCapacity = seatingCapacity;
            NoOfEngines = noOfEngines;
        }
    }
}
