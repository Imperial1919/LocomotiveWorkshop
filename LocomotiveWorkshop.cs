using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Locomotive_Workshop
{
    class LocomotiveFactory
    {
        public static ILocomotive DesignLoco(string text) 
        { 

            if (text.ToLower() == "steam")
            {
                Console.WriteLine("Alright, Ordering a Steam Locomotive now.");
                Thread.Sleep(1500);

                Console.WriteLine("Gathering  Men and Workshop tools");
                Thread.Sleep(1500);

                Console.WriteLine("Boiler Under Construction");
                Thread.Sleep(1500);

                Console.WriteLine("Valves and Cylinders Being installed.");
                Thread.Sleep(1500);

                Console.WriteLine("Cab and Coal Bunker Being constructed");
                Thread.Sleep(1500);
                Console.WriteLine("Locomotive is being fired up");
                Thread.Sleep(1500);
                Console.WriteLine("Your Steam Locomotive is now completed.");
                return new Steamerbasis();
                
             
            }

            if (text.ToLower() == "diesel")
            {

                Console.WriteLine("Ah, so You would like a new Diesel Locomotive, let me place the order now.");
                Thread.Sleep(1500);
                Console.WriteLine("Gathering Mechanics and Machine Toolists");

                return new Dieselbasis();
              
            }

            if (text.ToLower() == "electric")
            {

                Console.WriteLine("So, You would like a Electrical Locomotive then. Let Me place the order now for You.");
                Thread.Sleep(1500);
                Console.WriteLine("Order Placed!, gathering electricians and electrical engineers.");
                return new Electricbasis();
            }

            else
            {
                Console.WriteLine("The hell?...");
                return new Electricbasis();
            }

        }
    }
}
