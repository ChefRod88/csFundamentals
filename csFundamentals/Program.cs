using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
       int[] inputs = new int[5];
       
       Console.WriteLine("Please enter 5 different input numbers.");

       for (int i = 0; i < inputs.Length; i++)
       {
           Console.Write($"Input {i + 1 }: ");
           inputs[i] = Convert.ToInt32(Console.ReadLine());
       }
       
       Console.WriteLine("\nYou entered:");
       foreach (int i in inputs)
       {
           Console.WriteLine(i);
       }

    }
}



