/* Program to Reverse a string without using any built in methods. 
 * Code sample is from Stack Overflow, I've modified UI and sample code. 
 * www.stackoverflow.com/questions/16962322/
 * Trevor Heehs 
*/

using System;

namespace StringWork
{
    class Program
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
                    reverseString(userInput);
                }
            }
        }

        static void reverseString(string inputString)
        {
            string result = string.Empty;

            foreach (char c in inputString)
            {
                result = c + result;
            }
            Console.WriteLine(result + "\n");
        }
    }
}
