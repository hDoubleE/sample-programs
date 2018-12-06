using System;

namespace Factor
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine($"!0: {Method.Factorial(0)}"); 
            Console.WriteLine($"!5: {Method.Factorial(5)}");
            Console.WriteLine($"!7: {Method.Factorial(7)}");
            Console.WriteLine($"!11: {Method.Factorial(11)}");
            Console.WriteLine($"!14: {Method.Factorial(14)}");
        }

        // Output:
        // !0: 1
        // !5: 120
        // !7: 5040
        // !11: 39916800
        // !14: 1278945280
    }

    public class Method
    {
        // Define factorial Method, takes one integer input.
        public static int Factorial(int n)
        {
            // Handle 0 an 1 edge cases.
            if (n == 0 || n == 1)
            {
                return 1;
            }
            // Return n * recursive factorial method, subtracting 1 from n each call.
            return n * Factorial(n - 1);
        }
    }
}