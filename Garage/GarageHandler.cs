using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0
{
    /// <summary>
    /// Creates and modifies Garage objects.
    /// </summary>
    public class GarageHandler : Garage<Vehicle>, IGarageHandler
    {
        private Dictionary<char, string> vehicleList = new Dictionary<char, string>()
        {
            {'1', "Airplane"},
            {'2', "Bicycle"},
            {'3', "Boat" },
            {'4', "Bus" },
            {'5', "Car" },
            {'6', "Motorcycle"},
            {'7', "Submarine" }
        };
        public int total = 0;

        /// <summary>
        /// User prompt to Create New Garage
        /// </summary>
        public void NewGarage()
        {
            Console.WriteLine("Let's create a new Garage!"
                            + "\nHow many vehicles would you like to fit inside it:");
            int.TryParse(Console.ReadLine(), out int size);
            Garage<Vehicle> G1 = new Garage<Vehicle>(size);

        }
        public GarageHandler()
        {
        }

        /// <summary>
        /// Add new Vehicle to Garage
        /// </summary>
        public void AddNewVehicle()
        {
            bool open = true;

            while (open)
            {
                DisplayGarage();
                Console.WriteLine("Which type of vehicle would you like to put in the Garage? Please make a selecion:"
                                + "\n1. Airplane"
                                + "\n2. Bicycle"
                                + "\n3. Boat"
                                + "\n4. Bus"
                                + "\n5. Car"
                                + "\n6. Motorcycle"
                                + "\n7. Submarine"
                                + "\n0. Quit:");
                char choice = Console.ReadLine()[0];
                switch (choice)
                {
                    case '1':
                        NewAirplane();
                        break;
                    case '2':
                        NewBike();
                        break;
                    case '3':
                        NewBoat();
                        break;
                    case '4':
                        NewBus();
                        break;
                    case '5':
                        NewCar();
                        break;
                    case '6':
                        NewMotorcycle();
                        break;
                    case '7':
                        NewSubmarine();
                        break;
                    case '0':
                        open = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please make a valid selection.");
                        break;
                }
            }
        }

        /// <summary>
        /// Searches vehicles by RegNum
        /// </summary>
        public void RegistrationSearch()//Search by RegNum
        {
            Console.Clear();
            Console.WriteLine("Please enter the Registration Number of the vehicle:");
            string vRegNum = Console.ReadLine();

            List<Vehicle> Results = new List<Vehicle>();

            foreach (Vehicle vehicle in GarageArray)
            {
                if (vehicle.RegistrationNum.ToLower() == vRegNum.ToLower())//Rewrite to LINQ?
                    Results.Add(vehicle);
            }

            if (Results.Count > 0)
            {
                Console.Clear();
                Console.WriteLine("Here are the vehicle(s) that match your search:" +
                                "\n---------");
                foreach (var item in Results)
                    Console.WriteLine($"Vehicle: {item.Name}" +
                                      $"\nModel: {item.Model}" +
                                      $"\nRegistration Number: {item.RegistrationNum}");
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Sorry, was unable to find any vehicles matching {vRegNum}");
            }

        }
        /// <summary>
        /// Allows user to search Vehicles by any property
        /// </summary>
        public void VehicleTraitSearch()//Search by any Vehicle Prop //TODO Fix Repetitive Code
        {
            Dictionary<string, string> vAttributes = new Dictionary<string, string>();

            Console.Clear();
            Console.WriteLine("Please enter the Type of vehicle:[Leave blank if unknown]: ");
            string vType = Console.ReadLine();

            //Verify and add input
            bool empty = String.IsNullOrEmpty(vType);
            if (!empty)
                vAttributes.Add("Name", vType.ToLower());

            Console.WriteLine("Please enter the year of the vehicle [Leave blank if unknown]:");
            string vYear = Console.ReadLine();

            empty = String.IsNullOrEmpty(vYear);
            if (!empty)
                vAttributes.Add("Year", vYear);

            Console.WriteLine("Please enter the Registration Number of the vehicle" +
                              " [Leave blank if unknown]: ");
            string vRegNum = Console.ReadLine();

            empty = String.IsNullOrEmpty(vRegNum);
            if (!empty)
                vAttributes.Add("RegistrationNum", vRegNum);

            Console.WriteLine("Please enter the number of Wheels on the vehicle" +
                              " [Leave blank if unknown]: ");
            string vWheel = Console.ReadLine();

            empty = String.IsNullOrEmpty(vWheel);
            if (!empty)
                vAttributes.Add("NumOfWheels", vWheel);

            Console.WriteLine("Please enter the color of the vehicle [Enter '0' if unknown]: ");
            string vColor = Console.ReadLine();

            empty = String.IsNullOrEmpty(vColor);
            if (!empty)
                vAttributes.Add("Color", vColor);

            //Results of search
            List<Vehicle> Results = CompareVehicles(vAttributes);
            Console.Clear();
            Console.WriteLine("Here are the vehicles that match your search criteria:" 
                            + "\n--------------------------------");

            foreach(Vehicle vehicle in Results)
            {
                Console.WriteLine(vehicle.ToString());
            }
            Console.WriteLine("---------------------------------");
        }
        /// <summary>
        /// Compares user input properties to vehicles in Garage
        /// </summary>
        /// <param name="userVehicle"></param>
        /// <returns></returns>
        private List<Vehicle> CompareVehicles(Dictionary<string, string> userVehicle)
        {
            List<Vehicle> matchVehicles = new List<Vehicle>();

            foreach (Vehicle vehicle in GarageArray)
            {
                bool match = true;

                foreach (var item in userVehicle)
                {
                    if (vehicle != null)
                    {
                        if (vehicle.GetType().GetProperty(item.Key).GetValue(vehicle).ToString().ToLower() != item.Value.ToLower())
                            match = false;
                    }
                }
                if (match)
                    matchVehicles.Add(vehicle);
            }
            return matchVehicles;
        }


        /// <summary>
        /// Creates New Car object from User Data
        /// </summary>
        private void NewCar()
        {
            Console.Clear();
            Console.WriteLine("What is the MilesPerGallon of this car:");
            double.TryParse(Console.ReadLine(), out double mpg);

            Console.WriteLine("How many people does this car seat?");
            int.TryParse(Console.ReadLine(), out int seatsCar);

            Car car = new Car(mpg, seatsCar);
            AddVehicle(car);
        }

        /// <summary>
        /// Creates New Submarine from User Data
        /// </summary>
        private void NewSubmarine()
        {
            Console.Clear();
            Console.WriteLine("What is the maximum diving depth (in km):");
            double.TryParse(Console.ReadLine(), out double sDepth);

            Submarine submarine = new Submarine(sDepth);
            AddVehicle(submarine);
        }

        /// <summary>
        /// Creates New Motorcycle from user data
        /// </summary>
        private void NewMotorcycle()
        {
            Console.Clear();
            Console.WriteLine("What size is the engine of the motorcycle:");
            int.TryParse(Console.ReadLine(), out int mSize);

            Motorcycle motorcycle = new Motorcycle(mSize);
            AddVehicle(motorcycle);
        }

        /// <summary>
        /// Create new Bus from user data
        /// </summary>
        private void NewBus()
        {
            Console.Clear();
            Console.WriteLine("What is the Seating Capacity of the bus:");
            int.TryParse(Console.ReadLine(), out int busCapacity);

            Bus bus = new Bus(busCapacity);
            AddVehicle(bus);
        }

        /// <summary>
        /// Create New Boat from user Data
        /// </summary>
        private void NewBoat()
        {
            Console.Clear();
            Console.WriteLine("What type of boat would you like to add:");
            string bType = Console.ReadLine();
            Boat boat = new Boat(bType);
            AddVehicle(boat);
        }

        /// <summary>
        /// Create New Bike from user Data
        /// </summary>
        private void NewBike()
        {
            Console.Clear();
            Console.WriteLine("Let's park your bike in the garage!" +
                              "\nWhat model of bicycle is this:");
            string bModel = Console.ReadLine();

            Console.WriteLine("What color is the bike:");
            string bColor = Console.ReadLine();

            Console.WriteLine("What is the tire size of this model in inches:");
            int.TryParse(Console.ReadLine(), out int bSize);

            Console.WriteLine("What is the top speed of this model:");
            int.TryParse(Console.ReadLine(), out int bSpeed);

            Bicycle bike = new Bicycle(bSpeed, bSize, bModel, bColor);
            AddVehicle(bike);
        }

        /// <summary>
        /// Create new Airplane from user data
        /// </summary>
        private void NewAirplane()
        {
            Console.Clear();
            Console.WriteLine("Please enter the model of Airplane:");
            string model = Console.ReadLine();

            Console.WriteLine("Please enter the seating capacity of this Airplane:");
            int.TryParse(Console.ReadLine(), out int seatsAir);

            Console.WriteLine("Please enter the number of engines on this Airplane:");
            int.TryParse(Console.ReadLine(), out int engineNo);

            Airplane airplane = new Airplane(seatsAir, engineNo, model);
            AddVehicle(airplane);
        }

        /// <summary>
        /// Displays Vehicles in Garage by type
        /// </summary>
        /// <param name="choice"></param>
        public void DisplayOneTypeVehicle(char choice)//TODO Fix Null
        {
            Console.WriteLine($"Here is the current inventory of {vehicleList[choice]} :"
                            + "\n======================");

            foreach (Vehicle v in GarageArray)
            {
                if (v != null)
                {
                    if (v.Name == vehicleList[choice])
                    {
                        Console.WriteLine(v);
                        total++;
                    }
                }
            }
            Console.WriteLine("=====================" +
                            $"\nTotal: {total}");
        }
    }
}
