/* This is a simple program that examines the difference 
 * between the different increment and decrement operators. 
 * Not complex, but outputs key differences.
 * Source code: C# 7.0 Pocket Reference, Albahari and Albahari, p 24
 * Trevor Heehs
 */

using System;

namespace IncDec
{
    class Program
    {
        static void Main()
        {
            // Initialize x to 0.
            int x = 0;
            
            // Print x(0), then increment, x is now 1.
            Console.WriteLine(x++); 
            
            // Print x(1)
            Console.WriteLine(x);

            // Increment x, x is now 2, then print.
			Console.WriteLine(++x);

            // Print x(still 2), then decrement, x is now 1. 
            Console.WriteLine(x--);

            // Print x(1). 
            Console.WriteLine(x);

            // Decrement x, x is now 0, then print.
            Console.WriteLine(--x);

            // Output:
            // 0
            // 1
            // 2
            // 2
            // 1
            // 0
        }
    }
}