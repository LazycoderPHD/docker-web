using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_OOP_bro_code
{
    internal class class1
    {
        public class Testingcar
        {
            public string make = "Ford";
            public string model = "Mustang";
            public int year = 2026;
            public double price = 670000.99;
            public bool isRunning = false;

            public void start()
            {
                isRunning = true;
                Console.WriteLine("You start the engine!");
            }

            public void stop()
            {
                isRunning = false;
                Console.WriteLine("You stop the engine!");
            }

            public void drive()
            {
                Console.WriteLine($"You drive the {model}");
            }

            public void brake()
            {
                Console.WriteLine($"You brake the {model}");
            }
        }
    }
}
