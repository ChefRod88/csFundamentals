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
            var name = "John Smith";
            /*for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
                
            }*/

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }
            
        
        }
    }
}

