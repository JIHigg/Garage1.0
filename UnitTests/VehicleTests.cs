using Microsoft.VisualStudio.TestTools.UnitTesting;
using Garage1._0;
using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0.Tests
{
    [TestClass()]
    public class VehicleTests
    {

        [ClassInitialize]
        public static void ClassSetup(TestContext context)
        {
            
            //
        }

        [TestInitialize]
        public void SetUp()
        {
            //Before each test
        }


        [TestMethod]
        
        public void VehicleRegNumberDuplicate()
        {
            //Arrange
            const bool expected = true;
            bool results = true;

            Vehicle vehicle = new Vehicle("Truck" ,1990, "5", "Chevy", 4, "Blue");
            Vehicle vehicle2 = new Vehicle("CAr", 2006, "26", "Dodge", 4, "Green");
            vehicle.RegistrationNum = "123ABC";
            vehicle2.RegistrationNum = "234abc";

            //Act
            Vehicle v3 = new Vehicle("Car",1993, "6", "Ford Taurus", 4, "Red");
            
            results.Equals(vehicle.RegistrationNum == v3.RegistrationNum);
            //Assert
            Assert.AreNotSame(expected, results);
        }

        [TestCleanup]
        public void CleanUp()
        {
            //After each method
        }
        [ClassCleanup]
        public static void ClassCleanUp()
        {
            //Clean Resources
        }
    }
}