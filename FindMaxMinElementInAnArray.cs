using System;

namespace FindMinMax
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

            //Find the max and min element in an array

            int min = array[0], max = array[0];

            if(length == 1)
            {
                min = array[length];
                max = array[length];
            }
            else if(length == 2)
            {
                if( array[0] > array[1])
                {
                    min = array[1];
                    max = array[0];
                }
                else
                {
                    max = array[1];
                    min = array[0];
                }
            }
            else
            {
                for (int i = 2; i < length; i++)
                {
                    if(array[i]< min)
                    {
                        min = array[i];
                    }
                    else if(array[i]> max)
                    {
                        max = array[i];
                    }
                }
            }           

            Console.WriteLine("Min:{0}    Max : {1}", min, max);
           
            Console.ReadKey();
        }
    }
}
