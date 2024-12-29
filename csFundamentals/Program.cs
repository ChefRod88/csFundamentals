using System;
using System.Collections.Generic;
using System.Collections.Immutable;


class Program
{
    static void Main()
    {
        while (true)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5};
        
            Console.Write("Enter numbers separated by commas: ");
            numbers = Console.ReadLine().Split(',').Select(int.Parse).ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers.Count == 0 || numbers.Count < 5)
                {
                    Console.WriteLine("Invalid List");
                    Console.WriteLine("Retry");
                    continue;
                    
                }
            }

        }
    }
}



