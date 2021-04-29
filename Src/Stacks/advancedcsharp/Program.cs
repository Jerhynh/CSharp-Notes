using System;
using System.Collections;
using System.Collections.Generic;

namespace advancedcsharp
{
    class Program
    {
        // Stacks in c# - Stacks are LIFO or last in first out. sort of like a stack of rocks.
        static void Main(string[] args)
        {
            // Popping an empty stack will cause an error, so the best thing to do is check if stack.Count > 0.
            Stack<int> stack = new();
            // Adding elements to the stack using Push() method.
            stack.Push(420);
            stack.Push(1337);
            stack.Push(69);

            // Pop() removes an item from the stack
            Console.WriteLine($"Removing top-most item in stack: {stack.Pop()}"); 
            // Peek() will return the element at the top of the stack without removing it.
            Console.WriteLine($"Top-most value in the stack is {stack.Peek()}");

        }
    }


}
