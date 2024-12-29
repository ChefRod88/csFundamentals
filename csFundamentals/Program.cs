using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {

        while (true)
        {
            var numbers = new List<int>();
        
            Console.WriteLine("Please enter a number: ");
            var input = Console.ReadLine();
            for (int i = 0; i == 10 ; i++)
            {
                Console.WriteLine(i);
            }

            if (input == "Quit")
            {
                break;
            }
        }

    }
}



