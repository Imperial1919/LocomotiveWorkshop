using System;
using System.Collections.Generic;
using System.Text;

namespace Locomotive_Workshop
{
    class Dieselbasis : ILocomotive
    {
        public void Greeting()
        {
            Console.WriteLine("Ah, so You want a Diesel Locomotive.. alright. Here's one we have.");
        }
        public void Model_Name(){
            Console.WriteLine("Electro-Motive Division F1");
        }

        public void LocomotiveType()
        {
            Console.WriteLine("High Speed Express Diesel");
        }
    }
}
