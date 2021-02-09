using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0
{
    internal interface IUI
    {
        void NewGarage(int size);
        void EmptyGarage();
        void AddVehicle(Vehicle vehicle);
        void FindVehicle();
        void ListVehicle();
        public void DisplayVehicleByType();

        public void DisplayVehicleOneType();
        
    }
}
