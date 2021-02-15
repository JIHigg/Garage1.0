using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0
{
    class GarageManager : GarageHandler, IUI
    {

        
        

        
        internal void Menu()
        {
            bool open = true;

            while (open)
            {

                Console.Clear();
                Console.WriteLine("Welcome to the Garage Application!"
                            + "\nPlease make a section from the options:"
                            + "\n1. Create a new Garage."
                            + "\n2. Add a Vehicle to an existing Garage."
                            + "\n3. Remove a Vehicle from the Garage."
                            + "\n4. Display all of specific Vehicle type."
                            + "\n5. Dispay all Vehicles stored in all Garages."
                            + "\n6. Search for Vehicle."
                            + "\n0. Exit:");


                char choice = Console.ReadLine()[0];//Fix to Throw Exceptions.

                switch (choice)
                {
                    case '1':
                        CreateGarage();
                        break;
                    case '2':
                        AddNewVehicle();
                        break;
                    case '3':
                        RemoveVehicle();
                        break;
                    case '4':
                        DisplayVehicleOneType();
                        break;
                    case '5':
                        DisplayVehicleByType();
                        break;
                    case '6':
                        VehicleSearch();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            
            
            
            
            
            }
        }
         

        public void CreateGarage()
        {
            NewGarage();
            
        }
        public void AddVehicle()
        {
            AddNewVehicle();
        }


        public void FindVehicle()
        {
            Console.Clear();
            DisplayGarage();
            Console.WriteLine("Which Vehicle would you like to select:");
            int n = int.Parse(Console.ReadLine());
            n = n - 1;

            Console.Clear();
            Console.WriteLine($"You have selected {GarageArray[n].ToString()}");
        }

        public void ListVehicle()
        {
            throw new NotImplementedException();
        }
        public void DisplayVehicleByType()
        {
            Array.Sort<Vehicle>(GarageArray);
            
            Console.Clear();

            Console.WriteLine("Vehicles in Garage sorted by type:" +
                              "\n------------------" + 
                              "\nType\t\t\tModel:" +
                              "\n-----\t\t\t-----");

            foreach(var item in GarageArray)
            {
                
                Console.WriteLine(item.Name + " : " + item.Model);
            }
            Console.WriteLine("------------------");
        }
        public void DisplayVehicleOneType()
        {
            Console.Clear();
            Console.WriteLine("Which type of vehicles would you like to see in the garage:" +
                            "\n1. Airplane" +
                            "\n2. Bicycle" +
                            "\n3. Boat" +
                            "\n4. Bus" +
                            "\n5. Car" +
                            "\n6. Motorcycle" +
                            "\n7. Submarine");
            char choice = Console.ReadLine()[0];

            DisplayOneTypeVehicle(choice);                          
        }
        public void VehicleSearch() 
        {
            Console.Clear();
            Console.WriteLine("Please select how you would like to search for a vehicle:"
                           + "\n1.Registration Number: "
                           + "\n2.Other options: ");
            char choice = Console.ReadLine()[0];

            if (choice == '1')
                RegistrationSearch();
            else if (choice == '2')
                VehicleTraitSearch();
        }
        public void RemoveVehicle() 
        {

        }
    }
}
