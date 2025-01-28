using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles
            // Create a list of Vehicle called vehicles
            List<Vehicle> vehicles = new List<Vehicle>();

            //Create and intialize vehicles
            Car car = new Car { Year = "2022", Make = "Toyota", Model = "Camry", HasTrunk = true };
            Motorcycle motorcycle = new Motorcycle { Year = "2023", Make = "Harley-Davidson", Model = "Sportster", HasSideCart = false };

            //Create vehicles with explicit typing using constructors
            Vehicle vehicle1 = new Car { Year = "2021", Make = "Honda", Model = "Civic", HasTrunk = true };
            Vehicle vehicle2 = new Motorcycle { Year = "2024", Make = "Ducati", Model = "Supersport", HasSideCart = false };

            
            //Add the 4 vehicles to the list
            vehicles.Add(car);
            vehicles.Add(motorcycle);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);

            //Using a foreach loop iterate over each of the properties
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}, Make: {vehicle.Make}, Model: {vehicle.Model}");
            }

            // Call each of the drive methods for one car and one motorcycle
            car.DriveVirtual();
            motorcycle.DriveVirtual();

                #endregion
            Console.ReadLine();
        }
    }
}
