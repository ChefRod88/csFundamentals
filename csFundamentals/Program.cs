
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace csFundamentals  // overloaded constaructors = technique to create multiple constructors,
                            // with different set of parameters.
                            // name + parameters = signature
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza1 = new Pizza("white","tomato","yellow", "Sausage");
            Pizza pizza2 = new Pizza("wheat", "bechamel", "gruyere");
            
            
            
            
            Console.ReadKey();
        }
    }

    
    
}

