/* 
 * For all numbers 1 to 100:
 * If number is divisible by 5, print "Fizz"
 * If number is divisible by 3, print "Buzz"
 * If number is divisible by both 3 and 5, print "FizzBuz * 
 *
 * I added "Pop" for all other numbers for continuity.
 * I added "number: " using string interpolation for clarity.
 * I placed the entire program into a Method for execution.
 * The program is a for loop with nested if else statements.
 * Trevor Heehs
*/
using System;

namespace FizzBang
{
    class Program
    {
        static void Main()
        {
            FizzBuzz(); // Call FizzBuzz Method at execution.

            void FizzBuzz() // FizzBuzz Method declaration.
            {
                for (int i = 1; i <= 100; i++) // For loop.
                {
                    if (i % 3 == 0 && i % 5 == 0) // Nested if else.
                    {
                        Console.WriteLine($"{i}: FizzBuzz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine($"{i}: Fizz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine($"{i}: Buzz");
                    }
                    else
                    {
                        Console.WriteLine($"{i}: Pop");
                    }

                }
            }
        }
    }
}