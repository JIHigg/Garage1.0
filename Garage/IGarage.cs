using System;
using System.Collections.Generic;

namespace Garage1._0
{
    public interface IGarage<T> where T : Vehicle
    {
        T[] GarageArray { get; set; }
        int GarageParkingSpot { get; set; }

        void AddVehicle(T vehicle);
        void DisplayGarage();
        IEnumerator<T> GetEnumerator();
        Array GetGarage();
        Vehicle GetVehicle(T vehicle);
        void OutVehicle(T vehicle);
    }
}