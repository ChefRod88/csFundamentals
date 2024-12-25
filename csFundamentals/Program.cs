
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace csFundamentals  // inheritance = 1 or more child classes recieving fields, methods, etc. from a common parent class 
{
    public class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("The vehicle is going...");
        }
    }
    
    public class Car : Vehicle
    {
        public int wheels = 4;
    }

    public class Bicycle : Vehicle
    {
        public int wheels = 2;
    }

    public class Boat : Vehicle
    {
        public int wheels = 4;
    }

    public class Program  // entry point 
    {
        static void Main(string[] args)
        {

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();
            
            Console.WriteLine(car.speed);
            Console.WriteLine(car.wheels);
            car.go();
            
            Console.WriteLine(bicycle.speed);
            Console.WriteLine(bicycle.wheels);
            car.go();
                
            Console.WriteLine(boat.speed);
            Console.WriteLine(boat.wheels);
            car.go();

        }
    }

    
    
}

