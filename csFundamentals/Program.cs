using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> names = new List<string>();

        Console.WriteLine("Enter names of people who liked your post (press Enter to stop):");
        
        while (true)
        {
            string input = Console.ReadLine();

            // Stop asking for names if the user presses Enter without typing anything
            if (string.IsNullOrWhiteSpace(input))
            {
                break;
            }

            names.Add(input);
        }

        // Display the appropriate message based on the number of names
        if (names.Count == 0)
        {
            // No one liked the post
            Console.WriteLine("No likes to display.");
        }
        else if (names.Count == 1)
        {
            // One person liked the post
            Console.WriteLine($"{names[0]} likes your post.");
        }
        else if (names.Count == 2)
        {
            // Two people liked the post
            Console.WriteLine($"{names[0]} and {names[1]} like your post.");
        }
        else
        {
            // More than two people liked the post
            int othersCount = names.Count - 2;
            Console.WriteLine($"{names[0]}, {names[1]} and {othersCount} others like your post.");
        }
    }
}



