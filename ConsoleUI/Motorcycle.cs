using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        //Unique property for Motorcycle
        public bool HasSideCart { get; set; }

        //Implementing the abstract
        public override void DriveAbstract()
        {
            Console.WriteLine("The motorcycle is driving");
        }

        //Override the virtual method
        public override void DriveVirtual()
        {
            Console.WriteLine("The motorcycle is driving with a modified virtua implementation.");
        }
    }
}
