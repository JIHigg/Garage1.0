using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0
{
    /// <summary>
    /// A subclass of Vehicles for Boats.
    /// </summary>
    public class Boat : Vehicle
    {
        private string typeOfBoat;

        public string TypeOfBoat { get => typeOfBoat; set => typeOfBoat = value; }

        public Boat(string typeOfBoat): base()
        {
            BasicVehicle("Boat");
            TypeOfBoat = typeOfBoat;
        }
    }
}
