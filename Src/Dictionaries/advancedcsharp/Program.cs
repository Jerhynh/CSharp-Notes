using System;
using System.Collections;
using System.Collections.Generic;

namespace advancedcsharp
{
    class Program
    {
        // Dictionary
        // Contains a Key and Value pair.
        // Key - Value (pair)
        // Auto - Car
        static void Main(string[] args)
        {
            Dictionary<int, string> myDictionary = new();

            myDictionary.Add(1, "Hello world");
            Console.WriteLine(myDictionary[1]);
            Console.WriteLine($"Removed index 1: {myDictionary.Remove(1)}");
        }
    }


}
