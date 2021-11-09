using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void NextGreaterElement(int[] arr)
        {
            if(arr.Length <= 0)
            {
                return;
            }

            Stack<int> stack = new Stack<int>();
            stack.Push(arr[0]);

            for(int i = 0; i < arr.Length; i++)
            {
                int next = arr[i];

                if (stack.Count > 0)
                {
                    int popped = stack.Pop();

                    while (popped < next)
                    {
                        Console.WriteLine(popped + "->" + next);

                        if (stack.Count == 0)
                            break;

                        popped = stack.Pop();
                    }

                    if(popped > next)
                    {
                        stack.Push(popped);
                    }
                }
                stack.Push(next);
            }

            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop() + "->" + -1);
            }
        }

        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            stack.Push("Main");
            stack.Push("ResponsibleBuilder");
            stack.Push("CallExternalServices");

            Console.WriteLine("END" + stack.Pop());
            stack.Push("ParseExternalData");
            Console.WriteLine("END" + stack.Pop());
            Console.WriteLine("END" + stack.Pop());
            Console.WriteLine("END" + stack.Pop());
            stack.Push("Main");

            Console.WriteLine(stack.Peek());

            //Print Next Greater Element
            int[] arr = { 15, 8, 4, 10 };
            NextGreaterElement(arr);

            Console.ReadKey();
        }
    }
}
