using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Queue
{
    class Program
    {
        static void PrintBinary(int n)
        {
            if (n <= 0)
            {
                return;
            }

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);

            for(int i = 0; i< n; i++)
            {
                int current = queue.Dequeue();
                Console.WriteLine(current);
                queue.Enqueue(current * 10);
                queue.Enqueue(current * 10 + 1);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(8);
            queue.Enqueue(20);
            queue.Enqueue(23);

            int itemRemoved = queue.Dequeue();
            Console.WriteLine(itemRemoved);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());


           ConcurrentQueue<int> concurrentQueue = new ConcurrentQueue<int>();

            concurrentQueue.Enqueue(1);
            concurrentQueue.Enqueue(8);
            concurrentQueue.Enqueue(20);
            concurrentQueue.Enqueue(23);

            int current;
            while(concurrentQueue.TryDequeue(out current))
            {
                Console.WriteLine(current);
            }

            //Generate Binary Numbers
            PrintBinary(5);


            Console.ReadKey();
        }
    }
}
