using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0
{
    /// <summary>
    /// A subclass of Vehicle for Submarine.
    /// </summary>
    class Submarine : Vehicle
    {
        private double maxDepth;

        public double MaxDepth { get => maxDepth; set => maxDepth = value; }

        public Submarine(double maxDepth):base(2010, "sub123", "Ohio", 0, "Black")
        {
            MaxDepth = maxDepth;
           
        }
    }
}
