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
            while (true)
            {
                Console.Write("Please enter a number:");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo:" + input);
                    continue;
                }
                break;
            }
        }
    }
}


