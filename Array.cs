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

        static int[] Reverse(int[] input)
        {
            int[] reversed = new int[input.Length];

            for (int i = 0; i < reversed.Length; i++)
            {
                reversed[i] = input[input.Length - i - 1];
            }

            return reversed;
        }

        static void ReverseInPlace(int[] input)
        {
            for (int i = 0; i < input.Length / 2; i++)
            {
                // Swap index(i) with index(input-i-1)
                int temp = input[i];
                input[i] = input[input.Length - i - 1];
                input[input.Length - i - 1] = temp;
            }
        }

        static void RotateLeft(int[] input)
        {
            int temp = input[0];
            for (int i = 0; i < input.Length - 1; i++)
            {
                input[i] = input[i + 1];
            }

            input[input.Length - 1] = temp;
        }

        static void RotateRight(int[] input)
        {
            int temp = input[input.Length - 1];
            for (int i = input.Length - 1; i > 0; i--)
            {
                input[i] = input[i - 1];
            }

            input[0] = temp;
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
                Console.WriteLine($"Item {arr[pos].ToString()} is found at {pos + 1}");
            else
                Console.WriteLine("Item not found");

            //Reverse an array

            int[] reversed = Reverse(arr);
            System.Array.ForEach(reversed, Console.WriteLine);

            //or
            ReverseInPlace(arr);
            System.Array.ForEach(arr, Console.WriteLine);

            arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            //Rotate an array to Left
            RotateLeft(arr);
            Console.WriteLine("Left Rotation");
            System.Array.ForEach(arr, Console.Write);

            Console.WriteLine("Right Rotation");
            arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            //Rotate an array to right
            RotateRight(arr);
            System.Array.ForEach(arr, Console.Write);


            Console.ReadKey();
        }
    }
}
