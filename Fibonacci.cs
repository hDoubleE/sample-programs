/* 
   Here are three versions of the Fibonacci Sequence. One using iteration. 
   The other using method recursion. Inspired by the book: If Hemingway wrote JavaScript by Angus Croll.
   Source code is from Prakash Tripathi

https://www.c-sharpcorner.com/UploadFile/19b1bd/calculate-fibonacci-series-in-various-ways-using-C-Sharp/
   
   Very few modifications were made to source code as these tended to break the program. 
   Added while loop to explore implementation.
   Trevor Heehs
*/

using System;

namespace FibonacciSeq
{
    class Program
    // All (3) Fibonacci methods are declared statically and called by class from Main.
    // Newline escape characters used for output formatting. 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Fibonacci For Loop: \n");

            FibFor.DoTheForFib(25); // Call to For Loop Method.
            Console.WriteLine("\n");

            Console.WriteLine("The Fibonacci While Loop: \n");

            FibWhile.DoTheWhileFib(25); // Call to While Loop Method.
            Console.WriteLine("\n");

            Console.WriteLine("The Fibonacci Sequence Recursive Method: \n");

            FibRec.DoTheRecursiveFib(25); // Call to Recursive Method. 

            Console.WriteLine("\n");

        }
    }


    // This is the cleanest example in my opinion and the easiest to read. 
    class FibFor
    {
        public static void DoTheForFib(int lengthOfFib)
        {
            // Declare 3 starting variables.
            // Start the sequence at a(0) and b(1).
            // c is initialized to default(0) to hold the sum and a and b. 

            int a = 0, b = 1, c;

            Console.Write($"{a} {b}"); // Print 0 and 1.

            // The loop's i must be initialized at 2 due to 0 and 1 being set outside the loop. 
            // If initialized at zero sequence will exceed lengthOfFib by 2. 

            for (int i = 2; i < lengthOfFib; i++)
            {
                c = a + b;              // Set variable c to the sum of a and b.
                Console.Write($" {c}"); // Print c to sequence...
                a = b;                  // Bind variable a to the value of b.
                b = c;                  // Bind variable b to value of c. 

                // Repeat loop [argument 'lengthOfFib'] number of times. 
            }
        }
    }

    // While loop version operates similar to for loop.
    // Requires the declaration of additional counter variable. 
    // Counter is initialized at 2 due to 0 and 1 outside loop. 
    // Not as easy to read as for loop version. 

    class FibWhile
    {
        public static void DoTheWhileFib(int length)
        {
            int a = 0, b = 1, c, counter = 2;

            Console.Write($"{a} {b}");

            while (counter < length)
            {
                c = a + b;
                Console.Write($" {c}");
                a = b;
                b = c;
                counter++;
            }
        }
    }

    // The recursive method is unnecessarily complicated. 
    // For implementation I'd stick to the much simpler iterative approach.  

    class FibRec
    {
        // Create the method called during execution.
        // In the body of the called method make call to worker method and pass arguments.

        public static void DoTheRecursiveFib(int len)
        {
            FibRecursiveWork(0, 1, 1, len);
        }

        // Create the work method...this is where the magic happens. 
        // Arguments are provided from calling method and the values are worked by recursive method
        // declared inside method body. 
        // The if statement ends recursive loop when false.

        private static void FibRecursiveWork(int a, int b, int counter, int len)
        {
            if (counter <= len)
            {
                // Counter++ causes infinite loop. 
                // ++Counter or Counter + 1 work fine.
                Console.Write($"{a} ");
                FibRecursiveWork(b, a + b, ++counter, len);
            }
        }
    }
}