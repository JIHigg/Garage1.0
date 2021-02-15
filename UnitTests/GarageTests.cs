using Microsoft.VisualStudio.TestTools.UnitTesting;
using Garage1._0;
using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0.Tests
{
    [TestClass()]
    public class GarageTests
    {
        [TestMethod()]
        public void NewGarage_NotSame_Test()
        {
            Garage<Vehicle> G = new Garage<Vehicle>();

            Garage<Car> vehicles = new Garage<Car>(4);
            Garage<Vehicle> v2 = new Garage<Vehicle>(5);

            Assert.AreNotSame(vehicles, v2);
        }

        [TestMethod()]
        public void GarageTest()
        {
            //
        }

        [TestMethod()]
        public void AddVehicleTest_Car()
        {
            bool results;
            Garage<Vehicle> G = new Garage<Vehicle>();
            Car c1 = new Car(100, 4);
            Car c2 = new Car(24.9, 8);

            G.AddVehicle(c1);
            G.AddVehicle(c2);

            results = G.GarageArray[0].Equals(c1);


            Assert.IsTrue(results);
        }

        [TestMethod()]
        public void GetVehicleTest()
        {
            Garage<Vehicle> TestGarage = new Garage<Vehicle>();
            Car car = new Car(30, 5);
            Boat boat = new Boat("Rowboat");
            Motorcycle motorcycle = new Motorcycle(150);

            TestGarage.AddVehicle(car);
            TestGarage.AddVehicle(boat);
            TestGarage.AddVehicle(motorcycle);

            var results = TestGarage.GetVehicle(boat);
            Assert.AreEqual(boat, results);
        }

        
    }
}