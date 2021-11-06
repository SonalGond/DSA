using System;

namespace Array
{
    class Program
    {

        static Boolean LinearSearch(int[] input, int n)
        {
            foreach (int current in input)
            {
                if (n == current)
                    return true;
            }

            return false;
        }

        static int? BinarySearchArray(int[] input, int n)
        {
            int min = 0;
            int max = input.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (n == input[mid])
                {
                    return input[mid];
                }
                else if (n <= input[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return null;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine(LinearSearch(arr, 4));
            Console.WriteLine(LinearSearch(arr, 9));

            //or

            int item = System.Array.Find(arr, element => element == 3);
            Console.WriteLine("Linear search {0}", item);

            int[] items = System.Array.FindAll(arr, element => element >= 3);
            System.Array.ForEach(items, Console.Write);

            //Binary Search
            Console.WriteLine($"Binary Search {BinarySearchArray(arr, 4)}");

            //or
            int pos = System.Array.BinarySearch(arr, 9);
            if (pos >= 0)
                Console.WriteLine($"Item {arr[pos].ToString()} found at position {pos + 1}.");
            else
                Console.WriteLine("Item not found");


            pos = System.Array.BinarySearch(arr, 4);
            if (pos >= 0)
                Console.WriteLine($"Item {arr[pos].ToString()} found at position {pos + 1}.");
            else
                Console.WriteLine("Item not found");

            Console.ReadKey();
        }
    }
}
