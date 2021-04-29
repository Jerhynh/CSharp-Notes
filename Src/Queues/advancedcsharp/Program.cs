using System;
using System.Collections;
using System.Collections.Generic;

namespace advancedcsharp
{
    class Program
    {
        // Queues in c# - Queues are FIFO or First in first out. Sort of like a song playlist,
        // the first one added will be at the top and play first unless shuffled.
        static void Main(string[] args)
        {
            // Defining a queue of integers.
            Queue<int> queue = new();
            // Adding elements to the queue
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            Console.WriteLine($"The first item in the queue (item in front of queue): {queue.Peek()}");
            Console.WriteLine($"Removing the first item in the queue (item in front of queue): {queue.Dequeue()}");
            Console.WriteLine($"The first item in the queue (item in front of queue): {queue.Peek()}");
            Console.WriteLine($"End count of items in queue: {queue.Count}");
        }
    }


}
