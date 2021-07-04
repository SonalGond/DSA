using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAnArrayorString
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 0;
            Console.WriteLine("Enter length of the array");
             Int32.TryParse(Console.ReadLine(), out length);

            int[] array = new int[length];

            Console.WriteLine("Enter an Array");
            for(int i = 0; i< length ; i++)
            {
                Int32.TryParse(Console.ReadLine(), out array[i]);                
            }

            int temp;
            for (int i = 0, j = length - 1 ;  i < length/2; i++, j--)
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;                
            }

            Console.WriteLine("Reversed Array:");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}
