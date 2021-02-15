using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0
{
    /// <summary>
    /// A subclass of Vehicle for Bus
    /// </summary>
    public class Bus : Vehicle
    {
        private int seats;

        public int Seats { get => seats; set => seats = value; }

        public Bus(int seats): base()
        {
            BasicVehicle("Bus");
            Seats = seats;
        }
    }
}
