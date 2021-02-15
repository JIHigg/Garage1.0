using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Linq;
using System.Collections;

namespace Garage1._0
{
    /// <summary>
    /// Class for all Vehicles
    /// </summary>
    public class Vehicle: IComparable<Vehicle>
    {
        private int year;
        private string registrationNum;
        private string model;
        private int numOfWheels;
        private string color;
        private string name;               
        public List<String> RegNumbers = new List<string>();

        public int Year { get => year; set => year = value; }

        public string RegistrationNum { get => registrationNum; set => registrationNum= value;}

        public string Name { get => name; set => name = value; }

        public string Model { get => model; set => model = value; }
        public int NumOfWheels { get => numOfWheels; set => numOfWheels = value; }
        public string Color { get => color; set => color = value; }

        /// <summary>
        /// Creates New Vehicle
        /// </summary>
        /// <param name="name"></param>
        /// <param name="year"></param>
        /// <param name="registrationNum"></param>
        /// <param name="model"></param>
        /// <param name="numOfWheels"></param>
        /// <param name="color"></param>
        public Vehicle(string name, int year, string registrationNum, string model, int numOfWheels, string color)
        {
            Name = name;
            Year = year;
            RegistrationNum = registrationNum;
            Model = model;
            NumOfWheels = numOfWheels;
            Color = color;
        }

        public override string ToString()
        {
            return Name + " : " + Model;
        }

        public int CompareTo([AllowNull] Vehicle other)
        {
            if (other == null) return 1;
            return Name.CompareTo(other.Name);
        }
        

        public Vehicle()
        { }
        /// <summary>
        /// Gathers generic info for vehicle
        /// </summary>
        /// <param name="type"></param>
        public void BasicVehicle(string type)
        {
            bool valid = false;
            Name = type;
            Console.Clear();

            //Year
            Console.WriteLine("What year is the vehicle:");
            while (valid != true)
            {
                bool success = int.TryParse(Console.ReadLine(), out int uYear);
                if (!success)
                    Console.WriteLine("Please enter a valid year:");
                else
                {
                    Year = uYear;
                    valid = true;
                }  
            }

            //Registration Number
            Console.WriteLine("Please enter the Registration Number of the Vehicle:");
            valid = false;
            while (valid !=true)
            {
                string uRegNum = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(uRegNum))
                    Console.WriteLine("Please enter a valid Number:");
                else if (RegNumbers.Contains(uRegNum.ToLower()))
                {
                    Console.WriteLine("This Registration has been used." +
                                  "Please enter a valid Registration Number:");
                }
                else
                {
                    RegNumbers.Add(uRegNum.ToLower());
                    RegistrationNum = uRegNum;
                    valid = true;
                }
            }

            //Model
            valid = false;
            Console.WriteLine("Please enter the Model of vehicle: ");
            while(valid != true)
            {
                string uModel = Console.ReadLine();
                if(string.IsNullOrWhiteSpace(uModel))
                    Console.WriteLine("Please enter a valid model: ");
                else
                {
                    Model = uModel;
                    valid = true;
                }
            }

            //Wheels
            valid = false;
            Console.WriteLine("Please enter the number of wheels on the vehicle:");
            while(valid != true)
            {
                bool success = int.TryParse(Console.ReadLine(), out int uWheels);
                if (success)
                {
                    NumOfWheels = uWheels;
                    valid = true;
                }
                else
                    Console.WriteLine("Please enter a valid number:");
            }

            //Color
            valid = false;
            Console.WriteLine("Please enter the color of the vehicle: ");
            while(valid!= true)
            {
                string uColor = Console.ReadLine();
                if(string.IsNullOrWhiteSpace(uColor))
                    Console.WriteLine("Please enter a valid Color:");
                else
                {
                    Color = uColor;
                    valid = true;
                }
            }


        }
    }

}

