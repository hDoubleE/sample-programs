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
                    ReverseStringChar(userInput);
                }
            }
        }
        static string ReverseStringChar(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}