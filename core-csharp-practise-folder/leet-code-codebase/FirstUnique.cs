using System;
using System.Collections.Generic;
public class FirstUniqueCharacter
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        HashSet<char> seen = new HashSet<char>();
        HashSet<char> unique = new HashSet<char>();

        foreach (char ch in input)
        {
            if (!seen.Contains(ch))
            {
                seen.Add(ch);
                unique.Add(ch);
            }
            else
            {
                unique.Remove(ch);
            }
        }

        // Find first unique character
        foreach (char ch in input)
        {
            if (unique.Contains(ch))
            {
                Console.WriteLine("First unique character is: " + ch);
                return;
            }
        }

        Console.WriteLine("No unique character found");
    }
}
