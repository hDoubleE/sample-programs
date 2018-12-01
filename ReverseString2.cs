/* Reverse string using built in Array.Reverse method.
 * No source provided, multiple references provide this 
 * as primary method for reversing a string. 
 * Trevor Heehs
 */


using System;

namespace StringWork
{
    class StringReverse
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Enter text to reverse or 'q' to quit:");
                string userInput = Console.ReadLine();

                if (userInput == string.Empty)
                {
                    Console.WriteLine("You didn't enter any text.\n");
                }
                else if (userInput == "Q" || userInput == "q")
                {
                    break;
                }
                else
                {
                    ReverseStringChar(userInput);
                }
            }
        }
        static void ReverseStringChar(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(arr);
        }
    }
}