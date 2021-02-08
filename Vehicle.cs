using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0
{
    /// <summary>
    /// Class for all Vehicles
    /// </summary>
    class Vehicle
    {
        private int year;
        private string registrationNum;
        private string model;
        private int numOfWheels;
        private string color;

        public int Year { get => year; set => year = value; }
        public string RegistrationNum { get => registrationNum; set => registrationNum = value; }//Fix so numbers cannot repeat.
        public string Model { get => model; set => model = value; }
        public int NumOfWheels { get => numOfWheels; set => numOfWheels = value; }
        public string Color { get => color; set => color = value; }

        public Vehicle(int year, string registrationNum, string model, int numOfWheels, string color)
        { 
            Year = year;
            RegistrationNum = registrationNum;
            Model = model;
            NumOfWheels = numOfWheels;
            Color = color;
        }

        public Vehicle()
        { }

        
    }

}

