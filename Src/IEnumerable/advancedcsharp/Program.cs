using System;
using System.Collections;
using System.Collections.Generic;

namespace advancedcsharp
{
    class Program
    {
        // IEnumerator && IEnumerable interfaces.
        static void Main(string[] args)
        {
            IEnumerable<int> unknownCollection;
            unknownCollection = GetCollection(1);

            // Foreach number in unknown collection type.
            foreach (int num in unknownCollection)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine("\n---");
            unknownCollection = GetCollection(2);

            // Foreach number in unknown collection type.
            foreach (int num in unknownCollection)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine("\n---");
            unknownCollection = GetCollection(3);

            // Foreach number in unknown collection type.
            foreach (int num in unknownCollection)
            {
                Console.Write($"{num} ");
            }

        }

        static IEnumerable<int> GetCollection(int option)
        {
            List<int> list = new() { 1, 2, 3, 4, 5 };
            Queue<int> queue = new();
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);
            queue.Enqueue(10);

            // If option is 1 return numbers list.
            if (option == 1)
            {
                return list;
            }
            else if (option == 2)
            {
                // If option is 2 return numbers queue (Completely type of list)
                return queue;
            }
            else
            {
                return new int[] { 11, 12, 13, 14, 15 };
            }

        }
    }

}
