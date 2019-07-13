using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ExistingPowersOf2
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Int32> NumberList = new List<Int32>();
            string userInput = null;
            int Number;

            while (userInput != "X")
            {
                Console.WriteLine("Provide a single number. Type 'X' to finish adding numbers to the list.");
                userInput = Console.ReadLine();
                if (userInput != "X")
                {
                    Number = ToInt32(userInput);
                    NumberList.Add(Number);
                }
            }

            NumberList = CheckPowersOf2(NumberList);
            NumberList.Sort();

            if (!NumberList.Any())
            {
                Console.WriteLine("NA");
            }
            else
            {
                Console.WriteLine(String.Join(", ", NumberList.Distinct()));
            }
            Console.ReadKey();
        }

        // Method which turns string into an int32 variable.
        public static int ToInt32(String value)
        {
            if (value == null)
                return 0;
            return Int32.Parse(value, CultureInfo.CurrentCulture);
        }

        // Method which verifies wheather provided integer is a variable.
        static bool IsPowerOfTwo(int n)
        {
            return (int)(Math.Ceiling((Math.Log(n) / Math.Log(2))))
                  == (int)(Math.Floor(((Math.Log(n) / Math.Log(2)))));
        }

        // Method which returns powers of 2 for a list of integers.
        public static List<Int32> CheckPowersOf2(List<Int32> NumberList)
        {
            List<Int32> PowersOf2 = new List<Int32>();

            foreach (int i in NumberList)
            {
                int power = 1;

                while (i / power != 1 && IsPowerOfTwo(i))
                {
                    int x = i / power;
                    power = power * 2;
                    PowersOf2.Add(1);
                    PowersOf2.Add(x);
                }
            }
            return PowersOf2;
        }
    }
}


