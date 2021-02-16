using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Garage1._0
{
    /// <summary>
    /// Class for Garage objects
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Garage<T> : IEnumerable<T>, IGarage<T> where T : Vehicle
    {


        private int i = 0;
        private T[] g = new T[4];

        public T[] GarageArray { get => g; set => g = value; }
        public int GarageParkingSpot { get => i; set => i = value; }

        public Array GetGarage()
        {
            return GarageArray;
        }
        public Vehicle GetVehicle(T vehicle)
        {
            var V = Array.Find(GarageArray, ele => ele.GetType() == vehicle.GetType());



            return V;
        }



        public Garage()
        {

        }
        public Garage(int size)
        {
            Array.Resize<T>(ref g, (Math.Max(0, size)));
            GarageParkingSpot = 0;
        }
        public void AddVehicle(T vehicle)
        {
            if (GarageParkingSpot < GarageArray.Length)
            {
                GarageArray[GarageParkingSpot] = vehicle;
                GarageParkingSpot++;
            }
            else
                Console.WriteLine("The Garage is full! Please create a new Garage!");

        }
        /// <summary>
        /// Remove Vehicle from Array
        /// </summary>
        /// <param name="vehicle"></param>
        public void OutVehicle(T vehicle)
        {
            if (GarageArray.Contains(vehicle))
            {
                int vIndex = Array.IndexOf(GarageArray, vehicle);
                Console.WriteLine($"You have removed {vehicle.Name} from the garage!");
                GarageArray[vIndex] = null;
            }
        }
        /// <summary>
        /// Displays contents of Garage
        /// </summary>
        public void DisplayGarage()
        {
            Console.Clear();
            Console.WriteLine("Here's what you have parked in the Garage right now:" +
                              "\nGarage" +
                              "\n------------------");
            for (int n = 0; n < GarageArray.Length; n++)
                if (GarageArray[n] != null) Console.WriteLine($"{n + 1}. " + GarageArray[n].Name + " : " + GarageArray[n].Model);

            Console.WriteLine("------------------");
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)GarageArray).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GarageArray.GetEnumerator();
        }
    }
}
