/* The Name Game takes user input, reverses it and prints it to screen. 
 * Taken from Bob Tabor C# video on Microsoft Virtual Academy. 
 * Modified slightly by Trevor Heehs.
*/
using System;

namespace NameGame
{
    public class Program
    {
        static void Main()
        {
            // Declare string greetings.
            string begin = "WELCOME TO THE THE NAME GAME"; // Define vars.
            string gameOver = "YOU ARE DONE CONGRATS"; 

            //Call Intro Method and print greeting to console.
            Intro(begin);

            // Prompt user for personal data and assign input to variable.
            Console.Write("What's Your First Name? "); 
            string firstName = Console.ReadLine(); 

            Console.Write("What's Your Last Name? ");
            string LastName = Console.ReadLine();

            Console.Write("In what city were you born in? ");
            string cityName = Console.ReadLine();

            // Call ReverseString method defined below and assing to variables.
            string revFirst = ReverseString(firstName); 
            string revLast = ReverseString(LastName); 
            string revCity = ReverseString(cityName);

            // Call print method defined below.
            PrintResult(revFirst, revLast, revCity); 

            End(gameOver); // Call End method and printing outro.
        }
        private static void Intro(string b) // Intro method prints intro.
        {
            Console.WriteLine(b);
        }

        // Reverse method takes a string as argument.
        private static string ReverseString(string m) 
        {
            // Create char Array.
            char[] charArr = m.ToCharArray(); 

            // Reverse char Array.
            Array.Reverse(charArr); 

            //Return Array as string.
            return String.Concat(charArr); 
        }

        // Print Result Method returns result reversed strings.
        // Added string interpolation. Method provides formatting for output strings.
        private static void PrintResult(string f, string l, string c)
        {
            Console.WriteLine(String.Format($"{f} {l} {c}")); 

        }
        // End method prints outro.
        private static void End(string g) 
        {
            Console.WriteLine(g);
        }
    }
}