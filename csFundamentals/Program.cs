using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        string[] names = new string[6];
        
        Console.WriteLine($"Please enter your name:"); // user enters their name 
        
        var input =Console.ReadLine(); // takes input
        
        names[0] = input;
        names[1] = "Amos";
        names[2] = "Chery";

        Array.Reverse(names);
        Console.WriteLine("Effect of Reverse()");
        foreach (var n in names)
            Console.WriteLine(n);
        
        string[] names2 = new string[6];
        Array.Copy(names, names2, names.Length);
        foreach (var n in names2)
            Console.WriteLine(n);
        

    }
}



