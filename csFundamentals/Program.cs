
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
            Human human1 = new Human();
            Human human2 = new Human();
            
            
           human1.name = "Rick"; 
           human1.age = 20;
           
           human2.name = "Morty";
           human2.age = 16;
           
           human1.Eat();
           human1.Sleep();

           Console.ReadKey();
        }
    }

    class Human
    {
        public string name;
        public int age;

        public void Eat()
        {
            Console.WriteLine("I'm eating {}");
            
            
        }

        public void Sleep()
        {
            Console.WriteLine("I'm sleeping");
        }
    }
    
}

