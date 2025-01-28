using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "2020";
        public string Make { get; set; } = "Generic Make";
        public string Model { get; set; } = "Generic Model";

        //Abstract method
        public abstract void DriveAbstract();

        //Virtual method with implementation
        public virtual void DriveVirtual()
        {
            Console.WriteLine("The vehicle is driving.");
        }
    }
}