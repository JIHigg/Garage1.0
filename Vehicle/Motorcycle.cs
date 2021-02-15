using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0
{
    /// <summary>
    /// A subclass of Vehicle for Motorcycles
    /// </summary>
    public class Motorcycle : Vehicle
    {
        private int engineSize;

        public int EngineSize { get => engineSize; set => engineSize = value; }

        public Motorcycle(int engineSize=100):base()
        {
            BasicVehicle("Motorcycle");
            EngineSize = engineSize;
            
        }
    }
}
