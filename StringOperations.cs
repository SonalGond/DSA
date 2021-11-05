using System;
using System.Linq;
using System.Text;

namespace StringOperations
{
    class ValidateStrings
    {

        static Boolean IsLowerCase(string s)
        {
            return s.All(char.IsLower);
        }

        static Boolean IsUpperCase(string s)
        {
            return s.All(char.IsUpper);
        }

        static Boolean IsDigit(string s)
        {
            return s.All(char.IsDigit);
        }

        static Boolean IsPasswordComplex(string s)
        {
            return s.Any(char.IsUpper) && s.Any(char.IsLower) && s.Any(char.IsDigit);
        }

        static string NormalizeString(string input)
        {
            return input.ToLower().Replace(",", "").Trim();
        }

        static string Reverse(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            StringBuilder reversed = new StringBuilder(input.Length);

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed.Append(input[i]);
            }

            return reversed.ToString();
        }

        static string Reverse2(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            char[] array = input.ToCharArray();

            Array.Reverse(array);

            return new string(array);
        }

        static String ReverseEachWord(String input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            StringBuilder result = new StringBuilder();

            string[] arr = input.Split(' ');

            for (int i = 0; i < arr.Length; i++)
            {
                result.Append(Reverse2(arr[i]));
            }

            return result.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsUpperCase("hello"));
            Console.WriteLine(IsUpperCase("HELLO"));

            Console.WriteLine(IsLowerCase("hello"));
            Console.WriteLine(IsLowerCase("HELLO"));

            Console.WriteLine(IsDigit("hello"));
            Console.WriteLine(IsDigit("1234"));

            Console.WriteLine(IsPasswordComplex("hello\\"));
            Console.WriteLine(IsPasswordComplex("1234Hello"));

            Console.WriteLine(NormalizeString("Hello There, BUDDY       "));

            Console.WriteLine(NormalizeString("Hello There, BUDDY       ").Contains("there"));

            Console.WriteLine(Reverse("Hello World!"));

            Console.WriteLine(Reverse2("Hello World!"));

            Console.WriteLine(ReverseEachWord("Hello There, Buddy "));
            Console.ReadLine();
        }
    }
}


