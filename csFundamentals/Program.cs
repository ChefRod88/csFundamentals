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
            var numbers = new List<int>() {1, 2, 3}; //create a list and intialize
            numbers.Add(1); // add numbers to end of list
            numbers.Add(2);
            numbers.AddRange(new int[3] {5, 6, 7});// add a range of numbers to the list

            foreach (var num in numbers)
                Console.WriteLine(num);
            
            Console.WriteLine("Index of 1:" + numbers.IndexOf(1));
            Console.WriteLine("Index of 1:" + numbers.LastIndexOf(1));
            
            Console.WriteLine("Count" + numbers.Count);
            
            numbers.Remove(1);
            foreach (var num in numbers)
                Console.WriteLine(num);
            

            
        }
        
    }
    
    
    
}



