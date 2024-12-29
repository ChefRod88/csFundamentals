using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csFundamentals
{
    
    
    public class Program
    {
        static void Main(string[] args)
        {
         List<int> numbers = new List<int>();
         int sum = 0;

         while (true)
         {
             Console.WriteLine("Enter number (or type 'ok' to exit): ");
             string input = Console.ReadLine();

             if (input.ToLower() == "ok")
             {
                 break;
             }
             else if (int.TryParse(input, out int number))
             {
                 numbers.Add(number);
                 sum += number;
                 Console.WriteLine($"Number entered: {number} was added to the list.");
             }
             else
             {
                 Console.WriteLine("Invalid input. Try again.");
             }
             Console.WriteLine($"The sum of the numbers is {sum}.");
         }
         
         
         
        }
        
    }
    
    
    
}



