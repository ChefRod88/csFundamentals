
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace csFundamentals  // static = modifier to declare a static member, which belongs to the class itself
                            // rather than to any specific object
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");
            Car car3 = new Car("Honda");
            
            Console.WriteLine(Car.numberOfCars);
            

         Console.ReadKey();
        }
    }

    
    
}

