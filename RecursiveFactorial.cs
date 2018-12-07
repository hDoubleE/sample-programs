/*
 * No source. Unless Math is a source. Then I got this code from Math. 
 * Similar to Fibonacci recursive method, lends well to recursion. 
 * After some figuring this O(log n).
 * This program really helped me to "get" recursion.
 * Trevor Heehs
 */


using System;

namespace Factor
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine($"!0: {Factorial(0)}"); 
            Console.WriteLine($"!5: {Factorial(5)}");
            Console.WriteLine($"!7: {Factorial(7)}");
            Console.WriteLine($"!11: {Factorial(11)}");
            Console.WriteLine($"!14: {Factorial(14)}");
            // Any bigger and Int32 cant handle it...
        }

        // Output:
        // !0: 1
        // !5: 120
        // !7: 5040
        // !11: 39916800
        // !14: 1278945280
   
        // Define factorial Method, takes int input.
        private static int Factorial(int n)
        {
            // Handle 0 an 1 edge cases. Return 1, which is correct.
            if (n == 0 || n == 1)
            {
                return 1;
            }
            // Return n * recursive factorial method. 
            // Subtract 1 from n each call.
            //Repeat
            return n * Factorial(n - 1);
        }
    }
}