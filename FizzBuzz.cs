using System;

namespace LeetCode
{

    class FizzBuzz
    {
        public static void fizzBuzz(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.Write("FizzBuzz");
                else if (i % 3 == 0)
                    Console.Write("Fizz");
                else if (i % 5 == 0)
                    Console.Write("Buzz");
                else
                    Console.Write(i);
            }
            Console.WriteLine();
        }

        public static void fizzBuzz2(int n)
        {
            int fizz = 3;
            int buzz = 5;

            for (int i = 0; i <= n; i++)
            {
                string result = String.Empty;

                if (i % fizz == 0)
                    result += "Fizz";
                if (i % buzz == 0)
                    result += "Buzz";

                if (result == String.Empty)
                    Console.WriteLine(i);
                else
                    Console.WriteLine(result);
            }
        }
    }
}