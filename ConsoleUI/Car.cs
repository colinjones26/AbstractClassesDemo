using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        //Unique property for Car
        public bool HasTrunk { get; set; }

        //Implementing the abstract
        public override void DriveAbstract()
        {
            Console.WriteLine("The car is driving");
        }

    }
}
