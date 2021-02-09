using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0
{
    /// <summary>
    /// A subclass of Vehicle for Bicycles.
    /// </summary>
    class Bicycle : Vehicle
    {
        private int topSpeed;
        private int wheelSize;

        public Bicycle(int topSpeed, int wheelSize, string model, string color):base(1990, "abcd", model, 2, color)
        {
            TopSpeed = topSpeed;
            WheelSize = wheelSize;
            Model = model;
            Color = color;
        }
        public int TopSpeed { get => topSpeed; set => topSpeed = value; }
        public int WheelSize { get => wheelSize; set => wheelSize = value; }
    }
}
