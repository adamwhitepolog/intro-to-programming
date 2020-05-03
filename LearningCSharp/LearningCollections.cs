using System;
using System.Collections.Generic;

namespace LearningCSharp
{
    public class LearningCollections
    {
        public static void Main2()
        {
            string[] s = new string[10];
            List<int> list = new List<int>();
            Stack<int> stack = new Stack<int>();
            Queue<int> queue = new Queue<int>();
            
            stack.Push(5);
            stack.Push(7);
            stack.Push(8);
            stack.Push(9);
            
            // ---
            
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            while (stack.Count > 0)
            {
                var poppedElement = stack.Pop();
                Console.WriteLine(poppedElement);
            }

            Console.WriteLine("----");

            while (queue.Count > 0)
            {
                var dequeued = queue.Dequeue();
                Console.WriteLine(dequeued);
            }
        }
    }
}