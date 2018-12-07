/* Coding problem from Eloquent Javascript 3rd Edition by Marijn Haverbeke. Solution not provided. 
 * Adapted to C# by Trevor Heehs. This one I originally learned using JS on the boat.
 * 
 * "Write a program that creates a string that represents an 8×8 grid, using newline characters to separate lines. 
 * At each position of the grid there is either a space or a "#" character. The characters should form a chessboard.
 * Passing this string to console.log should show something like this..."
 * 
 *    # # # #
 *   # # # # 
 *    # # # #
 *   # # # # 
 *    # # # #
 *   # # # # 
 *    # # # #
 *   # # # #
 *   
*/
using System;

namespace Chessboard
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables fields outside of loop scope for access.
            const int MAX_SIZE = 8; 
            const string BLACK = "#";
            const string WHITE = " ";
            string board = "";

            // Outer loop creates multiple lines: board.
            for (int lineCount = 0; lineCount < MAX_SIZE; lineCount++)
            {
                // Inner loop creates single line.
                for (int spaceCount = 0; spaceCount < MAX_SIZE; spaceCount++)
                {
                    // If line number is even: runs the nested statement and print line.
                    if (lineCount % 2 == 0)
                    {
                        // Nested if-else determines even/odd space number and prints accordingly.
                        if (spaceCount % 2 == 0)
                        {
                            board += WHITE;
                        }
                        else
                        {
                            board += BLACK;
                        }
                    }
                    // Else: line number is odd and offsets the same effect.                     
                    else
                    {
                        if (spaceCount % 2 == 0)
                        {
                            board += BLACK;
                        }
                        else
                        {
                            board += WHITE;
                        }
                    }
                }
                // After inner loop finishes execution, newline is printed and outer loop repeats.
                board += "\n";  
            }
            // After outer loop finishes, loop exits and board is printed.
            Console.WriteLine(board); 
        }
    }
}