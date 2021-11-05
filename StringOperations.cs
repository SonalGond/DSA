using System;
using System.Linq;

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
            Console.ReadLine();
        }
    }
}


