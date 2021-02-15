using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0
{
    internal interface IUI
    {
        void NewGarage();
        void CreateGarage();
        void AddVehicle();
        void RemoveVehicle();
        void FindVehicle();
        void ListVehicle();
        public void DisplayVehicleByType();

        public void DisplayVehicleOneType();
        void VehicleSearch();
    }
}
