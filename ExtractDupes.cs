/* This program extracts duplicate characters from an input string.
 * Many examples remove dupes and print string without dupes. 
 * My goal was to store duplicates and print only the dupes.
 * Source: https://www.csharpstar.com/csharp-program-print-first-non-repeated-character-from-string/
 * Altered source code.
 * Trevor Heehs
 */

using System;
	
namespace Dupes
{
    public class Program
    {
        public static void Main()
	    {
            // Store result in variable.
            string extract1 = ExtractDupes("Google");
            string extract2 = ExtractDupes("Yeee Haawww!");

            // Print result.
            Console.WriteLine(extract1);
            System.Console.WriteLine(extract2);
            // Output:
            // oo
            // eeeaawww
	    }
        // The outer loop starts at index 0 and stays there while
        // the inner loop iterates through each character of the same string
        // comparing to index 0 of outer loop. 
        public static string ExtractDupes(string input)
	    {
	        string result = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    // IF inner loop integer index position (j)
                    // does not equal outer loop int index position,
                    // AND the char value of two chars are equal.
                    // Add char to result and break inner loop.
                    // Repeat.... 
                    if (i != j && (input[i] == input[j]))
                    {
                        result += input[j];
                        break;
                    }
                }
            }
            return result;
        }
    }
}
// Here's a simplified version of how this works...
// Outer: G
// Inner: Google...no match.
// Outer: o
// Inner: Go...if met, match!
// Add 'o' to result and break inner loop
// Outer: o
// Inner: oo...if met, match!
// add 'o' to result and break inner loop
// Outer: g
// Inner: gle...
// No further matches, print result.