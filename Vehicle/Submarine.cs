using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0
{
    /// <summary>
    /// A subclass of Vehicle for Submarine.
    /// </summary>
    public class Submarine : Vehicle
    {
        private double maxDepth;

        public double MaxDepth { get => maxDepth; set => maxDepth = value; }

        public Submarine(double maxDepth):base()
        {
            BasicVehicle("Submarine");
            MaxDepth = maxDepth;
           
        }
    }
}
