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

            static void Main(string[] args)
            {
                Console.WriteLine(IsUpperCase("hello"));
                Console.WriteLine(IsUpperCase("HELLO"));

                Console.WriteLine(IsLowerCase("hello"));
                Console.WriteLine(IsLowerCase("HELLO"));

                Console.WriteLine(IsDigit("hello"));
                Console.WriteLine(IsDigit("1234"));

                Console.ReadLine();
            }
        }
    }


