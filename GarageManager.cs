using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0
{
    class GarageManager : GarageHandler, IUI
    {

        
        public void NewGarage(int size)
        {
        }

        
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

                char choice = Console.ReadLine()[0];

                switch (choice)
                {
                    case '1':
                        NewGarage();
                        break;
                    case '2':

                        break;
                    case '3':

                        break;
                    case '4':

                        break;
                    case '5':

                        break;
                    case '6':

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
         

        public void AddVehicle(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public void EmptyGarage()
        {

        }

        public void FindVehicle()
        {
            throw new NotImplementedException();
        }

        public void ListVehicle()
        {
            throw new NotImplementedException();
        }
        public void DisplayVehicleByType()
        {

        }
        public void DisplayVehicleOneType()
        {
            
        }
    }
}
