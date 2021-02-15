using Microsoft.VisualStudio.TestTools.UnitTesting;
using Garage1._0;
using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0.Tests
{
    [TestClass()]
    public class GarageHandlerTests
    {
        [TestMethod()]
        public void Display_OneTypeVehicle_Test()
        {
            //Assemble
            GarageHandler gh = new GarageHandler();
            
            Car c1 = new Car(23, 4);
            Car c2 = new Car(32, 8);
            Submarine s1 = new Submarine(12.3);
            Submarine s2 = new Submarine(8);
            gh.AddVehicle(c2);
            gh.AddVehicle(s2);
            gh.AddVehicle(s1);
            gh.AddVehicle(c1);

            int noOfCars = 2;

            //Action
            gh.DisplayOneTypeVehicle('5');

            //Assert
            Assert.AreEqual(noOfCars, gh.total);
        }
    }
}