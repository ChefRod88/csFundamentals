
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace csFundamentals  // object = an instance of a class 
                            // A class can be used as a blueprint to create objects 
                            // objects can have fields and methods (characteristics and actions)
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Chevy", "Camaro", 2020, "Black");
            Car car2 = new Car("Toyota", "Prius", 1999, "Silver");
            Car car3 = new Car("Honda", "Civic", 2024, "Blue");
            
         car1.Drive();
         car2.Drive();
         car3.Drive();

         Console.ReadKey();
        }
    }

    
    
}

