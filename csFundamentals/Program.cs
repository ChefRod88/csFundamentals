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
            int[] numbers = Enumerable.Range(1, 100).ToArray();
            int count = 0;


            foreach (var num in numbers)
            {
                if (num % 3 == 0)
                {
                    count++;
                }
                    
            }
            Console.WriteLine($"Count of numbers divisible by 3 between 1 and 100: {count}");
        }
        
    }
    
    
    
}



