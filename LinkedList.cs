using System;
using System.Collections.Generic;
using System.Linq;


namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList <string> linkedList = new LinkedList<string>();
            //AddLast
            //AddFirst
            linkedList.AddLast("Movies");
            linkedList.AddLast("Series");
            linkedList.AddFirst("Genre");
            linkedList.AddFirst("Live Shows");

            //Contains-to check if ceratin piece of data is in the list
            Console.WriteLine($"Linked List - {linkedList.Contains("Netflix")} ");
            Console.WriteLine($"Linked List - {linkedList.Contains("Series")} ");

            //Count no of items
            Console.WriteLine($"Linked List - {linkedList.Count} ");

            //Remove first item from the list
            linkedList.RemoveFirst();

            foreach(string item in linkedList)
            {
                Console.Write(item + "->");
            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
