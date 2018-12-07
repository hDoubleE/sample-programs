/*  C# Program to create a Hangman Game from:
    https://www.sanfoundry.com/csharp-programs-gaming-hangman/

    Flaws in program I changed:
    1) Program does not recognize capital letters. Fixed with ToLower.
    2) Program throws System.FormatException when multiple characters are entered as input.
       Fixed by including try/catch block. 
    3) This caused char playerGuess variable to be out of scope inside try/catch block. 
       Fixed by declaring playerGuess in class scope as empty char ' '.
    4) No you won statement, loop keeps going. Unresolved.

    Trevor Heehs 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangman
{
    class Program
    {
        static void Main()
        {
            // Welcome message.
            Console.WriteLine("Welcome to Hangman!!!!!!!!!!");

            // Declare and initilize an array of 10 strings.
            string[] listWords = new string[10];

            // This array could be initilized more tersely.
            listWords[0] = "sheep";
            listWords[1] = "goat";
            listWords[2] = "computer";
            listWords[3] = "america";
            listWords[4] = "watermelon";
            listWords[5] = "icecream";
            listWords[6] = "jasmine";
            listWords[7] = "pineapple";
            listWords[8] = "orange";
            listWords[9] = "mango";

            // Instantiates Random object for use.
            Random randGen = new Random();

            // Selects a random number between 0 and 9 and assigns to variable.
            var randomNumber = randGen.Next(0, 9);

            // Uses random number to choose word from listWords Array and assign to variable.
            string mysteryWord = listWords[randomNumber];

            // Assigns index length of word to char Array.
            char[] guess = new char[mysteryWord.Length];

            // Prompt user input
            Console.Write("Please enter your guess: ");


            // Loops through mysteryWord and prints * for all chars in array.
            for (int p = 0; p < mysteryWord.Length; p++)
            {
                guess[p] = '*';
            }

            // Moved playerGuess declaration into class scope and initialized to empty char.
            char playerGuess = ' ';

            while (true)
            {
                // Added try/catch block to hanlde FormatException thrown when user enters multiple characters.
                try
                {
                    playerGuess = char.Parse(Console.ReadLine().ToLower());
                }
                // Catches exception here.
                catch (System.FormatException)
                {
                    // And handles it!
                    Console.WriteLine("Only one character input!!!");
                }

                // Loops through mystery word and matches user guess. 
                for (int j = 0; j < mysteryWord.Length; j++)
                {
                    // If user guess = any char in mystrery word array...
                    if (playerGuess == mysteryWord[j])

                        // Reveal correct user guess to mysteryWord...
                        guess[j] = playerGuess;
                }

                // Print result of guesses and repeat loop until all characters are guessed.
                Console.WriteLine(guess);
            }
        }
    }
}
