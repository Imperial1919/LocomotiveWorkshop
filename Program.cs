using System;
using System.IO;

namespace Locomotive_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the TrueCoder's Historic Locomotive Emporium! My name is Bryce and I am the proud owner of this establishment. \n \n Now, Please tell us whether You desire a Steam, Diesel or Electric Locomotive.");
            string userinput = Console.ReadLine();

            LocomotiveFactory.DesignLoco(userinput);
           
        }
    }
}
